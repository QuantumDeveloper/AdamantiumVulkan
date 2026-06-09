#include "slang_c.h"

#include <slang.h>
#include <slang-com-ptr.h>

#include <atomic>
#include <cstring>
#include <string>
#include <vector>

using namespace slang;

static bool UuidEq(const SlangUUID& a, const SlangUUID& b)
{
    return std::memcmp(&a, &b, sizeof(SlangUUID)) == 0;
}

namespace {

// A minimal ISlangBlob that owns a copy of the bytes — returned from the VFS callback to Slang.
class ShimBlob : public ISlangBlob
{
public:
    ShimBlob(const unsigned char* data, size_t size) : data_(data, data + size) {}

    SLANG_NO_THROW SlangResult SLANG_MCALL queryInterface(SlangUUID const& uuid, void** out) override
    {
        if (UuidEq(uuid, ISlangUnknown::getTypeGuid()) || UuidEq(uuid, ISlangBlob::getTypeGuid()))
        {
            addRef();
            *out = static_cast<ISlangBlob*>(this);
            return SLANG_OK;
        }
        return SLANG_E_NO_INTERFACE;
    }
    SLANG_NO_THROW uint32_t SLANG_MCALL addRef() override { return ++refCount_; }
    SLANG_NO_THROW uint32_t SLANG_MCALL release() override
    {
        uint32_t c = --refCount_;
        if (c == 0) delete this;
        return c;
    }
    SLANG_NO_THROW void const* SLANG_MCALL getBufferPointer() override { return data_.data(); }
    SLANG_NO_THROW size_t SLANG_MCALL getBufferSize() override { return data_.size(); }

private:
    std::atomic<uint32_t>      refCount_{1};
    std::vector<unsigned char> data_;
};

// An ISlangFileSystem that forwards loadFile() to the engine's C callback (VFS hook).
class ShimFileSystem : public ISlangFileSystem
{
public:
    ShimFileSystem(SlangcLoadFileCallback cb, void* user) : cb_(cb), user_(user) {}

    SLANG_NO_THROW SlangResult SLANG_MCALL queryInterface(SlangUUID const& uuid, void** out) override
    {
        if (UuidEq(uuid, ISlangUnknown::getTypeGuid()) || UuidEq(uuid, ISlangCastable::getTypeGuid()) ||
            UuidEq(uuid, ISlangFileSystem::getTypeGuid()))
        {
            addRef();
            *out = static_cast<ISlangFileSystem*>(this);
            return SLANG_OK;
        }
        return SLANG_E_NO_INTERFACE;
    }
    SLANG_NO_THROW uint32_t SLANG_MCALL addRef() override { return ++refCount_; }
    SLANG_NO_THROW uint32_t SLANG_MCALL release() override
    {
        uint32_t c = --refCount_;
        if (c == 0) delete this;
        return c;
    }
    SLANG_NO_THROW void* SLANG_MCALL castAs(const SlangUUID& guid) override
    {
        if (UuidEq(guid, ISlangFileSystem::getTypeGuid()) || UuidEq(guid, ISlangCastable::getTypeGuid()) ||
            UuidEq(guid, ISlangUnknown::getTypeGuid()))
            return static_cast<ISlangFileSystem*>(this);
        return nullptr;
    }
    SLANG_NO_THROW SlangResult SLANG_MCALL loadFile(char const* path, ISlangBlob** outBlob) override
    {
        const unsigned char* data = nullptr;
        size_t               size = 0;
        if (cb_ && cb_(user_, path, &data, &size) && data)
        {
            *outBlob = new ShimBlob(data, size);
            return SLANG_OK;
        }
        return SLANG_E_NOT_FOUND;
    }

private:
    std::atomic<uint32_t>  refCount_{1};
    SlangcLoadFileCallback cb_;
    void*                  user_;
};

} // namespace

struct SlangcSession_T
{
    Slang::ComPtr<IGlobalSession>   global;
    Slang::ComPtr<ISession>         session;
    Slang::ComPtr<ISlangFileSystem> fileSystem; // keeps the VFS hook alive for the session's lifetime
};

struct SlangcResult_T
{
    bool                       ok = false;
    std::vector<unsigned char> spirv;
    std::string                diagnostics;
};

// Slang diagnostic blobs are text; build a sized std::string so we don't rely on null termination.
static std::string BlobToString(IBlob* blob)
{
    if (!blob || blob->getBufferSize() == 0)
        return std::string();
    return std::string(static_cast<const char*>(blob->getBufferPointer()), blob->getBufferSize());
}

