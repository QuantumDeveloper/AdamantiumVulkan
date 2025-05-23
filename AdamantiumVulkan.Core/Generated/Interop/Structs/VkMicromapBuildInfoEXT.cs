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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18423 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkMicromapBuildInfoEXT
{
    public StructureType sType;
    public void* pNext;
    public MicromapTypeEXT type;
    public VkBuildMicromapFlagsEXT flags;
    public BuildMicromapModeEXT mode;
    public VkMicromapEXT_T dstMicromap;
    public uint usageCountsCount;
    public AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT* pUsageCounts;
    public AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT** ppUsageCounts;
    public VkDeviceOrHostAddressConstKHR data;
    public VkDeviceOrHostAddressKHR scratchData;
    public VkDeviceOrHostAddressConstKHR triangleArray;
    public VkDeviceSize triangleArrayStride;
}



