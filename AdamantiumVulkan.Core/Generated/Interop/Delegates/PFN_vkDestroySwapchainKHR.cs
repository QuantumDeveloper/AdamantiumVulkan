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

public unsafe struct PFN_vkDestroySwapchainKHR
{
    public PFN_vkDestroySwapchainKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkSwapchainKHR_T swapchain, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, swapchain, pAllocator);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkSwapchainKHR_T swapchain, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkAllocationCallbacks*, void>)ptr)(device, swapchain, pAllocator);
    }

    public static explicit operator PFN_vkDestroySwapchainKHR(void* ptr) => new(ptr);
}

