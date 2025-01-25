// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 10608 Column: 30
public unsafe struct PFN_vkGetDisplayPlaneCapabilities2KHR
{
    public PFN_vkGetDisplayPlaneCapabilities2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayPlaneInfo2KHR*, AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayPlaneInfo2KHR*, AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR* pCapabilities)
    {
        return InvokeFunc(physicalDevice, pDisplayPlaneInfo, pCapabilities);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR* pCapabilities)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayPlaneInfo2KHR*, AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR*, Result>)ptr)(physicalDevice, pDisplayPlaneInfo, pCapabilities);
    }

    public static explicit operator PFN_vkGetDisplayPlaneCapabilities2KHR(void* ptr) => new(ptr);
}


