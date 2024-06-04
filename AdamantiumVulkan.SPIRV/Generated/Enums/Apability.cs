// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Spirv;

// File: C:\VulkanSDK\1.3.275.0\Include\spirv_cross/spirv.h Line: 892 Column: 14
public enum Apability : uint
{
    Matrix = 0,

    Shader = 1,

    Geometry = 2,

    Tessellation = 3,

    Addresses = 4,

    Linkage = 5,

    Kernel = 6,

    Vector16 = 7,

    Float16Buffer = 8,

    Float16 = 9,

    Float64 = 10,

    Int64 = 11,

    Int64Atomics = 12,

    ImageBasic = 13,

    ImageReadWrite = 14,

    ImageMipmap = 15,

    Pipes = 17,

    Groups = 18,

    DeviceEnqueue = 19,

    LiteralSampler = 20,

    AtomicStorage = 21,

    Int16 = 22,

    TessellationPointSize = 23,

    GeometryPointSize = 24,

    ImageGatherExtended = 25,

    StorageImageMultisample = 27,

    UniformBufferArrayDynamicIndexing = 28,

    SampledImageArrayDynamicIndexing = 29,

    StorageBufferArrayDynamicIndexing = 30,

    StorageImageArrayDynamicIndexing = 31,

    ClipDistance = 32,

    CullDistance = 33,

    ImageCubeArray = 34,

    SampleRateShading = 35,

    ImageRect = 36,

    SampledRect = 37,

    GenericPointer = 38,

    Int8 = 39,

    InputAttachment = 40,

    SparseResidency = 41,

    MinLod = 42,

    Sampled1D = 43,

    Image1D = 44,

    SampledCubeArray = 45,

    SampledBuffer = 46,

    ImageBuffer = 47,

    ImageMSArray = 48,

    StorageImageExtendedFormats = 49,

    ImageQuery = 50,

    DerivativeControl = 51,

    InterpolationFunction = 52,

    TransformFeedback = 53,

    GeometryStreams = 54,

    StorageImageReadWithoutFormat = 55,

    StorageImageWriteWithoutFormat = 56,

    MultiViewport = 57,

    SubgroupDispatch = 58,

    NamedBarrier = 59,

    PipeStorage = 60,

    GroupNonUniform = 61,

    GroupNonUniformVote = 62,

    GroupNonUniformArithmetic = 63,

    GroupNonUniformBallot = 64,

    GroupNonUniformShuffle = 65,

    GroupNonUniformShuffleRelative = 66,

    GroupNonUniformClustered = 67,

    GroupNonUniformQuad = 68,

    ShaderLayer = 69,

    ShaderViewportIndex = 70,

    UniformDecoration = 71,

    FragmentShadingRateKHR = 4422,

    SubgroupBallotKHR = 4423,

    DrawParameters = 4427,

    WorkgroupMemoryExplicitLayoutKHR = 4428,

    WorkgroupMemoryExplicitLayout8BitAccessKHR = 4429,

    WorkgroupMemoryExplicitLayout16BitAccessKHR = 4430,

    SubgroupVoteKHR = 4431,

    StorageBuffer16BitAccess = 4433,

    StorageUniform16 = 4434,

    StoragePushConstant16 = 4435,

    StorageInputOutput16 = 4436,

    DeviceGroup = 4437,

    MultiView = 4439,

    VariablePointersStorageBuffer = 4441,

    VariablePointers = 4442,

    AtomicStorageOps = 4445,

    SampleMaskPostDepthCoverage = 4447,

    StorageBuffer8BitAccess = 4448,

    UniformAndStorageBuffer8BitAccess = 4449,

    StoragePushConstant8 = 4450,

    DenormPreserve = 4464,

    DenormFlushToZero = 4465,

    SignedZeroInfNanPreserve = 4466,

    RoundingModeRTE = 4467,

    RoundingModeRTZ = 4468,

    RayQueryProvisionalKHR = 4471,

    RayQueryKHR = 4472,

    RayTraversalPrimitiveCullingKHR = 4478,

    RayTracingKHR = 4479,

    Float16ImageAMD = 5008,

    ImageGatherBiasLodAMD = 5009,

    FragmentMaskAMD = 5010,

    StencilExportEXT = 5013,

    ImageReadWriteLodAMD = 5015,

    Int64ImageEXT = 5016,

    ShaderClockKHR = 5055,

    SampleMaskOverrideCoverageNV = 5249,

    GeometryShaderPassthroughNV = 5251,

    ShaderViewportIndexLayerEXT = 5254,

    ShaderViewportMaskNV = 5255,

    ShaderStereoViewNV = 5259,

    PerViewAttributesNV = 5260,

