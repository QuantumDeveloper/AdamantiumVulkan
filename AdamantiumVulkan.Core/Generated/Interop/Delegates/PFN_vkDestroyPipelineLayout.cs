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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3982 Column: 26
public unsafe struct PFN_vkDestroyPipelineLayout
{
    public PFN_vkDestroyPipelineLayout(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T pipelineLayout, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, pipelineLayout, pAllocator);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T pipelineLayout, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineLayout_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr)(device, pipelineLayout, pAllocator);
    }

    public static explicit operator PFN_vkDestroyPipelineLayout(void* ptr) => new(ptr);
}


