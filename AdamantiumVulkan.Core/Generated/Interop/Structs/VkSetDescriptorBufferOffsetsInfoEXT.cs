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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 12594 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSetDescriptorBufferOffsetsInfoEXT
{
    public StructureType sType;
    public void* pNext;
    public VkShaderStageFlags stageFlags;
    public VkPipelineLayout_T layout;
    public uint firstSet;
    public uint setCount;
    public uint* pBufferIndices;
    public AdamantiumVulkan.Core.Interop.VkDeviceSize* pOffsets;
}