    FragmentFullyCoveredEXT = 5265,

    MeshShadingNV = 5266,

    ImageFootprintNV = 5282,

    MeshShadingEXT = 5283,

    FragmentBarycentricKHR = 5284,

    ComputeDerivativeGroupQuadsNV = 5288,

    FragmentDensityEXT = 5291,

    GroupNonUniformPartitionedNV = 5297,

    ShaderNonUniform = 5301,

    RuntimeDescriptorArray = 5302,

    InputAttachmentArrayDynamicIndexing = 5303,

    UniformTexelBufferArrayDynamicIndexing = 5304,

    StorageTexelBufferArrayDynamicIndexing = 5305,

    UniformBufferArrayNonUniformIndexing = 5306,

    SampledImageArrayNonUniformIndexing = 5307,

    StorageBufferArrayNonUniformIndexing = 5308,

    StorageImageArrayNonUniformIndexing = 5309,

    InputAttachmentArrayNonUniformIndexing = 5310,

    UniformTexelBufferArrayNonUniformIndexing = 5311,

    StorageTexelBufferArrayNonUniformIndexing = 5312,

    RayTracingNV = 5340,

    RayTracingMotionBlurNV = 5341,

    VulkanMemoryModel = 5345,

    VulkanMemoryModelDeviceScope = 5346,

    PhysicalStorageBufferAddresses = 5347,

    ComputeDerivativeGroupLinearNV = 5350,

    RayTracingProvisionalKHR = 5353,

    CooperativeMatrixNV = 5357,

    FragmentShaderSampleInterlockEXT = 5363,

    FragmentShaderShadingRateInterlockEXT = 5372,

    ShaderSMBuiltinsNV = 5373,

    FragmentShaderPixelInterlockEXT = 5378,

    DemoteToHelperInvocation = 5379,

    BindlessTextureNV = 5390,

    SubgroupShuffleINTEL = 5568,

    SubgroupBufferBlockIOINTEL = 5569,

    SubgroupImageBlockIOINTEL = 5570,

    SubgroupImageMediaBlockIOINTEL = 5579,

    RoundToInfinityINTEL = 5582,

    FloatingPointModeINTEL = 5583,

    IntegerFunctions2INTEL = 5584,

    FunctionPointersINTEL = 5603,

    IndirectReferencesINTEL = 5604,

    AsmINTEL = 5606,

    AtomicFloat32MinMaxEXT = 5612,

    AtomicFloat64MinMaxEXT = 5613,

    AtomicFloat16MinMaxEXT = 5616,

    VectorComputeINTEL = 5617,

    VectorAnyINTEL = 5619,

    ExpectAssumeKHR = 5629,

    SubgroupAvcMotionEstimationINTEL = 5696,

    SubgroupAvcMotionEstimationIntraINTEL = 5697,

    SubgroupAvcMotionEstimationChromaINTEL = 5698,

    VariableLengthArrayINTEL = 5817,

    FunctionFloatControlINTEL = 5821,

    FPGAMemoryAttributesINTEL = 5824,

    FPFastMathModeINTEL = 5837,

    ArbitraryPrecisionIntegersINTEL = 5844,

    ArbitraryPrecisionFloatingPointINTEL = 5845,

    UnstructuredLoopControlsINTEL = 5886,

    FPGALoopControlsINTEL = 5888,

    KernelAttributesINTEL = 5892,

    FPGAKernelAttributesINTEL = 5897,

    FPGAMemoryAccessesINTEL = 5898,

    FPGAClusterAttributesINTEL = 5904,

    LoopFuseINTEL = 5906,

    MemoryAccessAliasingINTEL = 5910,

    FPGABufferLocationINTEL = 5920,

    ArbitraryPrecisionFixedPointINTEL = 5922,

    USMStorageClassesINTEL = 5935,

    IOPipesINTEL = 5943,

    BlockingPipesINTEL = 5945,

    FPGARegINTEL = 5948,

    DotProductInputAll = 6016,

    DotProductInput4x8Bit = 6017,

    DotProductInput4x8BitPacked = 6018,

    DotProduct = 6019,

    RayCullMaskKHR = 6020,

    BitInstructions = 6025,

    GroupNonUniformRotateKHR = 6026,

    AtomicFloat32AddEXT = 6033,

    AtomicFloat64AddEXT = 6034,

    LongConstantCompositeINTEL = 6089,

    OptNoneINTEL = 6094,

    AtomicFloat16AddEXT = 6095,

    DebugInfoModuleINTEL = 6114,

    SplitBarrierINTEL = 6141,

    GroupUniformArithmeticKHR = 6400,

    Max = 2147483647,

}



