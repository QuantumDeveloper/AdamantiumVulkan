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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4242 Column: 26
public unsafe struct PFN_vkFreeCommandBuffers
{
    public PFN_vkFreeCommandBuffers(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, uint, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, uint, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkCommandPool_T commandPool, uint commandBufferCount, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T* pCommandBuffers)
    {
         InvokeFunc(device, commandPool, commandBufferCount, pCommandBuffers);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkCommandPool_T commandPool, uint commandBufferCount, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T* pCommandBuffers)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkCommandPool_T, uint, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T*, void>)ptr)(device, commandPool, commandBufferCount, pCommandBuffers);
    }

    public static explicit operator PFN_vkFreeCommandBuffers(void* ptr) => new(ptr);
}


