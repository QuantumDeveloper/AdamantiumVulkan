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

namespace AdamantiumVulkan.Windows.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_win32.h Line: 133 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public void* pAttributes;
    public uint dwAccess;
    public char name;
}



