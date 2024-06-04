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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3978 Column: 30
public unsafe struct PFN_vkCreateGraphicsPipelines
{
    public PFN_vkCreateGraphicsPipelines(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineCache_T, uint, AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkPipeline_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineCache_T, uint, AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkPipeline_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineCache_T pipelineCache, uint createInfoCount, AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo* pCreateInfos, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkPipeline_T pPipelines)
    {
        return InvokeFunc(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineCache_T pipelineCache, uint createInfoCount, AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo* pCreateInfos, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkPipeline_T pPipelines)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineCache_T, uint, AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkPipeline_T, Result>)ptr)(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, out pPipelines);
    }

    public static explicit operator PFN_vkCreateGraphicsPipelines(void* ptr) => new(ptr);
}


