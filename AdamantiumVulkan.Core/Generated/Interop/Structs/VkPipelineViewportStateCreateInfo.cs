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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3506 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineViewportStateCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkPipelineViewportStateCreateFlags flags;
    public uint viewportCount;
    public AdamantiumVulkan.Core.Interop.VkViewport* pViewports;
    public uint scissorCount;
    public AdamantiumVulkan.Core.Interop.VkRect2D* pScissors;
}



