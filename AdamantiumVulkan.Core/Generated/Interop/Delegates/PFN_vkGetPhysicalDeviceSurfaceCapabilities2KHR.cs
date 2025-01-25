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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 10543 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR
{
    public PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
    {
        return InvokeFunc(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR*, Result>)ptr)(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR(void* ptr) => new(ptr);
}


