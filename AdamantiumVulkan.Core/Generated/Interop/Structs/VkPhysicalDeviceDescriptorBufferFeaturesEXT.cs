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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 17078 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 descriptorBuffer;
    public VkBool32 descriptorBufferCaptureReplay;
    public VkBool32 descriptorBufferImageLayoutIgnored;
    public VkBool32 descriptorBufferPushDescriptors;
}



