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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 14591 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
    public StructureType sType;
    public void* pNext;
    public CoarseSampleOrderTypeNV sampleOrderType;
    public uint customSampleOrderCount;
    public AdamantiumVulkan.Core.Interop.VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
}



