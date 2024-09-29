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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6933 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkBufferMemoryBarrier2
{
    public StructureType sType;
    public void* pNext;
    public VkPipelineStageFlags2 srcStageMask;
    public VkAccessFlags2 srcAccessMask;
    public VkPipelineStageFlags2 dstStageMask;
    public VkAccessFlags2 dstAccessMask;
    public uint srcQueueFamilyIndex;
    public uint dstQueueFamilyIndex;
    public VkBuffer_T buffer;
    public VkDeviceSize offset;
    public VkDeviceSize size;
}



