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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3482 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkPipelineInputAssemblyStateCreateFlags flags;
    public PrimitiveTopology topology;
    public VkBool32 primitiveRestartEnable;
}



