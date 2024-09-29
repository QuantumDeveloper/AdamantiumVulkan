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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 16129 Column: 26
public unsafe struct PFN_vkCmdSetDescriptorBufferOffsetsEXT
{
    public PFN_vkCmdSetDescriptorBufferOffsetsEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, uint, uint, uint*, VkDeviceSize*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, uint, uint, uint*, VkDeviceSize*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T layout, uint firstSet, uint setCount, uint* pBufferIndices, VkDeviceSize* pOffsets)
    {
         InvokeFunc(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T layout, uint firstSet, uint setCount, uint* pBufferIndices, VkDeviceSize* pOffsets)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, uint, uint, uint*, VkDeviceSize*, void>)ptr)(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
    }

    public static explicit operator PFN_vkCmdSetDescriptorBufferOffsetsEXT(void* ptr) => new(ptr);
}


