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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 20009 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceCooperativeVectorPropertiesNV
{
    public StructureType sType;
    public void* pNext;
    public VkShaderStageFlags cooperativeVectorSupportedStages;
    public VkBool32 cooperativeVectorTrainingFloat16Accumulation;
    public VkBool32 cooperativeVectorTrainingFloat32Accumulation;
    public uint maxCooperativeVectorComponents;
}



