using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Shaders
{
    public class ShaderCompiler : VulkanDisposableObject
    {
        private ShadercCompilerT compiler;

        private ShaderCompiler(ShadercCompilerT compiler)
        {
            this.compiler = compiler;
        }

        private CompilationResult GetCompilationResult(ShadercCompilationResultT result, string name, string entryPoint, ShadercShaderKind shaderKind, bool isTextOutput)
        {
            var status = result.GetCompilationStatus();
            var bytecode = new byte[result.GetLength()];
            MarshalUtils.IntPtrToManagedArray(result.GetBytes(), bytecode);
            var messages = result.GetErrorMessage();
            return new CompilationResult(name, entryPoint, bytecode, shaderKind, status, messages, result.GetNumErrors(), result.GetNumWarnings(), isTextOutput);
        }

        ///<summary>
        /// Takes an assembly string of the format defined in the SPIRV-Tools project (https://github.com/KhronosGroup/SPIRV-Tools/blob/master/syntax.md), assembles it into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The assembling will pick options suitable for assembling specified in the additional_options parameter. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
        ///</summary>
        public CompilationResult AssembleIntoSpirv(string sourceAssembly, CompileOptions options = null)
        {
            var result = compiler.AssembleIntoSpv(sourceAssembly, (ulong)sourceAssembly.Length, options);
            return GetCompilationResult(result, string.Empty, string.Empty, ShadercShaderKind.SpirvAssembly, false);
        }

        ///<summary>
        /// Like shaderc_compile_into_spv, but the result contains preprocessed source code instead of a SPIR-V binary module
        ///</summary>
        public CompilationResult CompileIntoPreprocessedText(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPoint, CompileOptions options = null)
        {
            var result = compiler.CompileIntoPreprocessedText(sourceText, (ulong)sourceText.Length, shaderKind, inputFileName, entryPoint, options);
            return GetCompilationResult(result, inputFileName, entryPoint, shaderKind, true);
        }

        ///<summary>
        /// Takes a GLSL or HLSL source string and the associated shader kind, input file name, compiles it according to the given additional_options. If the shader kind is not set to a specified kind, but shaderc_glslc_infer_from_source, the compiler will try to deduce the shader kind from the source string and a failure in deducing will generate an error. Currently only #pragma annotation is supported. If the shader kind is set to one of the default shader kinds, the compiler will fall back to the default shader kind in case it failed to deduce the shader kind from source string. The input_file_name is a null-termintated string. It is used as a tag to identify the source string in cases like emitting error messages. It doesn't have to be a 'file name'. The source string will be compiled into SPIR-V binary and a shaderc_compilation_result will be returned to hold the results. The entry_point_name null-terminated string defines the name of the entry point to associate with this GLSL source. If the additional_options parameter is not null, then the compilation is modified by any options present. May be safely called from multiple threads without explicit synchronization. If there was failure in allocating the compiler object, null will be returned.
        ///</summary>
        public CompilationResult CompileIntoSpirv(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPoint, CompileOptions options = null)
        {
            var result = compiler.CompileIntoSpv(sourceText, (ulong)sourceText.Length, shaderKind, inputFileName, entryPoint, options);
            return GetCompilationResult(result, inputFileName, entryPoint, shaderKind, false);
        }

        ///<summary>
        /// Like CompileIntoSpirv, but the result contains SPIR-V assembly text instead of a SPIR-V binary module. The SPIR-V assembly syntax is as defined by the SPIRV-Tools open source project.
        ///</summary>
        public CompilationResult CompileIntoSpirvAssembly(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPoint, CompileOptions options = null)
        {
            var result = compiler.CompileIntoSpvAssembly(sourceText, (ulong)sourceText.Length, shaderKind, inputFileName, entryPoint, options);
            return GetCompilationResult(result, inputFileName, entryPoint, shaderKind, true);
        }

        public static ShaderCompiler New()
        {
            var compiler = ShadercCompilerT.CompilerInitialize();
            return new ShaderCompiler(compiler);
        }

        protected override void UnmanagedDisposeOverride()
        {
            compiler?.CompilerRelease();
            compiler = null;
        }
    }
}
