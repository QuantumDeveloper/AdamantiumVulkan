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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 9749 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public uint maxStdSPSCount;
    public uint maxStdPPSCount;
    public AdamantiumVulkan.Core.Interop.VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
}



