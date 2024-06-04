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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 6043 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkRenderPassCreateInfo2
{
    public StructureType sType;
    public void* pNext;
    public VkRenderPassCreateFlags flags;
    public uint attachmentCount;
    public AdamantiumVulkan.Core.Interop.VkAttachmentDescription2* pAttachments;
    public uint subpassCount;
    public AdamantiumVulkan.Core.Interop.VkSubpassDescription2* pSubpasses;
    public uint dependencyCount;
    public AdamantiumVulkan.Core.Interop.VkSubpassDependency2* pDependencies;
    public uint correlatedViewMaskCount;
    public uint* pCorrelatedViewMasks;
}



