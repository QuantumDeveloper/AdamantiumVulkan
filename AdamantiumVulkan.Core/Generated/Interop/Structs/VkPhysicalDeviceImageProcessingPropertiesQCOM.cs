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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 19151 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
    public StructureType sType;
    public void* pNext;
    public uint maxWeightFilterPhases;
    public VkExtent2D maxWeightFilterDimension;
    public VkExtent2D maxBlockMatchRegion;
    public VkExtent2D maxBoxFilterBlockSize;
}



