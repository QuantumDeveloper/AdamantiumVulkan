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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7706 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPresentInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public uint waitSemaphoreCount;
    public VkSemaphore_T* pWaitSemaphores;
    public uint swapchainCount;
    public VkSwapchainKHR_T* pSwapchains;
    public uint* pImageIndices;
    public Result* pResults;
}



