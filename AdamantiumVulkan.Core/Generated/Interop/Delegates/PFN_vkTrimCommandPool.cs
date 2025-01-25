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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 5762 Column: 26
public unsafe struct PFN_vkTrimCommandPool
{
    public PFN_vkTrimCommandPool(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, VkCommandPoolTrimFlags, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, VkCommandPoolTrimFlags, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkCommandPool_T commandPool, VkCommandPoolTrimFlags flags)
    {
         InvokeFunc(device, commandPool, flags);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkCommandPool_T commandPool, VkCommandPoolTrimFlags flags)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, VkCommandPoolTrimFlags, void>)ptr)(device, commandPool, flags);
    }

    public static explicit operator PFN_vkTrimCommandPool(void* ptr) => new(ptr);
}


