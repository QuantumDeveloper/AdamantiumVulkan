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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 11382 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
{
    public StructureType sType;
    public void* pNext;
    public unsafe fixed sbyte name[256];
    public unsafe fixed sbyte description[256];
    public VkBool32 isText;
    public ulong dataSize;
    public void* pData;
}



