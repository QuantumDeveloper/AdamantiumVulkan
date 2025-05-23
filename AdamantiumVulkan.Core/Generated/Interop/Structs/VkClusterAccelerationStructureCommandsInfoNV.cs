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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 20717 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkClusterAccelerationStructureCommandsInfoNV
{
    public StructureType sType;
    public void* pNext;
    public VkClusterAccelerationStructureInputInfoNV input;
    public VkDeviceAddress dstImplicitData;
    public VkDeviceAddress scratchData;
    public VkStridedDeviceAddressRegionKHR dstAddressesArray;
    public VkStridedDeviceAddressRegionKHR dstSizesArray;
    public VkStridedDeviceAddressRegionKHR srcInfosArray;
    public VkDeviceAddress srcInfosCount;
    public VkClusterAccelerationStructureAddressResolutionFlagsNV addressResolutionFlags;
}



