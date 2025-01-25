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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 7527 Column: 26
public unsafe struct PFN_vkCmdBindVertexBuffers2
{
    public PFN_vkCmdBindVertexBuffers2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstBinding, uint bindingCount, AdamantiumVulkan.Core.Interop.VkBuffer_T* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
         InvokeFunc(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstBinding, uint bindingCount, AdamantiumVulkan.Core.Interop.VkBuffer_T* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)ptr)(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }

    public static explicit operator PFN_vkCmdBindVertexBuffers2(void* ptr) => new(ptr);
}


