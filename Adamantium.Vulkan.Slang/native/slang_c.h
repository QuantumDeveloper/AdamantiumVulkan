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
 * Compiler option names — a 1:1 mirror of slang::CompilerOptionName (values must match exactly).
 * The SLANGC_OPT_ prefix is stripped by the binding generator, so the C# enum members read e.g.
 * SlangcCompilerOptionName.VulkanUseEntryPointName. This is the full Slang option surface; almost every
 * Slang/CLI setting (matrix layout, optimization, debug info, floating-point mode, Vulkan binding shifts,
 * target flags, …) is one of these, so passing an array of options covers the whole compiler config.
 */
typedef enum SlangcCompilerOptionName
{
    SLANGC_OPT_MacroDefine = 0,
    SLANGC_OPT_DepFile = 1,
    SLANGC_OPT_EntryPointName = 2,
    SLANGC_OPT_Specialize = 3,
    SLANGC_OPT_Help = 4,
    SLANGC_OPT_HelpStyle = 5,
    SLANGC_OPT_Include = 6,
    SLANGC_OPT_Language = 7,
    SLANGC_OPT_MatrixLayoutColumn = 8,
    SLANGC_OPT_MatrixLayoutRow = 9,
    SLANGC_OPT_ZeroInitialize = 10,
    SLANGC_OPT_IgnoreCapabilities = 11,
    SLANGC_OPT_RestrictiveCapabilityCheck = 12,
    SLANGC_OPT_ModuleName = 13,
    SLANGC_OPT_Output = 14,
    SLANGC_OPT_Profile = 15,
    SLANGC_OPT_Stage = 16,
    SLANGC_OPT_Target = 17,
    SLANGC_OPT_Version = 18,
    SLANGC_OPT_WarningsAsErrors = 19,
    SLANGC_OPT_DisableWarnings = 20,
    SLANGC_OPT_EnableWarning = 21,
    SLANGC_OPT_DisableWarning = 22,
    SLANGC_OPT_DumpWarningDiagnostics = 23,
    SLANGC_OPT_InputFilesRemain = 24,
    SLANGC_OPT_EmitIr = 25,
    SLANGC_OPT_ReportDownstreamTime = 26,
    SLANGC_OPT_ReportPerfBenchmark = 27,
    SLANGC_OPT_ReportCheckpointIntermediates = 28,
    SLANGC_OPT_SkipSPIRVValidation = 29,
    SLANGC_OPT_SourceEmbedStyle = 30,
    SLANGC_OPT_SourceEmbedName = 31,
    SLANGC_OPT_SourceEmbedLanguage = 32,
    SLANGC_OPT_DisableShortCircuit = 33,
    SLANGC_OPT_MinimumSlangOptimization = 34,
    SLANGC_OPT_DisableNonEssentialValidations = 35,
    SLANGC_OPT_DisableSourceMap = 36,
    SLANGC_OPT_UnscopedEnum = 37,
    SLANGC_OPT_PreserveParameters = 38,
    SLANGC_OPT_Capability = 39,
    SLANGC_OPT_DefaultImageFormatUnknown = 40,
    SLANGC_OPT_DisableDynamicDispatch = 41,
    SLANGC_OPT_DisableSpecialization = 42,
    SLANGC_OPT_FloatingPointMode = 43,
    SLANGC_OPT_DebugInformation = 44,
    SLANGC_OPT_LineDirectiveMode = 45,
    SLANGC_OPT_Optimization = 46,
    SLANGC_OPT_Obfuscate = 47,
    SLANGC_OPT_VulkanBindShift = 48,
    SLANGC_OPT_VulkanBindGlobals = 49,
    SLANGC_OPT_VulkanInvertY = 50,
    SLANGC_OPT_VulkanUseDxPositionW = 51,
    SLANGC_OPT_VulkanUseEntryPointName = 52,
    SLANGC_OPT_VulkanUseGLLayout = 53,
    SLANGC_OPT_VulkanEmitReflection = 54,
    SLANGC_OPT_GLSLForceScalarLayout = 55,
    SLANGC_OPT_EnableEffectAnnotations = 56,
    SLANGC_OPT_EmitSpirvViaGLSL = 57,
    SLANGC_OPT_EmitSpirvDirectly = 58,
    SLANGC_OPT_SPIRVCoreGrammarJSON = 59,
    SLANGC_OPT_IncompleteLibrary = 60,
    SLANGC_OPT_CompilerPath = 61,
    SLANGC_OPT_DefaultDownstreamCompiler = 62,
    SLANGC_OPT_DownstreamArgs = 63,
    SLANGC_OPT_PassThrough = 64,
    SLANGC_OPT_DumpRepro = 65,
    SLANGC_OPT_DumpReproOnError = 66,
    SLANGC_OPT_ExtractRepro = 67,
    SLANGC_OPT_LoadRepro = 68,
    SLANGC_OPT_LoadReproDirectory = 69,
    SLANGC_OPT_ReproFallbackDirectory = 70,
    SLANGC_OPT_DumpAst = 71,
    SLANGC_OPT_DumpIntermediatePrefix = 72,
    SLANGC_OPT_DumpIntermediates = 73,
    SLANGC_OPT_DumpIr = 74,
    SLANGC_OPT_DumpIrIds = 75,
    SLANGC_OPT_PreprocessorOutput = 76,
    SLANGC_OPT_OutputIncludes = 77,
    SLANGC_OPT_ReproFileSystem = 78,
    SLANGC_OPT_REMOVED_SerialIR = 79,
    SLANGC_OPT_SkipCodeGen = 80,
    SLANGC_OPT_ValidateIr = 81,
    SLANGC_OPT_VerbosePaths = 82,
    SLANGC_OPT_VerifyDebugSerialIr = 83,
    SLANGC_OPT_NoCodeGen = 84,
    SLANGC_OPT_FileSystem = 85,
    SLANGC_OPT_Heterogeneous = 86,
    SLANGC_OPT_NoMangle = 87,
    SLANGC_OPT_NoHLSLBinding = 88,
    SLANGC_OPT_NoHLSLPackConstantBufferElements = 89,
    SLANGC_OPT_ValidateUniformity = 90,
    SLANGC_OPT_AllowGLSL = 91,
    SLANGC_OPT_EnableExperimentalPasses = 92,
    SLANGC_OPT_BindlessSpaceIndex = 93,
    SLANGC_OPT_SPIRVResourceHeapStride = 94,
    SLANGC_OPT_SPIRVSamplerHeapStride = 95,
    SLANGC_OPT_ArchiveType = 96,
    SLANGC_OPT_CompileCoreModule = 97,
    SLANGC_OPT_Doc = 98,
    SLANGC_OPT_IrCompression = 99,
    SLANGC_OPT_LoadCoreModule = 100,
    SLANGC_OPT_ReferenceModule = 101,
    SLANGC_OPT_SaveCoreModule = 102,
    SLANGC_OPT_SaveCoreModuleBinSource = 103,
    SLANGC_OPT_TrackLiveness = 104,
    SLANGC_OPT_LoopInversion = 105,
    SLANGC_OPT_ParameterBlocksUseRegisterSpaces = 106,
    SLANGC_OPT_LanguageVersion = 107,
    SLANGC_OPT_TypeConformance = 108,
    SLANGC_OPT_EnableExperimentalDynamicDispatch = 109,
    SLANGC_OPT_EmitReflectionJSON = 110,
    SLANGC_OPT_CountOfParsableOptions = 111,
    SLANGC_OPT_DebugInformationFormat = 112,
    SLANGC_OPT_VulkanBindShiftAll = 113,
    SLANGC_OPT_GenerateWholeProgram = 114,
    SLANGC_OPT_UseUpToDateBinaryModule = 115,
    SLANGC_OPT_EmbedDownstreamIR = 116,
    SLANGC_OPT_ForceDXLayout = 117,
    SLANGC_OPT_EmitSpirvMethod = 118,
    SLANGC_OPT_SaveGLSLModuleBinSource = 119,
    SLANGC_OPT_SkipDownstreamLinking = 120,
    SLANGC_OPT_DumpModule = 121,
    SLANGC_OPT_GetModuleInfo = 122,
    SLANGC_OPT_GetSupportedModuleVersions = 123,
    SLANGC_OPT_EmitSeparateDebug = 124,
    SLANGC_OPT_DenormalModeFp16 = 125,
    SLANGC_OPT_DenormalModeFp32 = 126,
    SLANGC_OPT_DenormalModeFp64 = 127,
    SLANGC_OPT_UseMSVCStyleBitfieldPacking = 128,
    SLANGC_OPT_ForceCLayout = 129,
    SLANGC_OPT_ExperimentalFeature = 130,
    SLANGC_OPT_ReportDetailedPerfBenchmark = 131,
    SLANGC_OPT_ValidateIRDetailed = 132,
    SLANGC_OPT_DumpIRBefore = 133,
    SLANGC_OPT_DumpIRAfter = 134,
    SLANGC_OPT_EmitCPUMethod = 135,
    SLANGC_OPT_EmitCPUViaCPP = 136,
    SLANGC_OPT_EmitCPUViaLLVM = 137,
    SLANGC_OPT_LLVMTargetTriple = 138,
    SLANGC_OPT_LLVMCPU = 139,
    SLANGC_OPT_LLVMFeatures = 140,
    SLANGC_OPT_EnableRichDiagnostics = 141,
    SLANGC_OPT_ReportDynamicDispatchSites = 142,
    SLANGC_OPT_EnableMachineReadableDiagnostics = 143,
    SLANGC_OPT_DiagnosticColor = 144
} SlangcCompilerOptionName;

