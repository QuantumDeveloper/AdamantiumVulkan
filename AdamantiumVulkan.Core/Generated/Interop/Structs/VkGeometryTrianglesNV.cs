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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 14893 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkGeometryTrianglesNV
{
    public StructureType sType;
    public void* pNext;
    public VkBuffer_T vertexData;
    public VkDeviceSize vertexOffset;
    public uint vertexCount;
    public VkDeviceSize vertexStride;
    public Format vertexFormat;
    public VkBuffer_T indexData;
    public VkDeviceSize indexOffset;
    public uint indexCount;
    public IndexType indexType;
    public VkBuffer_T transformData;
    public VkDeviceSize transformOffset;
}



