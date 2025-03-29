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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18107 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkFrameBoundaryEXT
{
    public StructureType sType;
    public void* pNext;
    public VkFrameBoundaryFlagsEXT flags;
    public ulong frameID;
    public uint imageCount;
    public VkImage_T* pImages;
    public uint bufferCount;
    public VkBuffer_T* pBuffers;
    public ulong tagName;
    public ulong tagSize;
    public void* pTag;
}



