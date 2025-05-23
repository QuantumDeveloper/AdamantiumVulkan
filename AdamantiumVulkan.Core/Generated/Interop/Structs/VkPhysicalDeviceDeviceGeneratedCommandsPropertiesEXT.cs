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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 20993 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
{
    public StructureType sType;
    public void* pNext;
    public uint maxIndirectPipelineCount;
    public uint maxIndirectShaderObjectCount;
    public uint maxIndirectSequenceCount;
    public uint maxIndirectCommandsTokenCount;
    public uint maxIndirectCommandsTokenOffset;
    public uint maxIndirectCommandsIndirectStride;
    public VkIndirectCommandsInputModeFlagsEXT supportedIndirectCommandsInputModes;
    public VkShaderStageFlags supportedIndirectCommandsShaderStages;
    public VkShaderStageFlags supportedIndirectCommandsShaderStagesPipelineBinding;
    public VkShaderStageFlags supportedIndirectCommandsShaderStagesShaderBinding;
    public VkBool32 deviceGeneratedCommandsTransformFeedback;
    public VkBool32 deviceGeneratedCommandsMultiDrawIndirectCount;
}



