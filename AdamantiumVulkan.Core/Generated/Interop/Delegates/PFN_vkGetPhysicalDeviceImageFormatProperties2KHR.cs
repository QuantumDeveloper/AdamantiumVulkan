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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 8907 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceImageFormatProperties2KHR
{
    public PFN_vkGetPhysicalDeviceImageFormatProperties2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageFormatInfo2*, AdamantiumVulkan.Core.Interop.VkImageFormatProperties2*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageFormatInfo2*, AdamantiumVulkan.Core.Interop.VkImageFormatProperties2*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, AdamantiumVulkan.Core.Interop.VkImageFormatProperties2* pImageFormatProperties)
    {
        return InvokeFunc(physicalDevice, pImageFormatInfo, pImageFormatProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, AdamantiumVulkan.Core.Interop.VkImageFormatProperties2* pImageFormatProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageFormatInfo2*, AdamantiumVulkan.Core.Interop.VkImageFormatProperties2*, Result>)ptr)(physicalDevice, pImageFormatInfo, pImageFormatProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceImageFormatProperties2KHR(void* ptr) => new(ptr);
}


