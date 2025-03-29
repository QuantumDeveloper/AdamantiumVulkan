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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18503 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapEXT
{
    public StructureType sType;
    public void* pNext;
    public IndexType indexType;
    public VkDeviceOrHostAddressConstKHR indexBuffer;
    public VkDeviceSize indexStride;
    public uint baseTriangle;
    public uint usageCountsCount;
    public AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT* pUsageCounts;
    public AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT** ppUsageCounts;
    public VkMicromapEXT_T micromap;
}



