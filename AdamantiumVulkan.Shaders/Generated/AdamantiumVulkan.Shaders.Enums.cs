// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Shaders
{
    using System;
    using System.Runtime.InteropServices;

    public enum ShadercTargetEnv : int
    {
        ///<summary>
        /// SPIR-V under Vulkan semantics
        ///</summary>
        Vulkan = 0,

        ///<summary>
        /// SPIR-V under OpenGL semantics
        ///</summary>
        Opengl = 1,

        ///<summary>
        /// SPIR-V under OpenGL semantics, including compatibility profile functions
        ///</summary>
        OpenglCompat = 2,

        ///<summary>
        /// SPIR-V under WebGPU semantics
        ///</summary>
        Webgpu = 3,

    }

    public enum ShadercEnvVersion : int
    {
        ///<summary>
        /// For Vulkan, use Vulkan's mapping of version numbers to integers. See vulkan.h
        ///</summary>
        Vulkan10 = 4194304,

        ///<summary>
        /// For Vulkan, use Vulkan's mapping of version numbers to integers. See vulkan.h
        ///</summary>
        Vulkan11 = 4198400,

        ///<summary>
        /// For OpenGL, use the number from #version in shaders. TODO(dneto): Currently no difference between OpenGL 4.5 and 4.6. See glslang/Standalone/Standalone.cpp TODO(dneto): Glslang doesn't accept a OpenGL client version of 460.
        ///</summary>
        Opengl45 = 450,

        ///<summary>
        /// Currently WebGPU doesn't have versioning, since it isn't finalized. This will have to be updated once the spec is finished.
        ///</summary>
        Webgpu = 451,

    }

    ///<summary>
    /// The known versions of SPIR-V.
    ///</summary>
    public enum ShadercSpirvVersion : int
    {
        ///<summary>
        /// Use the values used for word 1 of a SPIR-V binary: - bits 24 to 31: zero - bits 16 to 23: major version number - bits 8 to 15: minor version number - bits 0 to 7: zero
        ///</summary>
        _0 = 65536,

        ///<summary>
        /// Use the values used for word 1 of a SPIR-V binary: - bits 24 to 31: zero - bits 16 to 23: major version number - bits 8 to 15: minor version number - bits 0 to 7: zero
        ///</summary>
        _1 = 65792,

        ///<summary>
        /// Use the values used for word 1 of a SPIR-V binary: - bits 24 to 31: zero - bits 16 to 23: major version number - bits 8 to 15: minor version number - bits 0 to 7: zero
        ///</summary>
        _2 = 66048,

        ///<summary>
        /// Use the values used for word 1 of a SPIR-V binary: - bits 24 to 31: zero - bits 16 to 23: major version number - bits 8 to 15: minor version number - bits 0 to 7: zero
        ///</summary>
        _3 = 66304,

        ///<summary>
        /// Use the values used for word 1 of a SPIR-V binary: - bits 24 to 31: zero - bits 16 to 23: major version number - bits 8 to 15: minor version number - bits 0 to 7: zero
        ///</summary>
        _4 = 66560,

    }

    ///<summary>
    /// Indicate the status of a compilation.
    ///</summary>
    public enum ShadercCompilationStatus : int
    {
        Success = 0,

        ///<summary>
        /// error stage deduction
        ///</summary>
        InvalidStage = 1,

        CompilationError = 2,

        ///<summary>
        /// unexpected failure
        ///</summary>
        InternalError = 3,

        NullResultObject = 4,

        InvalidAssembly = 5,

        ValidationError = 6,

        TransformationError = 7,

        ConfigurationError = 8,

    }

    ///<summary>
    /// Source language kind.
    ///</summary>
    [Flags]
    public enum ShadercSourceLanguage : int
    {
        Glsl = 0,

        Hlsl = 1,

    }

    public enum ShadercShaderKind : int
    {
        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        VertexShader = 0,

        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        FragmentShader = 1,

        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        ComputeShader = 2,

        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        GeometryShader = 3,

        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        TessControlShader = 4,

        ///<summary>
        /// Forced shader kinds. These shader kinds force the compiler to compile the source code as the specified kind of shader.
        ///</summary>
        TessEvaluationShader = 5,

        ///<summary>
        /// Deduce the shader kind from #pragma annotation in the source code. Compiler will emit error if #pragma annotation is not found.
        ///</summary>
        GlslInferFromSource = 6,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultVertexShader = 7,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultFragmentShader = 8,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultComputeShader = 9,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultGeometryShader = 10,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultTessControlShader = 11,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        GlslDefaultTessEvaluationShader = 12,

        ///<summary>
        /// Default shader kinds. Compiler will fall back to compile the source code as the specified kind of shader when #pragma annotation is not found in the source code.
        ///</summary>
        SpirvAssembly = 13,

    }

    public enum ShadercProfile : int
    {
        ///<summary>
        /// Used if and only if GLSL version did not specify profiles.
        ///</summary>
        None = 0,

        Core = 1,

        Compatibility = 2,

        Es = 3,

    }

    ///<summary>
    /// Optimization level.
    ///</summary>
    [Flags]
    public enum ShadercOptimizationLevel : int
    {
        ///<summary>
        /// no optimization
        ///</summary>
        Zero = 0,

        ///<summary>
        /// optimize towards reducing code size
        ///</summary>
        Size = 1,

        ///<summary>
        /// optimize towards performance
        ///</summary>
        Performance = 2,

    }

    ///<summary>
    /// Resource limits.
    ///</summary>
    public enum ShadercLimit : int
    {
        AxLights = 0,

        AxClipPlanes = 1,

        AxTextureUnits = 2,

        AxTextureCoords = 3,

        AxVertexAttribs = 4,

        AxVertexUniformComponents = 5,

        AxVaryingFloats = 6,

        AxVertexTextureImageUnits = 7,

        AxCombinedTextureImageUnits = 8,

        AxTextureImageUnits = 9,

        AxFragmentUniformComponents = 10,

        AxDrawBuffers = 11,

        AxVertexUniformVectors = 12,

        AxVaryingVectors = 13,

        AxFragmentUniformVectors = 14,

        AxVertexOutputVectors = 15,

        AxFragmentInputVectors = 16,

        InProgramTexelOffset = 17,

        AxProgramTexelOffset = 18,

        AxClipDistances = 19,

        AxComputeWorkGroupCountX = 20,

        AxComputeWorkGroupCountY = 21,

        AxComputeWorkGroupCountZ = 22,

        AxComputeWorkGroupSizeX = 23,

        AxComputeWorkGroupSizeY = 24,

        AxComputeWorkGroupSizeZ = 25,

        AxComputeUniformComponents = 26,

        AxComputeTextureImageUnits = 27,

        AxComputeImageUniforms = 28,

        AxComputeAtomicCounters = 29,

        AxComputeAtomicCounterBuffers = 30,

        AxVaryingComponents = 31,

        AxVertexOutputComponents = 32,

        AxGeometryInputComponents = 33,

        AxGeometryOutputComponents = 34,

        AxFragmentInputComponents = 35,

        AxImageUnits = 36,

        AxCombinedImageUnitsAndFragmentOutputs = 37,

        AxCombinedShaderOutputResources = 38,

        AxImageSamples = 39,

        AxVertexImageUniforms = 40,

        AxTessControlImageUniforms = 41,

        AxTessEvaluationImageUniforms = 42,

        AxGeometryImageUniforms = 43,

        AxFragmentImageUniforms = 44,

        AxCombinedImageUniforms = 45,

        AxGeometryTextureImageUnits = 46,

        AxGeometryOutputVertices = 47,

        AxGeometryTotalOutputComponents = 48,

        AxGeometryUniformComponents = 49,

        AxGeometryVaryingComponents = 50,

        AxTessControlInputComponents = 51,

        AxTessControlOutputComponents = 52,

        AxTessControlTextureImageUnits = 53,

        AxTessControlUniformComponents = 54,

        AxTessControlTotalOutputComponents = 55,

        AxTessEvaluationInputComponents = 56,

        AxTessEvaluationOutputComponents = 57,

        AxTessEvaluationTextureImageUnits = 58,

        AxTessEvaluationUniformComponents = 59,

        AxTessPatchComponents = 60,

        AxPatchVertices = 61,

        AxTessGenLevel = 62,

        AxViewports = 63,

        AxVertexAtomicCounters = 64,

        AxTessControlAtomicCounters = 65,

        AxTessEvaluationAtomicCounters = 66,

        AxGeometryAtomicCounters = 67,

        AxFragmentAtomicCounters = 68,

        AxCombinedAtomicCounters = 69,

        AxAtomicCounterBindings = 70,

        AxVertexAtomicCounterBuffers = 71,

        AxTessControlAtomicCounterBuffers = 72,

        AxTessEvaluationAtomicCounterBuffers = 73,

        AxGeometryAtomicCounterBuffers = 74,

        AxFragmentAtomicCounterBuffers = 75,

        AxCombinedAtomicCounterBuffers = 76,

        AxAtomicCounterBufferSize = 77,

        AxTransformFeedbackBuffers = 78,

        AxTransformFeedbackInterleavedComponents = 79,

        AxCullDistances = 80,

        AxCombinedClipAndCullDistances = 81,

        AxSamples = 82,

    }

    ///<summary>
    /// Uniform resource kinds. In Vulkan, uniform resources are bound to the pipeline via descriptors with numbered bindings and sets.
    ///</summary>
    public enum ShadercUniformKind : int
    {
        ///<summary>
        /// Image and image buffer.
        ///</summary>
        Image = 0,

        ///<summary>
        /// Pure sampler.
        ///</summary>
        Sampler = 1,

        ///<summary>
        /// Sampled texture in GLSL, and Shader Resource View in HLSL.
        ///</summary>
        Texture = 2,

        ///<summary>
        /// Uniform Buffer Object (UBO) in GLSL. Cbuffer in HLSL.
        ///</summary>
        Buffer = 3,

        ///<summary>
        /// Shader Storage Buffer Object (SSBO) in GLSL.
        ///</summary>
        StorageBuffer = 4,

        ///<summary>
        /// Unordered Access View, in HLSL. (Writable storage image or storage buffer.)
        ///</summary>
        UnorderedAccessView = 5,

    }

    ///<summary>
    /// The kinds of include requests.
    ///</summary>
    [Flags]
    public enum ShadercIncludeType : int
    {
        ///<summary>
        /// E.g. #include "source"
        ///</summary>
        Relative = 0,

        ///<summary>
        /// E.g. #include <source>
        ///</summary>
        Standard = 1,

    }


}

