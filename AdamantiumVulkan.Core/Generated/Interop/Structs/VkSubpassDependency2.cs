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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 6235 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSubpassDependency2
{
    public StructureType sType;
    public void* pNext;
    public uint srcSubpass;
    public uint dstSubpass;
    public VkPipelineStageFlags srcStageMask;
    public VkPipelineStageFlags dstStageMask;
    public VkAccessFlags srcAccessMask;
    public VkAccessFlags dstAccessMask;
    public VkDependencyFlags dependencyFlags;
    public int viewOffset;
}



