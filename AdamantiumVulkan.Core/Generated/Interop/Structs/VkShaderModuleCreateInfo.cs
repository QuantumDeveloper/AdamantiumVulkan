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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 3444 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkShaderModuleCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkShaderModuleCreateFlags flags;
    public ulong codeSize;
    public byte* pCode;
}



