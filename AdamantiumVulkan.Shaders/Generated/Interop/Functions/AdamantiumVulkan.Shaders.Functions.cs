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
using AdamantiumVulkan.Shaders;

namespace AdamantiumVulkan.Shaders.Interop;

public static unsafe partial class VulkanShadersInterop
{
    public const string LibraryPath = "shaderc_shared";

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 564 Column: 45
    ///<summary>
    /// Takes an assembly string of the format defined in the SPIRV-Tools project (https://github.com/KhronosGroup/SPIRV-Tools/blob/master/syntax.md), assembles it into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The assembling will pick options suitable for assembling specified in the additional_options parameter. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_assemble_into_spv", ExactSpelling = true)]
    internal static extern ShadercCompilationResult shaderc_assemble_into_spv(AdamantiumVulkan.Shaders.Interop.ShadercCompiler compiler, sbyte* source_assembly, ulong source_assembly_size, AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions additional_options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 549 Column: 45
    ///<summary>
    /// Like shaderc_compile_into_spv, but the result contains preprocessed source code instead of a SPIR-V binary module
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_into_preprocessed_text", ExactSpelling = true)]
    internal static extern ShadercCompilationResult shaderc_compile_into_preprocessed_text(AdamantiumVulkan.Shaders.Interop.ShadercCompiler compiler, sbyte* source_text, ulong source_text_size, ShadercShaderKind shader_kind, sbyte* input_file_name, sbyte* entry_point_name, AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions additional_options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 532 Column: 45
    ///<summary>
    /// Takes a GLSL source string and the associated shader kind, input file name, compiles it according to the given additional_options. If the shader kind is not set to a specified kind, but shaderc_glslc_infer_from_source, the compiler will try to deduce the shader kind from the source string and a failure in deducing will generate an error. Currently only #pragma annotation is supported. If the shader kind is set to one of the default shader kinds, the compiler will fall back to the default shader kind in case it failed to deduce the shader kind from source string. The input_file_name is a null-termintated string. It is used as a tag to identify the source string in cases like emitting error messages. It doesn't have to be a 'file name'. The source string will be compiled into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The entry_point_name null-terminated string defines the name of the entry point to associate with this GLSL source. If the additional_options parameter is not null, then the compilation is modified by any options present. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_into_spv", ExactSpelling = true)]
    internal static extern ShadercCompilationResult shaderc_compile_into_spv(AdamantiumVulkan.Shaders.Interop.ShadercCompiler compiler, sbyte* source_text, ulong source_text_size, ShadercShaderKind shader_kind, sbyte* input_file_name, sbyte* entry_point_name, AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions additional_options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 541 Column: 45
    ///<summary>
    /// Like shaderc_compile_into_spv, but the result contains SPIR-V assembly text instead of a SPIR-V binary module. The SPIR-V assembly syntax is as defined by the SPIRV-Tools open source project.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_into_spv_assembly", ExactSpelling = true)]
    internal static extern ShadercCompilationResult shaderc_compile_into_spv_assembly(AdamantiumVulkan.Shaders.Interop.ShadercCompiler compiler, sbyte* source_text, ulong source_text_size, ShadercShaderKind shader_kind, sbyte* input_file_name, sbyte* entry_point_name, AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions additional_options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 310 Column: 21
    ///<summary>
    /// Adds a predefined macro to the compilation options. This has the same effect as passing -Dname=value to the command-line compiler. If value is NULL, it has the same effect as passing -Dname to the command-line compiler. If a macro definition with the same name has previously been added, the value is replaced with the new value. The macro name and value are passed in with char pointers, which point to their data, and the lengths of their data. The strings that the name and value pointers point to must remain valid for the duration of the call, but can be modified or deleted after this function has returned. In case of adding a valueless macro, the value argument should be a null pointer or the value_length should be 0u.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_add_macro_definition", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_add_macro_definition(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, sbyte* name, ulong name_length, sbyte* value, ulong value_length);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 290 Column: 42
    ///<summary>
    /// Returns a copy of the given shaderc_compile_options_t. If NULL is passed as the parameter the call is the same as shaderc_compile_options_init.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_clone", ExactSpelling = true)]
    internal static extern ShadercCompileOptions shaderc_compile_options_clone(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 285 Column: 5
    ///<summary>
    /// Returns a default-initialized shaderc_compile_options_t that can be used to modify the functionality of a compiled module. A return of NULL indicates that there was an error initializing the options. Any function operating on shaderc_compile_options_t must offer the basic thread-safety guarantee.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_initialize", ExactSpelling = true)]
    internal static extern ShadercCompileOptions shaderc_compile_options_initialize();

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 296 Column: 21
    ///<summary>
    /// Releases the compilation options. It is invalid to use the given shaderc_compile_options_t object in any future calls. It is safe to pass NULL to this function, and doing such will have no effect.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_release", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_release(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 426 Column: 21
    ///<summary>
    /// Sets whether the compiler should automatically assign bindings to uniforms that aren't already explicitly bound in the shader source.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_auto_bind_uniforms", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_auto_bind_uniforms(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool auto_bind);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 431 Column: 21
    ///<summary>
    /// Sets whether the compiler should automatically remove sampler variables and convert image variables to combined image-sampler variables.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_auto_combined_image_sampler", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_auto_combined_image_sampler(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool upgrade);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 468 Column: 21
    ///<summary>
    /// Sets whether the compiler should automatically assign locations to uniform variables that don't have explicit locations in the shader source.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_auto_map_locations", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_auto_map_locations(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool auto_map);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 449 Column: 21
    ///<summary>
    /// Sets the base binding number used for for a uniform resource type when automatically assigning bindings. For GLSL compilation, sets the lowest automatically assigned number. For HLSL compilation, the regsiter number assigned to the resource is added to this specified base.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_binding_base", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_binding_base(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercUniformKind kind, uint @base);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 457 Column: 21
    ///<summary>
    /// Like shaderc_compile_options_set_binding_base, but only takes effect when compiling a given shader stage. The stage is assumed to be one of vertex, fragment, tessellation evaluation, tesselation control, geometry, or compute.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_binding_base_for_stage", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_binding_base_for_stage(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercShaderKind shader_kind, ShadercUniformKind kind, uint @base);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 332 Column: 21
    ///<summary>
    /// Forces the GLSL language version and profile to a given pair. The version number is the same as would appear in the #version annotation in the source. Version and profile specified here overrides the #version annotation in the source. Use profile: 'shaderc_profile_none' for GLSL versions that do not define profiles, e.g. versions below 150.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_forced_version_profile", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_forced_version_profile(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, int version, ShadercProfile profile);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 319 Column: 21
    ///<summary>
    /// Sets the compiler mode to generate debug information in the output.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_generate_debug_info", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_generate_debug_info(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 489 Column: 21
    ///<summary>
    /// Sets whether 16-bit types are supported in HLSL or not.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_16bit_types", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_16bit_types(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool enable);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 485 Column: 21
    ///<summary>
    /// Sets whether the compiler should enable extension SPV_GOOGLE_hlsl_functionality1.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_functionality1", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_functionality1(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool enable);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 436 Column: 21
    ///<summary>
    /// Sets whether the compiler should use HLSL IO mapping rules for bindings. Defaults to false.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_io_mapping", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_io_mapping(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool hlsl_iomap);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 442 Column: 21
    ///<summary>
    /// Sets whether the compiler should determine block member offsets using HLSL packing rules instead of standard GLSL rules. Defaults to false. Only affects GLSL compilation. HLSL rules are always used when compiling HLSL.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_offsets", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_offsets(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool hlsl_offsets);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 479 Column: 21
    ///<summary>
    /// Like shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage, but affects all shader stages.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_register_set_and_binding(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, sbyte* reg, sbyte* set, sbyte* binding);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 473 Column: 21
    ///<summary>
    /// Sets a descriptor set and binding for an HLSL register in the given stage. This method keeps a copy of the string data.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercShaderKind shader_kind, sbyte* reg, sbyte* set, sbyte* binding);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 384 Column: 21
    ///<summary>
    /// Sets includer callback functions.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_include_callbacks", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_include_callbacks(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, void* resolver, void* result_releaser, void* user_data);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 499 Column: 21
    ///<summary>
    /// Sets whether the compiler should invert position.Y output in vertex shader.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_invert_y", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_invert_y(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool enable);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 421 Column: 21
    ///<summary>
    /// Sets a resource limit.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_limit", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_limit(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercLimit limit, int value);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 506 Column: 21
    ///<summary>
    /// Sets whether the compiler generates code for max and min builtins which, if given a NaN operand, will return the other operand. Similarly, the clamp builtin will favour the non-NaN operands, as if clamp were implemented as a composition of max and min.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_nan_clamp", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_nan_clamp(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool enable);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 324 Column: 21
    ///<summary>
    /// Sets the compiler optimization level to the given level. Only the last one takes effect if multiple calls of this function exist.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_optimization_level", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_optimization_level(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercOptimizationLevel level);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 463 Column: 21
    ///<summary>
    /// Sets whether the compiler should preserve all bindings, even when those bindings are not used.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_preserve_bindings", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_preserve_bindings(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool preserve_bindings);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 315 Column: 21
    ///<summary>
    /// Sets the source language. The default is GLSL.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_source_language", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_source_language(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercSourceLanguage lang);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 392 Column: 21
    ///<summary>
    /// Sets the compiler mode to suppress warnings, overriding warnings-as-errors mode. When both suppress-warnings and warnings-as-errors modes are turned on, warning messages will be inhibited, and will not be emitted as error messages.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_suppress_warnings", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_suppress_warnings(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 400 Column: 21
    ///<summary>
    /// Sets the target shader environment, affecting which warnings or errors will be issued. The version will be for distinguishing between different versions of the target environment. The version value should be either 0 or a value listed in shaderc_env_version. The 0 value maps to Vulkan 1.0 if |target| is Vulkan, and it maps to OpenGL 4.5 if |target| is OpenGL.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_target_env", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_target_env(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercTargetEnv target, uint version);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 410 Column: 21
    ///<summary>
    /// Sets the target SPIR-V version. The generated module will use this version of SPIR-V. Each target environment determines what versions of SPIR-V it can consume. Defaults to the highest version of SPIR-V 1.0 which is required to be supported by the target environment. E.g. Default to SPIR-V 1.0 for Vulkan 1.0 and SPIR-V 1.3 for Vulkan 1.1.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_target_spirv", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_target_spirv(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, ShadercSpirvVersion version);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 495 Column: 21
    ///<summary>
    /// Enables or disables relaxed Vulkan rules.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_vulkan_rules_relaxed", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_vulkan_rules_relaxed(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options, bool enable);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 417 Column: 21
    ///<summary>
    /// Sets the compiler mode to treat all warnings as errors. Note the suppress-warnings mode overrides this option, i.e. if both warning-as-errors and suppress-warnings modes are set, warnings will not be emitted as error messages.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compile_options_set_warnings_as_errors", ExactSpelling = true)]
    internal static extern void shaderc_compile_options_set_warnings_as_errors(AdamantiumVulkan.Shaders.Interop.ShadercCompileOptions options);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 268 Column: 35
    ///<summary>
    /// Returns a shaderc_compiler_t that can be used to compile modules. A return of NULL indicates that there was an error initializing the compiler. Any function operating on shaderc_compiler_t must offer the basic thread-safety guarantee. [http://herbsutter.com/2014/01/13/gotw-95-solution-thread-safety-and-synchronization/] That is: concurrent invocation of these functions on DIFFERENT objects needs no synchronization; concurrent invocation of these functions on the SAME object requires synchronization IF AND ONLY IF some of them take a non-const argument.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compiler_initialize", ExactSpelling = true)]
    internal static extern ShadercCompiler shaderc_compiler_initialize();

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 273 Column: 21
    ///<summary>
    /// Releases the resources held by the shaderc_compiler_t. After this call it is invalid to make any future calls to functions involving this shaderc_compiler_t.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_compiler_release", ExactSpelling = true)]
    internal static extern void shaderc_compiler_release(AdamantiumVulkan.Shaders.Interop.ShadercCompiler param0);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 606 Column: 21
    ///<summary>
    /// Provides the version & revision of the SPIR-V which will be produced
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_get_spv_version", ExactSpelling = true)]
    internal static extern void shaderc_get_spv_version(uint* version, uint* revision);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 612 Column: 21
    ///<summary>
    /// Parses the version and profile from a given null-terminated string containing both version and profile, like: '450core'. Returns false if the string can not be parsed. Returns true when the parsing succeeds. The parsed version and profile are returned through arguments.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_parse_version_profile", ExactSpelling = true)]
    internal static extern bool shaderc_parse_version_profile(sbyte* str, int* version, ShadercProfile* profile);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 598 Column: 28
    ///<summary>
    /// Returns a pointer to the start of the compilation output data bytes, either SPIR-V binary or char string. When the source string is compiled into SPIR-V binary, this is guaranteed to be castable to a uint32_t*. If the result contains assembly text or preprocessed source text, the pointer will point to the resulting array of characters.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_bytes", ExactSpelling = true)]
    internal static extern System.IntPtr shaderc_result_get_bytes(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 590 Column: 43
    ///<summary>
    /// Returns the compilation status, indicating whether the compilation succeeded, or failed due to some reasons, like invalid shader stage or compilation errors.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_compilation_status", ExactSpelling = true)]
    internal static extern ShadercCompilationStatus shaderc_result_get_compilation_status(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult param0);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 602 Column: 28
    ///<summary>
    /// Returns a null-terminated string that contains any error messages generated during the compilation.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_error_message", ExactSpelling = true)]
    internal static extern sbyte* shaderc_result_get_error_message(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 578 Column: 23
    ///<summary>
    /// Returns the number of bytes of the compilation output data in a result object.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_length", ExactSpelling = true)]
    internal static extern ulong shaderc_result_get_length(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 585 Column: 23
    ///<summary>
    /// Returns the number of errors generated during the compilation.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_num_errors", ExactSpelling = true)]
    internal static extern ulong shaderc_result_get_num_errors(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 581 Column: 23
    ///<summary>
    /// Returns the number of warnings generated during the compilation.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_get_num_warnings", ExactSpelling = true)]
    internal static extern ulong shaderc_result_get_num_warnings(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

    // File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 574 Column: 21
    ///<summary>
    /// Releases the resources held by the result object. It is invalid to use the result object for any further operations.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [DllImport(LibraryPath, EntryPoint = "shaderc_result_release", ExactSpelling = true)]
    internal static extern void shaderc_result_release(AdamantiumVulkan.Shaders.Interop.ShadercCompilationResult result);

}