/*
 * One Slang compiler option, mirroring slang::CompilerOptionEntry. `name` is a SlangcCompilerOptionName
 * value. `valueKind` selects which value fields are used: 0 = int/bool (intValue0/intValue1), 1 = string
 * (stringValue0/stringValue1). Passing an array of these to slangc_session_create lets the compiler be
 * configured from C# without changing this shim.
 */
typedef struct SlangcCompilerOption
{
    int          name;
    int          valueKind;     /* 0 = int, 1 = string */
    int          intValue0;
    int          intValue1;
    const char*  stringValue0;
    const char*  stringValue1;
} SlangcCompilerOption;

/*
 * Creates a session that targets SPIR-V.
 *   searchPaths        : #include / import search directories (may be NULL if count==0)
 *   defineNames/Values : parallel arrays of preprocessor macros (Values may be NULL)
 *   profile            : optional Slang profile name (e.g. "spirv_1_5", "sm_6_0"); NULL/"" = default
 *   options            : compiler options applied to the SPIR-V target (may be NULL if count==0)
 *   loadFile/userData  : optional VFS callback for resolving includes/imports; NULL = OS filesystem
 * Returns NULL on failure.
 */
SLANGC_API SlangcSession slangc_session_create(
    const char* const* searchPaths, int searchPathCount,
    const char* const* defineNames, const char* const* defineValues, int defineCount,
    const char* profile,
    const SlangcCompilerOption* options, int optionCount,
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
