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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7763 Column: 30
public unsafe struct PFN_vkGetSwapchainImagesKHR
{
    public PFN_vkGetSwapchainImagesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, out AdamantiumVulkan.Core.Interop.VkImage_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, out AdamantiumVulkan.Core.Interop.VkImage_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain, ref uint* pSwapchainImageCount, out AdamantiumVulkan.Core.Interop.VkImage_T pSwapchainImages)
    {
        return InvokeFunc(device, swapchain, ref pSwapchainImageCount, out pSwapchainImages);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain, ref uint* pSwapchainImageCount, out AdamantiumVulkan.Core.Interop.VkImage_T pSwapchainImages)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, out AdamantiumVulkan.Core.Interop.VkImage_T, Result>)ptr)(device, swapchain, ref pSwapchainImageCount, out pSwapchainImages);
    }

    public static explicit operator PFN_vkGetSwapchainImagesKHR(void* ptr) => new(ptr);
}


