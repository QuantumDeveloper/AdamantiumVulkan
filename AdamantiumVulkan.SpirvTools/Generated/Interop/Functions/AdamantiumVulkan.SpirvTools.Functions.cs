// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.SpirvTools;

namespace AdamantiumVulkan.SpirvTools.Interop;

public static unsafe partial class SpirvToolsInterop
{
    public const string LibraryPath = "SPIRV-Tools-shared";

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 846 Column: 25
    ///<summary>
    /// Frees a binary stream from memory. This is a no-op if binary is a null pointer.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvBinaryDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvBinaryDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_binary_t binary);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 930 Column: 33
    ///<summary>
    /// Parses a SPIR-V binary, specified as counted sequence of 32-bit words. Parsing feedback is provided via two callbacks provided as function pointers. Each callback function pointer can be a null pointer, in which case it is never called. Otherwise, in a valid parse the parsed-header callback is called once, and then the parsed-instruction callback once for each instruction in the stream. The user_data parameter is supplied as context to the callbacks. Returns SPV_SUCCESS on successful parse where the callbacks always return SPV_SUCCESS. For an invalid parse, returns a status code other than SPV_SUCCESS, and if diagnostic is non-null also emits a diagnostic. If diagnostic is null the context's message consumer will be used to emit any errors. If a callback returns anything other than SPV_SUCCESS, then that status code is returned, no further callbacks are issued, and no additional diagnostics are emitted.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvBinaryParse", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvBinaryParse(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, void* user_data, uint* words, ulong num_words, void* parse_header, void* parse_instruction, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 837 Column: 33
    ///<summary>
    /// Decodes the given SPIR-V binary representation to its assembly text. The word_count parameter specifies the number of words for binary. The options parameter is a bit field of spv_binary_to_text_options_t. Decoded text will be stored into *text. Any error will be written into *diagnostic if diagnostic is non-null, otherwise the context's message consumer will be used.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvBinaryToText", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvBinaryToText(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, byte* binary, ulong word_count, uint options, out AdamantiumVulkan.SpirvTools.Interop.spv_text* text, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic* diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 597 Column: 32
    ///<summary>
    /// Creates a context object for most of the SPIRV-Tools API. Returns null if env is invalid.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvContextCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_context_t spvContextCreate(spv_target_env env);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 600 Column: 25
    ///<summary>
    /// Destroys the given context object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvContextDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvContextDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 885 Column: 1
    ///<summary>
    /// Creates a diagnostic object. The position parameter specifies the location in the text/binary stream. The message parameter, copied into the diagnostic object, contains the error message to display.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvDiagnosticCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_diagnostic spvDiagnosticCreate(AdamantiumVulkan.SpirvTools.Interop.spv_position_t position, sbyte* message);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 889 Column: 25
    ///<summary>
    /// Destroys a diagnostic object. This is a no-op if diagnostic is a null pointer.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvDiagnosticDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvDiagnosticDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 893 Column: 1
    ///<summary>
    /// Prints the diagnostic to stderr.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvDiagnosticPrint", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvDiagnosticPrint(AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 771 Column: 39
    ///<summary>
    /// Creates a fuzzer options object with default options. Returns a valid options object. The object remains valid until it is passed into |spvFuzzerOptionsDestroy|.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_fuzzer_options_t spvFuzzerOptionsCreate();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 774 Column: 25
    ///<summary>
    /// Destroys the given fuzzer options object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 804 Column: 25
    ///<summary>
    /// Enables all fuzzer passes during a fuzzing run (instead of a random subset of passes).
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsEnableAllPasses", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsEnableAllPasses(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 799 Column: 25
    ///<summary>
    /// Enables running the validator after every pass is applied during a fuzzing run.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsEnableFuzzerPassValidation", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsEnableFuzzerPassValidation(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 778 Column: 25
    ///<summary>
    /// Enables running the validator after every transformation is applied during a replay.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsEnableReplayValidation", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsEnableReplayValidation(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 783 Column: 25
    ///<summary>
    /// Sets the seed with which the random number generator used by the fuzzer should be initialized.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsSetRandomSeed", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsSetRandomSeed(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options, uint seed);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 789 Column: 25
    ///<summary>
    /// Sets the range of transformations that should be applied during replay: 0 means all transformations, +N means the first N transformations, -N means all except the final N transformations.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsSetReplayRange", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsSetReplayRange(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options, int replay_range);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 794 Column: 25
    ///<summary>
    /// Sets the maximum number of steps that the shrinker should take before giving up.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvFuzzerOptionsSetShrinkerStepLimit", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvFuzzerOptionsSetShrinkerStepLimit(AdamantiumVulkan.SpirvTools.Interop.spv_fuzzer_options_t options, uint shrinker_step_limit);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 896 Column: 32
    ///<summary>
    /// Gets the name of an instruction, without the "Op" prefix.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOpcodeString", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern sbyte* spvOpcodeString(uint opcode);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 313 Column: 6
    ///<summary>
    /// Returns true if the given type is concrete.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOperandIsConcrete", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvOperandIsConcrete(spv_operand_type_t type);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 316 Column: 6
    ///<summary>
    /// Returns true if the given type is concrete and also a mask.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOperandIsConcreteMask", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvOperandIsConcreteMask(spv_operand_type_t type);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 943 Column: 37
    ///<summary>
    /// Creates and returns an optimizer object. This object must be passed to optimizer APIs below and is valid until passed to spvOptimizerDestroy.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_optimizer_t* spvOptimizerCreate(spv_target_env env);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 946 Column: 25
    ///<summary>
    /// Destroys the given optimizer object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 712 Column: 42
    ///<summary>
    /// Creates an optimizer options object with default options. Returns a valid options object. The object remains valid until it is passed into |spvOptimizerOptionsDestroy|.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_optimizer_options_t spvOptimizerOptionsCreate();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 715 Column: 25
    ///<summary>
    /// Destroys the given optimizer options object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 729 Column: 25
    ///<summary>
    /// Records the maximum possible value for the id bound.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsSetMaxIdBound", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsSetMaxIdBound(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options, uint val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 733 Column: 25
    ///<summary>
    /// Records whether all bindings within the module should be preserved.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsSetPreserveBindings", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsSetPreserveBindings(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 738 Column: 25
    ///<summary>
    /// Records whether all specialization constants within the module should be preserved.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsSetPreserveSpecConstants", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsSetPreserveSpecConstants(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 720 Column: 25
    ///<summary>
    /// Records whether or not the optimizer should run the validator before optimizing. If |val| is true, the validator will be run.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsSetRunValidator", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsSetRunValidator(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 725 Column: 25
    ///<summary>
    /// Records the validator options that should be passed to the validator if it is run.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerOptionsSetValidatorOptions", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerOptionsSetValidatorOptions(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options, AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 953 Column: 25
    ///<summary>
    /// Registers passes that attempt to legalize the generated code.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRegisterLegalizationPasses", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerRegisterLegalizationPasses(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 969 Column: 25
    ///<summary>
    /// Registers passes specified by length number of flags in an optimizer object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRegisterPassesFromFlags", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvOptimizerRegisterPassesFromFlags(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer, sbyte** flags, ulong flag_count);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 965 Column: 25
    ///<summary>
    /// Registers a pass specified by a flag in an optimizer object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRegisterPassFromFlag", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvOptimizerRegisterPassFromFlag(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer, sbyte* flag);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 957 Column: 25
    ///<summary>
    /// Registers passes that attempt to improve performance of generated code.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRegisterPerformancePasses", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerRegisterPerformancePasses(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 961 Column: 25
    ///<summary>
    /// Registers passes that attempt to improve the size of generated code.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRegisterSizePasses", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerRegisterSizePasses(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 988 Column: 33
    ///<summary>
    /// Optimizes the SPIR-V code of size |word_count| pointed to by |binary| and returns an optimized spv_binary in |optimized_binary|.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerRun", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvOptimizerRun(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer, uint* binary, ulong word_count, out AdamantiumVulkan.SpirvTools.Interop.spv_binary_t optimized_binary, AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 949 Column: 25
    ///<summary>
    /// Sets an spv_message_consumer on an optimizer object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvOptimizerSetMessageConsumer", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvOptimizerSetMessageConsumer(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_t* optimizer, void* consumer);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 577 Column: 25
    ///<summary>
    /// Parses s into *env and returns true if successful. If unparsable, returns false and sets *env to SPV_ENV_UNIVERSAL_1_0.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvParseTargetEnv", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvParseTargetEnv(sbyte* s, spv_target_env* env);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 588 Column: 25
    ///<summary>
    /// Determines the target env value with the least features but which enables the given Vulkan and SPIR-V versions. If such a target is supported, returns true and writes the value to |env|, otherwise returns false.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvParseVulkanEnv", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern bool spvParseVulkanEnv(uint vulkan_ver, uint spirv_ver, spv_target_env* env);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 744 Column: 40
    ///<summary>
    /// Creates a reducer options object with default options. Returns a valid options object. The object remains valid until it is passed into |spvReducerOptionsDestroy|.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvReducerOptionsCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_reducer_options_t spvReducerOptionsCreate();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 747 Column: 25
    ///<summary>
    /// Destroys the given reducer options object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvReducerOptionsDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvReducerOptionsDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 758 Column: 25
    ///<summary>
    /// Sets the fail-on-validation-error option; if true, the reducer will return kStateInvalid if a reduction step yields a state that fails SPIR-V validation. Otherwise, an invalid state is treated as uninteresting and the reduction backtracks and continues.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvReducerOptionsSetFailOnValidationError", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvReducerOptionsSetFailOnValidationError(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t options, bool fail_on_validation_error);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 751 Column: 25
    ///<summary>
    /// Sets the maximum number of reduction steps that should run before the reducer gives up.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvReducerOptionsSetStepLimit", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvReducerOptionsSetStepLimit(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t options, uint step_limit);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 765 Column: 25
    ///<summary>
    /// Sets the function that the reducer should target. If set to zero the reducer will target all functions as well as parts of the module that lie outside functions. Otherwise the reducer will restrict reduction to the function with result id |target_function|, which is required to exist.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvReducerOptionsSetTargetFunction", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvReducerOptionsSetTargetFunction(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t options, uint target_function);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 504 Column: 32
    ///<summary>
    /// Returns a null-terminated string containing the name of the project, the software version string, and commit details. The contents of the underlying storage is valid for the remainder of the process.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvSoftwareVersionDetailsString", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern sbyte* spvSoftwareVersionDetailsString();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 499 Column: 32
    ///<summary>
    /// Returns the SPIRV-Tools software version as a null-terminated string. The contents of the underlying storage is valid for the remainder of the process.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvSoftwareVersionString", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern sbyte* spvSoftwareVersionString();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 573 Column: 32
    ///<summary>
    /// Returns a string describing the given SPIR-V target environment.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvTargetEnvDescription", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern sbyte* spvTargetEnvDescription(spv_target_env env);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 829 Column: 25
    ///<summary>
    /// Frees an allocated text stream. This is a no-op if the text parameter is a null pointer.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvTextDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvTextDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_text text);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 814 Column: 33
    ///<summary>
    /// Encodes the given SPIR-V assembly text to its binary representation. The length parameter specifies the number of bytes for text. Encoded binary will be stored into *binary. Any error will be written into *diagnostic if diagnostic is non-null, otherwise the context's message consumer will be used. The generated binary is independent of the context and may outlive it. The SPIR-V binary version is set to the highest version of SPIR-V supported by the context's target environment.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvTextToBinary", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvTextToBinary(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, sbyte* text, ulong length, out AdamantiumVulkan.SpirvTools.Interop.spv_binary_t binary, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 823 Column: 33
    ///<summary>
    /// Encodes the given SPIR-V assembly text to its binary representation. Same as spvTextToBinary but with options. The options parameter is a bit field of spv_text_to_binary_options_t.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvTextToBinaryWithOptions", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvTextToBinaryWithOptions(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, sbyte* text, ulong length, uint options, out AdamantiumVulkan.SpirvTools.Interop.spv_binary_t binary, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 857 Column: 33
    ///<summary>
    /// Validates a SPIR-V binary for correctness. Any errors will be written into *diagnostic if diagnostic is non-null, otherwise the context's message consumer will be used.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvValidate(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t binary, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 878 Column: 1
    ///<summary>
    /// Validates a raw SPIR-V binary for correctness. Any errors will be written into *diagnostic if diagnostic is non-null, otherwise the context's message consumer will be used.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidateBinary", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvValidateBinary(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, uint* words, ulong num_words, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 870 Column: 33
    ///<summary>
    /// Validates a SPIR-V binary for correctness. Uses the provided Validator options. Any errors will be written into *diagnostic if diagnostic is non-null, otherwise the context's message consumer will be used.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidateWithOptions", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_result_t spvValidateWithOptions(AdamantiumVulkan.SpirvTools.Interop.spv_context_t context, AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t binary, out AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic diagnostic);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 605 Column: 42
    ///<summary>
    /// Creates a Validator options object with default options. Returns a valid options object. The object remains valid until it is passed into spvValidatorOptionsDestroy.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsCreate", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern spv_validator_options_t spvValidatorOptionsCreate();

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 608 Column: 25
    ///<summary>
    /// Destroys the given Validator options object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsDestroy", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsDestroy(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 702 Column: 25
    ///<summary>
    /// Records whether or not the validator should allow the LocalSizeId decoration where the environment otherwise would not allow it.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetAllowLocalSizeId", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetAllowLocalSizeId(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 652 Column: 25
    ///<summary>
    /// Records whether or not the validator should relax the rules because it is expected that the optimizations will make the code legal.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetBeforeHlslLegalization", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetBeforeHlslLegalization(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 706 Column: 25
    ///<summary>
    /// Whether friendly names should be used in validation error messages.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetFriendlyNames", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetFriendlyNames(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 662 Column: 25
    ///<summary>
    /// Records whether the validator should use "relaxed" block layout rules. Relaxed layout rules are described by Vulkan extension VK_KHR_relaxed_block_layout, and they affect uniform blocks, storage blocks, and push constants.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetRelaxBlockLayout", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetRelaxBlockLayout(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 636 Column: 25
    ///<summary>
    /// Records whether or not the validator should relax the rules on pointer usage in logical addressing mode.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetRelaxLogicalPointer", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetRelaxLogicalPointer(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 627 Column: 25
    ///<summary>
    /// Record whether or not the validator should relax the rules on types for stores to structs. When relaxed, it will allow a type mismatch as long as the types are structs with the same layout. Two structs have the same layout if
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetRelaxStoreStruct", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetRelaxStoreStruct(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 686 Column: 25
    ///<summary>
    /// Records whether the validator should use "scalar" block layout rules. Scalar layout rules are more permissive than relaxed block layout.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetScalarBlockLayout", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetScalarBlockLayout(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 697 Column: 25
    ///<summary>
    /// Records whether or not the validator should skip validating standard uniform/storage block layout.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetSkipBlockLayout", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetSkipBlockLayout(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 667 Column: 25
    ///<summary>
    /// Records whether the validator should use standard block layout rules for uniform blocks.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetUniformBufferStandardLayout", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetUniformBufferStandardLayout(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 613 Column: 25
    ///<summary>
    /// Records the maximum Universal Limit that is considered valid in the given Validator options object. <options> argument must be a valid options object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetUniversalLimit", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetUniversalLimit(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, spv_validator_limit limit_type, uint limit);

    // File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 692 Column: 25
    ///<summary>
    /// Records whether the validator should use "scalar" block layout rules (as defined above) for Workgroup blocks. See Vulkan extension VK_KHR_workgroup_memory_explicit_layout.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "spvValidatorOptionsSetWorkgroupScalarBlockLayout", ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
    internal static extern void spvValidatorOptionsSetWorkgroupScalarBlockLayout(AdamantiumVulkan.SpirvTools.Interop.spv_validator_options_t options, bool val);

}



