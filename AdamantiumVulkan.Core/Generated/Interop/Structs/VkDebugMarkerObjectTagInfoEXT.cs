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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 13081 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
{
    public StructureType sType;
    public void* pNext;
    public DebugReportObjectTypeEXT objectType;
    public ulong @object;
    public ulong tagName;
    public ulong tagSize;
    public void* pTag;
}



