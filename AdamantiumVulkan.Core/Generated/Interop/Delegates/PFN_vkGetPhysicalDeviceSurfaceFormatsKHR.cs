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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7628 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceSurfaceFormatsKHR
{
    public PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSurfaceFormatKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSurfaceFormatKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T surface, ref uint* pSurfaceFormatCount, AdamantiumVulkan.Core.Interop.VkSurfaceFormatKHR* pSurfaceFormats)
    {
        return InvokeFunc(physicalDevice, surface, ref pSurfaceFormatCount, pSurfaceFormats);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T surface, ref uint* pSurfaceFormatCount, AdamantiumVulkan.Core.Interop.VkSurfaceFormatKHR* pSurfaceFormats)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSurfaceFormatKHR*, Result>)ptr)(physicalDevice, surface, ref pSurfaceFormatCount, pSurfaceFormats);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(void* ptr) => new(ptr);
}


