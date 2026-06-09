/*
 * slang-c-shared: a thin flat-C facade over the Slang C++ compiler API.
 *
 * Slang's public API is C++/COM-style; QuantumBinding only parses C headers, so this shim exposes
 * the few operations the engine needs (compile an entry point of an HLSL/Slang source to SPIR-V,
 * plus diagnostics) as opaque-handle C functions. Reflection is intentionally NOT here — the engine
 * already reflects the produced SPIR-V via SPIRV-Cross.
 */
#ifndef SLANG_C_SHARED_H
#define SLANG_C_SHARED_H

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

#if defined(_WIN32)
#define SLANGC_API __declspec(dllexport)
#else
#define SLANGC_API __attribute__((visibility("default")))
#endif

/* Opaque handles. */
typedef struct SlangcSession_T* SlangcSession;
typedef struct SlangcResult_T*  SlangcResult;

/* Shader stage. Values mirror Slang's SlangStage so mapping is trivial. */
typedef enum SlangcStage
{
    SLANGC_STAGE_NONE           = 0,
    SLANGC_STAGE_VERTEX         = 1,
    SLANGC_STAGE_HULL           = 2,   /* tessellation control */
    SLANGC_STAGE_DOMAIN         = 3,   /* tessellation evaluation */
    SLANGC_STAGE_GEOMETRY       = 4,
    SLANGC_STAGE_FRAGMENT       = 5,   /* a.k.a. pixel */
    SLANGC_STAGE_COMPUTE        = 6,
    /* ray tracing */
    SLANGC_STAGE_RAY_GENERATION = 7,
    SLANGC_STAGE_INTERSECTION   = 8,
    SLANGC_STAGE_ANY_HIT        = 9,
    SLANGC_STAGE_CLOSEST_HIT    = 10,
    SLANGC_STAGE_MISS           = 11,
    SLANGC_STAGE_CALLABLE       = 12,
    /* mesh pipeline */
    SLANGC_STAGE_MESH           = 13,
    SLANGC_STAGE_AMPLIFICATION  = 14   /* a.k.a. task */
} SlangcStage;

/*
 * Include / import resolution callback (optional). When set, Slang asks it for file contents instead
 * of touching the OS filesystem — wire it to the engine's VFS / asset system. Return 1 if the file was
 * found (and write *outData / *outSize; the buffer must stay valid until the call returns — the shim
 * copies it immediately), or 0 if not found. `userData` is the opaque pointer passed to the session.
 */
typedef int (*SlangcLoadFileCallback)(
    void* userData, const char* path, const unsigned char** outData, size_t* outSize);

/*
 * Creates a session that targets SPIR-V.
 *   searchPaths        : #include / import search directories (may be NULL if count==0)
 *   defineNames/Values : parallel arrays of preprocessor macros (Values may be NULL)
 *   profile            : optional Slang profile name (e.g. "spirv_1_5", "sm_6_0"); NULL/"" = default
 *   loadFile/userData  : optional VFS callback for resolving includes/imports; NULL = OS filesystem
 * Returns NULL on failure.
 */
SLANGC_API SlangcSession slangc_session_create(
    const char* const* searchPaths, int searchPathCount,
    const char* const* defineNames, const char* const* defineValues, int defineCount,
    const char* profile,
    SlangcLoadFileCallback loadFile, void* userData);

/*
 * Compiles one entry point of an in-memory source (HLSL or Slang) to SPIR-V.
 * Never returns NULL: on failure the result reports !ok and carries the diagnostics text.
 */
SLANGC_API SlangcResult slangc_compile(
    SlangcSession session,
    const char* moduleName,
    const char* source,
    const char* entryPoint,
    SlangcStage stage);

/* 1 if compilation succeeded and SPIR-V is available, else 0. */
SLANGC_API int slangc_result_ok(SlangcResult result);

/* Pointer to the SPIR-V bytes (owned by the result); writes the byte count to outSize.
   Returns void* (not unsigned char*) so QuantumBinding emits a real pointer instead of
   collapsing it to a single byte; the caller marshals outSize bytes from it. */
SLANGC_API const void* slangc_result_spirv(SlangcResult result, size_t* outSize);

/* Null-terminated diagnostics text (errors on failure, warnings on success). Owned by the result. */
SLANGC_API const char* slangc_result_diagnostics(SlangcResult result);

SLANGC_API void slangc_result_release(SlangcResult result);
SLANGC_API void slangc_session_release(SlangcSession session);

#ifdef __cplusplus
}
#endif

#endif /* SLANG_C_SHARED_H */
