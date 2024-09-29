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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 14009 Column: 26
public unsafe struct PFN_vkCmdWriteBufferMarkerAMD
{
    public PFN_vkCmdWriteBufferMarkerAMD(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineStageFlagBits, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineStageFlagBits, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineStageFlagBits pipelineStage, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, VkDeviceSize dstOffset, uint marker)
    {
         InvokeFunc(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineStageFlagBits pipelineStage, AdamantiumVulkan.Core.Interop.VkBuffer_T dstBuffer, VkDeviceSize dstOffset, uint marker)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineStageFlagBits, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, uint, void>)ptr)(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
    }

    public static explicit operator PFN_vkCmdWriteBufferMarkerAMD(void* ptr) => new(ptr);
}


