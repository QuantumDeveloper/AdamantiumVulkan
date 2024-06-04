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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15263 Column: 26
public unsafe struct PFN_vkCmdBindPipelineShaderGroupNV
{
    public PFN_vkCmdBindPipelineShaderGroupNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipeline_T, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipeline_T, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipeline_T pipeline, uint groupIndex)
    {
         InvokeFunc(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipeline_T pipeline, uint groupIndex)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PipelineBindPoint, AdamantiumVulkan.Core.Interop.VkPipeline_T, uint, void>)ptr)(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
    }

    public static explicit operator PFN_vkCmdBindPipelineShaderGroupNV(void* ptr) => new(ptr);
}