extern "C" {

SLANGC_API SlangcSession slangc_session_create(
    const char* const* searchPaths, int searchPathCount,
    const char* const* defineNames, const char* const* defineValues, int defineCount,
    const char* profile,
    SlangcLoadFileCallback loadFile, void* userData)
{
    auto* s = new SlangcSession_T();

    if (SLANG_FAILED(createGlobalSession(s->global.writeRef())) || !s->global)
    {
        delete s;
        return nullptr;
    }

    TargetDesc target = {};
    target.format = SLANG_SPIRV;
    if (profile && profile[0])
    {
        SlangProfileID id = s->global->findProfile(profile);
        if (id != SLANG_PROFILE_UNKNOWN)
            target.profile = id;
    }

    std::vector<PreprocessorMacroDesc> macros;
    macros.reserve(defineCount > 0 ? defineCount : 0);
    for (int i = 0; i < defineCount; ++i)
        macros.push_back(PreprocessorMacroDesc{ defineNames[i], defineValues ? defineValues[i] : "" });

    SessionDesc desc = {};
    desc.targets                = &target;
    desc.targetCount            = 1;
    desc.searchPaths            = (searchPathCount > 0) ? searchPaths : nullptr;
    desc.searchPathCount        = searchPathCount;
    desc.preprocessorMacros     = macros.empty() ? nullptr : macros.data();
    desc.preprocessorMacroCount = static_cast<SlangInt>(macros.size());

    if (loadFile)
    {
        s->fileSystem.attach(new ShimFileSystem(loadFile, userData)); // owns the single initial ref
        desc.fileSystem = s->fileSystem.get();
    }

    if (SLANG_FAILED(s->global->createSession(desc, s->session.writeRef())) || !s->session)
    {
        delete s;
        return nullptr;
    }

    return s;
}

SLANGC_API SlangcResult slangc_compile(
    SlangcSession session,
    const char* moduleName,
    const char* source,
    const char* entryPoint,
    SlangcStage stage)
{
    auto* r = new SlangcResult_T();

    if (!session || !session->session)
    {
        r->diagnostics = "slangc: invalid session";
        return r;
    }

    Slang::ComPtr<IBlob> diagnostics;
    const char* name = (moduleName && moduleName[0]) ? moduleName : "module";

    // The module is owned by the session (borrowed pointer) — do not release it.
    IModule* module = session->session->loadModuleFromSourceString(name, name, source, diagnostics.writeRef());
    if (!module)
    {
        r->diagnostics = diagnostics ? BlobToString(diagnostics) : "slangc: failed to load module";
        return r;
    }

    // findAndCheckEntryPoint resolves plain functions too (no [shader("...")] attribute needed).
    Slang::ComPtr<IEntryPoint> ep;
    if (SLANG_FAILED(module->findAndCheckEntryPoint(entryPoint, static_cast<SlangStage>(stage), ep.writeRef(), diagnostics.writeRef())) || !ep)
    {
        r->diagnostics = diagnostics ? BlobToString(diagnostics) : "slangc: entry point not found";
        return r;
    }

    IComponentType* components[] = { module, ep.get() };
    Slang::ComPtr<IComponentType> composite;
    if (SLANG_FAILED(session->session->createCompositeComponentType(components, 2, composite.writeRef(), diagnostics.writeRef())))
    {
        r->diagnostics = diagnostics ? BlobToString(diagnostics) : "slangc: failed to compose";
        return r;
    }

    Slang::ComPtr<IComponentType> linked;
    if (SLANG_FAILED(composite->link(linked.writeRef(), diagnostics.writeRef())))
    {
        r->diagnostics = diagnostics ? BlobToString(diagnostics) : "slangc: link failed";
        return r;
    }

    Slang::ComPtr<IBlob> code;
    if (SLANG_FAILED(linked->getEntryPointCode(0, 0, code.writeRef(), diagnostics.writeRef())) || !code)
    {
        r->diagnostics = diagnostics ? BlobToString(diagnostics) : "slangc: code generation failed";
        return r;
    }

    const auto* bytes = static_cast<const unsigned char*>(code->getBufferPointer());
    r->spirv.assign(bytes, bytes + code->getBufferSize());
    r->diagnostics = BlobToString(diagnostics); // surface warnings, if any
    r->ok = true;
    return r;
}

SLANGC_API int slangc_result_ok(SlangcResult result)
{
    return (result && result->ok) ? 1 : 0;
}

SLANGC_API const void* slangc_result_spirv(SlangcResult result, size_t* outSize)
{
    if (!result || result->spirv.empty())
    {
        if (outSize) *outSize = 0;
        return nullptr;
    }
    if (outSize) *outSize = result->spirv.size();
    return result->spirv.data();
}

SLANGC_API const char* slangc_result_diagnostics(SlangcResult result)
{
    return result ? result->diagnostics.c_str() : "";
}

SLANGC_API void slangc_result_release(SlangcResult result)
{
    delete result;
}

SLANGC_API void slangc_session_release(SlangcSession session)
{
    delete session;
}

} // extern "C"
