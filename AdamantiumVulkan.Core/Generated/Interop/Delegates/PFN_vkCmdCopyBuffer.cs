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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 4025 Column: 26
public unsafe struct PFN_vkCmdCopyBuffer
{
    public PFN_vkCmdCopyBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkBufferCopy*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkBufferCopy*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T srcBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, uint regionCount, AdamantiumVulkan.Core.Interop.VkBufferCopy* pRegions)
    {
         InvokeFunc(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T srcBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, uint regionCount, AdamantiumVulkan.Core.Interop.VkBufferCopy* pRegions)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkBufferCopy*, void>)ptr)(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
    }

    public static explicit operator PFN_vkCmdCopyBuffer(void* ptr) => new(ptr);
}


