using AdamantiumVulkan.Shaders.Interop;
using System;
using AdamantiumVulkan.Common;

namespace AdamantiumVulkan.Shaders
{
    public class CompileOptions : QBDisposableObject
    {
        private ShadercCompileOptionsT compileOptions;
        private bool setAutoBindUniforms;
        private bool setAutoMapLocations;
        private bool enableHlslFunctionality;
        private bool useHlslIoMapping;
        private bool useHlslOffsets;
        private bool invertY;
        private bool nanClamp;
        private ShadercOptimizationLevel optimizationLevel;
        private ShadercSourceLanguage sourceLanguage;
        private ShadercSpirvVersion targetSpirv;

        internal CompileOptions(ShadercCompileOptionsT compileOptions)
        {
            this.compileOptions = compileOptions;
        }

        private CompileOptions(CompileOptions other)
        {
            setAutoBindUniforms = other.setAutoBindUniforms;
            setAutoMapLocations = other.setAutoMapLocations;
            enableHlslFunctionality = other.enableHlslFunctionality;
            useHlslIoMapping = other.useHlslIoMapping;
            useHlslOffsets = other.useHlslOffsets;
            invertY = other.invertY;
            nanClamp = other.nanClamp;
            optimizationLevel = other.optimizationLevel;
            sourceLanguage = other.SourceLanguage;
            targetSpirv = other.targetSpirv;
        }

        public static CompileOptions New()
        {
            return new CompileOptions(ShadercCompileOptionsT.Initialize());
        }

        ///<summary>
        /// Adds a predefined macro to the compilation options. This has the same effect as passing -Dname=value to the command-line compiler. If value is NULL, it has the same effect as passing -Dname to the command-line compiler. If a macro definition with the same name has previously been added, the value is replaced with the new value. The macro name and value are passed in with char pointers, which point to their data, and the lengths of their data. The strings that the name and value pointers point to must remain valid for the duration of the call, but can be modified or deleted after this function has returned. In case of adding a valueless macro, the value argument should be a null pointer or the value_length should be 0u.
        ///</summary>
        public void AddMacroDefinition(string name, string value)
        {
            compileOptions.AddMacroDefinition(name, (ulong)name.Length, value, (ulong)value.Length);
        }

        ///<summary>
        /// Returns a copy of the given shaderc_compile_options_t. If NULL is passed as the parameter the call is the same as shaderc_compile_options_init.
        ///</summary>
        public CompileOptions Clone()
        {
            var opts = new CompileOptions(this);
            opts.compileOptions = compileOptions.Clone();
            return opts;
        }

        ///<summary>
        /// Releases the compilation options. It is invalid to use the given shaderc_compile_options_t object in any future calls. It is safe to pass NULL to this function, and doing such will have no effect.
        ///</summary>
        protected override void UnmanagedDisposeOverride()
        {
            compileOptions?.Release();
            compileOptions = null;
        }

        ///<summary>
        /// Sets whether the compiler should automatically assign bindings to uniforms that aren't already explicitly bound in the shader source.
        ///</summary>
        public bool SetAutoBindUniforms
        {
            get => setAutoBindUniforms;
            set
            {
                setAutoBindUniforms = value;
                compileOptions.SetAutoBindUniforms(value);
            }
        }

        ///<summary>
        /// Sets whether the compiler should automatically assign locations to uniform variables that don't have explicit locations in the shader source.
        ///</summary>
        public bool SetAutoMapLocations
        {
            get => setAutoMapLocations;
            set
            {
                setAutoMapLocations = value;
                compileOptions.SetAutoMapLocations(value);
            }
        }

        ///<summary>
        /// Sets the base binding number used for for a uniform resource type when automatically assigning bindings. For GLSL compilation, sets the lowest automatically assigned number. For HLSL compilation, the regsiter number assigned to the resource is added to this specified base.
        ///</summary>
        public void SetBindingBase(ShadercUniformKind kind, uint @base)
        {
            compileOptions.SetBindingBase(kind, @base);
        }

        ///<summary>
        /// Like shaderc_compile_options_set_binding_base, but only takes effect when compiling a given shader stage. The stage is assumed to be one of vertex, fragment, tessellation evaluation, tesselation control, geometry, or compute.
        ///</summary>
        public void SetBindingBaseForStage(ShadercShaderKind shaderKind, ShadercUniformKind kind, uint @base)
        {
            compileOptions.SetBindingBaseForStage(shaderKind, kind, @base);
        }

        ///<summary>
        /// Forces the GLSL language version and profile to a given pair. The version number is the same as would appear in the #version annotation in the source. Version and profile specified here overrides the #version annotation in the source. Use profile: 'shaderc_profile_none' for GLSL versions that do not define profiles, e.g. versions below 150.
        ///</summary>
        public void SetForcedVersionProfile(int version, ShadercProfile profile)
        {
            compileOptions.SetForcedVersionProfile(version, profile);
        }

        ///<summary>
        /// Sets the compiler mode to generate debug information in the output.
        ///</summary>
        public void SetGenerateDebugInfo()
        {
            compileOptions.SetGenerateDebugInfo();
        }

        ///<summary>
        /// Sets whether the compiler should enable extension SPV_GOOGLE_hlsl_functionality1.
        ///</summary>
        public bool EnableHlslFunctionality
        {
            get => enableHlslFunctionality;
            set
            {
                enableHlslFunctionality = value;
                compileOptions.SetHlslFunctionality1(value);
            }
        }

