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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 16164 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 subsampledLoads;
    public VkBool32 subsampledCoarseReconstructionEarlyAccess;
    public uint maxSubsampledArrayLayers;
    public uint maxDescriptorSetSubsampledSamplers;
}



