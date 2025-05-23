// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 12406 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeAV1QualityLevelPropertiesKHR
{
    public StructureType sType;
    public void* pNext;
    public VkVideoEncodeAV1RateControlFlagsKHR preferredRateControlFlags;
    public uint preferredGopFrameCount;
    public uint preferredKeyFramePeriod;
    public uint preferredConsecutiveBipredictiveFrameCount;
    public uint preferredTemporalLayerCount;
    public VkVideoEncodeAV1QIndexKHR preferredConstantQIndex;
    public uint preferredMaxSingleReferenceCount;
    public uint preferredSingleReferenceNameMask;
    public uint preferredMaxUnidirectionalCompoundReferenceCount;
    public uint preferredMaxUnidirectionalCompoundGroup1ReferenceCount;
    public uint preferredUnidirectionalCompoundReferenceNameMask;
    public uint preferredMaxBidirectionalCompoundReferenceCount;
    public uint preferredMaxBidirectionalCompoundGroup1ReferenceCount;
    public uint preferredMaxBidirectionalCompoundGroup2ReferenceCount;
    public uint preferredBidirectionalCompoundReferenceNameMask;
}



