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
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Windows.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_win32.h Line: 176 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkImportFenceWin32HandleInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VkFence_T fence;
    public VkFenceImportFlags flags;
    public ExternalFenceHandleTypeFlagBits handleType;
    public System.IntPtr handle;
    public char name;
}



