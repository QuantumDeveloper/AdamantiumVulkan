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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 15416 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
{
    public StructureType sType;
    public void* pNext;
    public uint stageCount;
    public AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo* pStages;
    public AdamantiumVulkan.Core.Interop.VkPipelineVertexInputStateCreateInfo* pVertexInputState;
    public AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo* pTessellationState;
}



