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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6990 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSubmitInfo2
{
    public StructureType sType;
    public void* pNext;
    public VkSubmitFlags flags;
    public uint waitSemaphoreInfoCount;
    public AdamantiumVulkan.Core.Interop.VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
    public uint commandBufferInfoCount;
    public AdamantiumVulkan.Core.Interop.VkCommandBufferSubmitInfo* pCommandBufferInfos;
    public uint signalSemaphoreInfoCount;
    public AdamantiumVulkan.Core.Interop.VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
}



