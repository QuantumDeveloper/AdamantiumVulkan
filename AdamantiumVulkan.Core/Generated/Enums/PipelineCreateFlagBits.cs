// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 2773 Column: 14
[Flags]
public enum PipelineCreateFlagBits : uint
{
    DisableOptimizationBit = 1,

    AllowDerivativesBit = 2,

    DerivativeBit = 4,

    ViewIndexFromDeviceIndexBit = 8,

    DispatchBaseBit = 16,

    FailOnPipelineCompileRequiredBit = 256,

    EarlyReturnOnFailureBit = 512,

    NoProtectedAccessBit = 134217728,

    ProtectedAccessOnlyBit = 1073741824,

    RayTracingNoNullAnyHitShadersBitKhr = 16384,

    RayTracingNoNullClosestHitShadersBitKhr = 32768,

    RayTracingNoNullMissShadersBitKhr = 65536,

    RayTracingNoNullIntersectionShadersBitKhr = 131072,

    RayTracingSkipTrianglesBitKhr = 4096,

    RayTracingSkipAabbsBitKhr = 8192,

    RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,

    DeferCompileBitNv = 32,

    RenderingFragmentDensityMapAttachmentBitExt = 4194304,

    RenderingFragmentShadingRateAttachmentBitKhr = 2097152,

    CaptureStatisticsBitKhr = 64,

    CaptureInternalRepresentationsBitKhr = 128,

    IndirectBindableBitNv = 262144,

    LibraryBitKhr = 2048,

    DescriptorBufferBitExt = 536870912,

    RetainLinkTimeOptimizationInfoBitExt = 8388608,

    LinkTimeOptimizationBitExt = 1024,

    RayTracingAllowMotionBitNv = 1048576,

    ColorAttachmentFeedbackLoopBitExt = 33554432,

    DepthStencilAttachmentFeedbackLoopBitExt = 67108864,

    RayTracingOpacityMicromapBitExt = 16777216,

    ///<summary>
    /// VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR is a deprecated alias
    ///</summary>
    FlagBitsMaxEnum = 2147483647,

}



