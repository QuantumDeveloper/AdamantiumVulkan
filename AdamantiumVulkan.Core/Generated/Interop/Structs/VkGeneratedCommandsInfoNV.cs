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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15233 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkGeneratedCommandsInfoNV
{
    public StructureType sType;
    public void* pNext;
    public PipelineBindPoint pipelineBindPoint;
    public VkPipeline_T pipeline;
    public VkIndirectCommandsLayoutNV_T indirectCommandsLayout;
    public uint streamCount;
    public AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV* pStreams;
    public uint sequencesCount;
    public VkBuffer_T preprocessBuffer;
    public VkDeviceSize preprocessOffset;
    public VkDeviceSize preprocessSize;
    public VkBuffer_T sequencesCountBuffer;
    public VkDeviceSize sequencesCountOffset;
    public VkBuffer_T sequencesIndexBuffer;
    public VkDeviceSize sequencesIndexOffset;
}



