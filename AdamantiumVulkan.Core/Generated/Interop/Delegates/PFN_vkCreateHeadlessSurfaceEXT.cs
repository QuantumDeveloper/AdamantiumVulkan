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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 14640 Column: 30
public unsafe struct PFN_vkCreateHeadlessSurfaceEXT
{
    public PFN_vkCreateHeadlessSurfaceEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pSurface);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pSurface);
    }

    public static explicit operator PFN_vkCreateHeadlessSurfaceEXT(void* ptr) => new(ptr);
}


