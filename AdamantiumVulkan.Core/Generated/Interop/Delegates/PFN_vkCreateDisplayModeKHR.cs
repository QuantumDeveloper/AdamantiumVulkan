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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 8856 Column: 30
public unsafe struct PFN_vkCreateDisplayModeKHR
{
    public PFN_vkCreateDisplayModeKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayModeCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayModeCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayModeCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T pMode)
    {
        return InvokeFunc(physicalDevice, display, pCreateInfo, pAllocator, out pMode);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayModeCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T pMode)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayModeCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T, Result>)ptr)(physicalDevice, display, pCreateInfo, pAllocator, out pMode);
    }

    public static explicit operator PFN_vkCreateDisplayModeKHR(void* ptr) => new(ptr);
}


