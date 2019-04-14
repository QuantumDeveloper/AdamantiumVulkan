// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Shaders.Interop
{
    using System.Security;
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Shaders;

    public static class VulkanShadersInterop
    {
        private const string libraryPath = "vulkan-1";

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 251 Column: 35
        ///<summary>
        /// Returns a shaderc_compiler_t that can be used to compile modules. A return of NULL indicates that there was an error initializing the compiler. Any function operating on shaderc_compiler_t must offer the basic thread-safety guarantee. [http://herbsutter.com/2014/01/13/gotw-95-solution-thread-safety-and-synchronization/] That is: concurrent invocation of these functions on DIFFERENT objects needs no synchronization; concurrent invocation of these functions on the SAME object requires synchronization IF AND ONLY IF some of them take a non-const argument.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compiler_initialize", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilerT shaderc_compiler_initialize();

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 256 Column: 21
        ///<summary>
        /// Releases the resources held by the shaderc_compiler_t. After this call it is invalid to make any future calls to functions involving this shaderc_compiler_t.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compiler_release", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compiler_release([In] ShadercCompiler param0);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 268 Column: 5
        ///<summary>
        /// Returns a default-initialized shaderc_compile_options_t that can be used to modify the functionality of a compiled module. A return of NULL indicates that there was an error initializing the options. Any function operating on shaderc_compile_options_t must offer the basic thread-safety guarantee.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_initialize", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompileOptionsT shaderc_compile_options_initialize();

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 273 Column: 42
        ///<summary>
        /// Returns a copy of the given shaderc_compile_options_t. If NULL is passed as the parameter the call is the same as shaderc_compile_options_init.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_clone", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompileOptionsT shaderc_compile_options_clone([In] ShadercCompileOptions options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 279 Column: 21
        ///<summary>
        /// Releases the compilation options. It is invalid to use the given shaderc_compile_options_t object in any future calls. It is safe to pass NULL to this function, and doing such will have no effect.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_release", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_release([In] ShadercCompileOptions options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 293 Column: 21
        ///<summary>
        /// Adds a predefined macro to the compilation options. This has the same effect as passing -Dname=value to the command-line compiler. If value is NULL, it has the same effect as passing -Dname to the command-line compiler. If a macro definition with the same name has previously been added, the value is replaced with the new value. The macro name and value are passed in with char pointers, which point to their data, and the lengths of their data. The strings that the name and value pointers point to must remain valid for the duration of the call, but can be modified or deleted after this function has returned. In case of adding a valueless macro, the value argument should be a null pointer or the value_length should be 0u.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_add_macro_definition", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_add_macro_definition([In] ShadercCompileOptions options, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string name, [In] ulong name_length, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string value, [In] ulong value_length);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 298 Column: 21
        ///<summary>
        /// Sets the source language. The default is GLSL.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_source_language", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_source_language([In] ShadercCompileOptions options, [In] ShadercSourceLanguage lang);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 302 Column: 21
        ///<summary>
        /// Sets the compiler mode to generate debug information in the output.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_generate_debug_info", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_generate_debug_info([In] ShadercCompileOptions options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 307 Column: 21
        ///<summary>
        /// Sets the compiler optimization level to the given level. Only the last one takes effect if multiple calls of this function exist.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_optimization_level", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_optimization_level([In] ShadercCompileOptions options, [In] ShadercOptimizationLevel level);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 315 Column: 21
        ///<summary>
        /// Forces the GLSL language version and profile to a given pair. The version number is the same as would appear in the #version annotation in the source. Version and profile specified here overrides the #version annotation in the source. Use profile: 'shaderc_profile_none' for GLSL versions that do not define profiles, e.g. versions below 150.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_forced_version_profile", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_forced_version_profile([In] ShadercCompileOptions options, [In] int version, [In] ShadercProfile profile);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 367 Column: 21
        ///<summary>
        /// Sets includer callback functions.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_include_callbacks", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_include_callbacks([In] ShadercCompileOptions options, [In] ShadercIncludeResolveFn resolver, [In] ShadercIncludeResultReleaseFn result_releaser, ref System.IntPtr user_data);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 375 Column: 21
        ///<summary>
        /// Sets the compiler mode to suppress warnings, overriding warnings-as-errors mode. When both suppress-warnings and warnings-as-errors modes are turned on, warning messages will be inhibited, and will not be emitted as error messages.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_suppress_warnings", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_suppress_warnings([In] ShadercCompileOptions options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 383 Column: 21
        ///<summary>
        /// Sets the target shader environment, affecting which warnings or errors will be issued. The version will be for distinguishing between different versions of the target environment. The version value should be either 0 or a value listed in shaderc_env_version. The 0 value maps to Vulkan 1.0 if |target| is Vulkan, and it maps to OpenGL 4.5 if |target| is OpenGL.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_target_env", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_target_env([In] ShadercCompileOptions options, [In] ShadercTargetEnv target, [In] uint version);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 392 Column: 21
        ///<summary>
        /// Sets the compiler mode to treat all warnings as errors. Note the suppress-warnings mode overrides this option, i.e. if both warning-as-errors and suppress-warnings modes are set, warnings will not be emitted as error messages.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_warnings_as_errors", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_warnings_as_errors([In] ShadercCompileOptions options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 396 Column: 21
        ///<summary>
        /// Sets a resource limit.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_limit", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_limit([In] ShadercCompileOptions options, [In] ShadercLimit limit, [In] int value);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 401 Column: 21
        ///<summary>
        /// Sets whether the compiler should automatically assign bindings to uniforms that aren't already explicitly bound in the shader source.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_auto_bind_uniforms", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_auto_bind_uniforms([In] ShadercCompileOptions options, [In] byte auto_bind);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 406 Column: 21
        ///<summary>
        /// Sets whether the compiler should use HLSL IO mapping rules for bindings. Defaults to false.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_io_mapping", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_hlsl_io_mapping([In] ShadercCompileOptions options, [In] byte hlsl_iomap);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 412 Column: 21
        ///<summary>
        /// Sets whether the compiler should determine block member offsets using HLSL packing rules instead of standard GLSL rules. Defaults to false. Only affects GLSL compilation. HLSL rules are always used when compiling HLSL.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_offsets", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_hlsl_offsets([In] ShadercCompileOptions options, [In] byte hlsl_offsets);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 419 Column: 21
        ///<summary>
        /// Sets the base binding number used for for a uniform resource type when automatically assigning bindings. For GLSL compilation, sets the lowest automatically assigned number. For HLSL compilation, the regsiter number assigned to the resource is added to this specified base.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_binding_base", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_binding_base([In] ShadercCompileOptions options, [In] ShadercUniformKind kind, [In] uint @base);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 427 Column: 21
        ///<summary>
        /// Like shaderc_compile_options_set_binding_base, but only takes effect when compiling a given shader stage. The stage is assumed to be one of vertex, fragment, tessellation evaluation, tesselation control, geometry, or compute.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_binding_base_for_stage", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_binding_base_for_stage([In] ShadercCompileOptions options, [In] ShadercShaderKind shader_kind, [In] ShadercUniformKind kind, [In] uint @base);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 433 Column: 21
        ///<summary>
        /// Sets whether the compiler should automatically assign locations to uniform variables that don't have explicit locations in the shader source.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_auto_map_locations", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_auto_map_locations([In] ShadercCompileOptions options, [In] byte auto_map);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 438 Column: 21
        ///<summary>
        /// Sets a descriptor set and binding for an HLSL register in the given stage. This method keeps a copy of the string data.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage([In] ShadercCompileOptions options, [In] ShadercShaderKind shader_kind, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string reg, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string set, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string binding);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 444 Column: 21
        ///<summary>
        /// Like shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage, but affects all shader stages.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_register_set_and_binding", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_hlsl_register_set_and_binding([In] ShadercCompileOptions options, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string reg, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string set, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string binding);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 450 Column: 21
        ///<summary>
        /// Sets whether the compiler should enable extension SPV_GOOGLE_hlsl_functionality1.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_options_set_hlsl_functionality1", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_compile_options_set_hlsl_functionality1([In] ShadercCompileOptions options, [In] byte enable);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 476 Column: 45
        ///<summary>
        /// Takes a GLSL source string and the associated shader kind, input file name, compiles it according to the given additional_options. If the shader kind is not set to a specified kind, but shaderc_glslc_infer_from_source, the compiler will try to deduce the shader kind from the source string and a failure in deducing will generate an error. Currently only #pragma annotation is supported. If the shader kind is set to one of the default shader kinds, the compiler will fall back to the default shader kind in case it failed to deduce the shader kind from source string. The input_file_name is a null-termintated string. It is used as a tag to identify the source string in cases like emitting error messages. It doesn't have to be a 'file name'. The source string will be compiled into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The entry_point_name null-terminated string defines the name of the entry point to associate with this GLSL source. If the additional_options parameter is not null, then the compilation is modified by any options present. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_into_spv", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilationResultT shaderc_compile_into_spv([In] ShadercCompiler compiler, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string source_text, [In] ulong source_text_size, [In] ShadercShaderKind shader_kind, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string input_file_name, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string entry_point_name, [In] ShadercCompileOptions additional_options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 485 Column: 45
        ///<summary>
        /// Like shaderc_compile_into_spv, but the result contains SPIR-V assembly text instead of a SPIR-V binary module. The SPIR-V assembly syntax is as defined by the SPIRV-Tools open source project.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_into_spv_assembly", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilationResultT shaderc_compile_into_spv_assembly([In] ShadercCompiler compiler, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string source_text, [In] ulong source_text_size, [In] ShadercShaderKind shader_kind, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string input_file_name, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string entry_point_name, [In] ShadercCompileOptions additional_options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 493 Column: 45
        ///<summary>
        /// Like shaderc_compile_into_spv, but the result contains preprocessed source code instead of a SPIR-V binary module
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_compile_into_preprocessed_text", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilationResultT shaderc_compile_into_preprocessed_text([In] ShadercCompiler compiler, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string source_text, [In] ulong source_text_size, [In] ShadercShaderKind shader_kind, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string input_file_name, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string entry_point_name, [In] ShadercCompileOptions additional_options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 508 Column: 45
        ///<summary>
        /// Takes an assembly string of the format defined in the SPIRV-Tools project (https://github.com/KhronosGroup/SPIRV-Tools/blob/master/syntax.md), assembles it into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The assembling will pick options suitable for assembling specified in the additional_options parameter. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_assemble_into_spv", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilationResultT shaderc_assemble_into_spv([In] ShadercCompiler compiler, [In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string source_assembly, [In] ulong source_assembly_size, [In] ShadercCompileOptions additional_options);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 518 Column: 21
        ///<summary>
        /// Releases the resources held by the result object. It is invalid to use the result object for any further operations.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_release", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_result_release([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 522 Column: 23
        ///<summary>
        /// Returns the number of bytes of the compilation output data in a result object.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_length", CallingConvention = CallingConvention.StdCall)]
        internal static extern ulong shaderc_result_get_length([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 525 Column: 23
        ///<summary>
        /// Returns the number of warnings generated during the compilation.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_num_warnings", CallingConvention = CallingConvention.StdCall)]
        internal static extern ulong shaderc_result_get_num_warnings([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 529 Column: 23
        ///<summary>
        /// Returns the number of errors generated during the compilation.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_num_errors", CallingConvention = CallingConvention.StdCall)]
        internal static extern ulong shaderc_result_get_num_errors([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 534 Column: 43
        ///<summary>
        /// Returns the compilation status, indicating whether the compilation succeeded, or failed due to some reasons, like invalid shader stage or compilation errors.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_compilation_status", CallingConvention = CallingConvention.StdCall)]
        internal static extern ShadercCompilationStatus shaderc_result_get_compilation_status([In] ShadercCompilationResult param0);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 542 Column: 28
        ///<summary>
        /// Returns a pointer to the start of the compilation output data bytes, either SPIR-V binary or char string. When the source string is compiled into SPIR-V binary, this is guaranteed to be castable to a uint32_t*. If the result contains assembly text or preprocessed source text, the pointer will point to the resulting array of characters.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_bytes", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        internal static extern string shaderc_result_get_bytes([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 546 Column: 28
        ///<summary>
        /// Returns a null-terminated string that contains any error messages generated during the compilation.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_result_get_error_message", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        internal static extern string shaderc_result_get_error_message([In] ShadercCompilationResult result);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 550 Column: 21
        ///<summary>
        /// Provides the version & revision of the SPIR-V which will be produced
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_get_spv_version", CallingConvention = CallingConvention.StdCall)]
        internal static extern void shaderc_get_spv_version(ref uint version, ref uint revision);

        // File: C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h Line: 556 Column: 21
        ///<summary>
        /// Parses the version and profile from a given null-terminated string containing both version and profile, like: '450core'. Returns false if the string can not be parsed. Returns true when the parsing succeeds. The parsed version and profile are returned through arguments.
        ///</summary>
        [DllImport(libraryPath, EntryPoint = "shaderc_parse_version_profile", CallingConvention = CallingConvention.StdCall)]
        internal static extern byte shaderc_parse_version_profile([In] [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))] string str, ref int version, ref ShadercProfile profile);

    }


}

