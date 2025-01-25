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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 4243 Column: 26
public unsafe struct PFN_vkCmdCopyQueryPoolResults
{
    public PFN_vkCmdCopyQueryPoolResults(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, VkQueryResultFlags, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, VkQueryResultFlags, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkQueryPool_T queryPool, uint firstQuery, uint queryCount, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags)
    {
         InvokeFunc(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkQueryPool_T queryPool, uint firstQuery, uint queryCount, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, VkQueryResultFlags, void>)ptr)(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
    }

    public static explicit operator PFN_vkCmdCopyQueryPoolResults(void* ptr) => new(ptr);
}


