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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 11986 Column: 26
public unsafe struct PFN_vkCmdEndTransformFeedbackEXT
{
    public PFN_vkCmdEndTransformFeedbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstCounterBuffer, uint counterBufferCount, AdamantiumVulkan.Core.Interop.VkBuffer_T* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
         InvokeFunc(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstCounterBuffer, uint counterBufferCount, AdamantiumVulkan.Core.Interop.VkBuffer_T* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkBuffer_T*, VkDeviceSize*, void>)ptr)(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }

    public static explicit operator PFN_vkCmdEndTransformFeedbackEXT(void* ptr) => new(ptr);
}


