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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 9367 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeH264QualityLevelPropertiesKHR
{
    public StructureType sType;
    public void* pNext;
    public VkVideoEncodeH264RateControlFlagsKHR preferredRateControlFlags;
    public uint preferredGopFrameCount;
    public uint preferredIdrPeriod;
    public uint preferredConsecutiveBFrameCount;
    public uint preferredTemporalLayerCount;
    public VkVideoEncodeH264QpKHR preferredConstantQp;
    public uint preferredMaxL0ReferenceCount;
    public uint preferredMaxL1ReferenceCount;
    public VkBool32 preferredStdEntropyCodingModeFlag;
}



