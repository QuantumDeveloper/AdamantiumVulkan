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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 6219 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSubpassDescription2
{
    public StructureType sType;
    public void* pNext;
    public VkSubpassDescriptionFlags flags;
    public PipelineBindPoint pipelineBindPoint;
    public uint viewMask;
    public uint inputAttachmentCount;
    public AdamantiumVulkan.Core.Interop.VkAttachmentReference2* pInputAttachments;
    public uint colorAttachmentCount;
    public AdamantiumVulkan.Core.Interop.VkAttachmentReference2* pColorAttachments;
    public AdamantiumVulkan.Core.Interop.VkAttachmentReference2* pResolveAttachments;
    public AdamantiumVulkan.Core.Interop.VkAttachmentReference2* pDepthStencilAttachment;
    public uint preserveAttachmentCount;
    public uint* pPreserveAttachments;
}