        ///<summary>
        /// Sets whether the compiler should use HLSL IO mapping rules for bindings. Defaults to false.
        ///</summary>
        public bool UseHlslIoMapping
        {
            get => useHlslIoMapping;
            set
            {
                useHlslIoMapping = value;
                compileOptions.SetHlslIoMapping(value);
            }
        }

        ///<summary>
        /// Sets whether the compiler should determine block member offsets using HLSL packing rules instead of standard GLSL rules. Defaults to false. Only affects GLSL compilation. HLSL rules are always used when compiling HLSL.
        ///</summary>
        public bool UseHlslOffsets
        {
            get => useHlslOffsets;
            set
            {
                useHlslOffsets = value;
                compileOptions.SetHlslOffsets(value);
            }
        }

        ///<summary>
        /// Like SetHlslRegisterSetAndBindingForStage, but affects all shader stages.
        ///</summary>
        public void SetHlslRegisterSetAndBinding(string reg, string set, string binding)
        {
            compileOptions.SetHlslRegisterSetAndBinding(reg, set, binding);
        }

        ///<summary>
        /// Sets a descriptor set and binding for an HLSL register in the given stage. 
        /// This method keeps a copy of the string data.
        ///</summary>
        public void SetHlslRegisterSetAndBindingForStage(ShadercShaderKind shaderKind, string reg, string set, string binding)
        {
            compileOptions.SetHlslRegisterSetAndBindingForStage(shaderKind, reg, set, binding);
        }

        ///<summary>
        /// Sets includer callback functions.
        ///</summary>
        public void SetIncludeCallbacks(IntPtr resolver, IntPtr resultReleaser, ref IntPtr userData)
        {
            compileOptions.SetIncludeCallbacks(resolver, resultReleaser, ref userData);
        }

        ///<summary>
        /// Sets whether the compiler should invert position.Y output in vertex shader.
        ///</summary>
        public bool InvertY
        {
            get => invertY;
            set
            {
                invertY = value;
                compileOptions.SetInvertY(value);
            }
        }

        ///<summary>
        /// Sets a resource limit.
        ///</summary>
        public void SetLimit(ShadercLimit limit, int value)
        {
            compileOptions.SetLimit(limit, value);
        }

        ///<summary>
        /// Sets whether the compiler generates code for max and min builtins which, if given a NaN operand, will return the other operand. Similarly, the clamp builtin will favour the non-NaN operands, as if clamp were implemented as a composition of max and min.
        ///</summary>
        public bool NanClamp
        {
            get => nanClamp;
            set
            {
                nanClamp = value;
                compileOptions.SetNanClamp(value);
            }
        }

        ///<summary>
        /// Sets the compiler optimization level to the given level. Only the last one takes effect if multiple calls of this function exist.
        ///</summary>
        public ShadercOptimizationLevel OptimizationLevel
        {
            get => optimizationLevel;
            set
            {
                optimizationLevel = value;
                compileOptions.SetOptimizationLevel(value);
            }
        }

        ///<summary>
        /// Sets the source language. The default is GLSL.
        ///</summary>
        public ShadercSourceLanguage SourceLanguage
        {
            get => sourceLanguage;
            set
            {
                sourceLanguage = value;
                compileOptions.SetSourceLanguage(value);
            }
        }

        ///<summary>
        /// Sets the compiler mode to suppress warnings, overriding warnings-as-errors mode. When both suppress-warnings and warnings-as-errors modes are turned on, warning messages will be inhibited, and will not be emitted as error messages.
        ///</summary>
        public void SetSuppressWarnings()
        {
            compileOptions.SetSuppressWarnings();
        }

        ///<summary>
        /// Sets the target shader environment, affecting which warnings or errors will be issued. The version will be for distinguishing between different versions of the target environment. The version value should be either 0 or a value listed in shaderc_env_version. The 0 value maps to Vulkan 1.0 if |target| is Vulkan, and it maps to OpenGL 4.5 if |target| is OpenGL.
        ///</summary>
        public void SetTargetEnv(ShadercTargetEnv target, uint version)
        {
            compileOptions.SetTargetEnv(target, version);
        }

        ///<summary>
        /// Sets the target SPIR-V version. The generated module will use this version of SPIR-V. Each target environment determines what versions of SPIR-V it can consume. Defaults to the highest version of SPIR-V 1.0 which is required to be supported by the target environment. E.g. Default to SPIR-V 1.0 for Vulkan 1.0 and SPIR-V 1.3 for Vulkan 1.1.
        ///</summary>
        public ShadercSpirvVersion TargetSpirv
        {
            get => targetSpirv;
            set
            {
                targetSpirv = value;
                compileOptions.SetTargetSpirv(value);
            }
        }

        ///<summary>
        /// Sets the compiler mode to treat all warnings as errors. Note the suppress-warnings mode overrides this option, i.e. if both warning-as-errors and suppress-warnings modes are set, warnings will not be emitted as error messages.
        ///</summary>
        public void SetWarningsAsErrors()
        {
            compileOptions.SetWarningsAsErrors();
        }

        public static implicit operator ShadercCompileOptionsT (CompileOptions options)
        {
            return options?.compileOptions;
        }
    }
}
