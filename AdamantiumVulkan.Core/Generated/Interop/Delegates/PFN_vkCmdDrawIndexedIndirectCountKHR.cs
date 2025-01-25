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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 10793 Column: 26
public unsafe struct PFN_vkCmdDrawIndexedIndirectCountKHR
{
    public PFN_vkCmdDrawIndexedIndirectCountKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, VkDeviceSize offset, AdamantiumVulkan.Core.Interop.VkBuffer_T countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
         InvokeFunc(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, VkDeviceSize offset, AdamantiumVulkan.Core.Interop.VkBuffer_T countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, uint, void>)ptr)(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }

    public static explicit operator PFN_vkCmdDrawIndexedIndirectCountKHR(void* ptr) => new(ptr);
}


