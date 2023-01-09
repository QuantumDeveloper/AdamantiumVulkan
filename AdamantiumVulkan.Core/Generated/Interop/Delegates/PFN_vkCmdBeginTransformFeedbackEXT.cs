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

public unsafe struct PFN_vkCmdBeginTransformFeedbackEXT
{
    public PFN_vkCmdBeginTransformFeedbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer_T* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
         InvokeFunc(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer_T* pCounterBuffers, VkDeviceSize* pCounterBufferOffsets)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, void>)ptr)(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
    }

    public static explicit operator PFN_vkCmdBeginTransformFeedbackEXT(void* ptr) => new(ptr);
}


