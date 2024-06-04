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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3993 Column: 30
public unsafe struct PFN_vkCreateFramebuffer
{
    public PFN_vkCreateFramebuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFramebuffer_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFramebuffer_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkFramebuffer_T pFramebuffer)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pFramebuffer);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkFramebuffer_T pFramebuffer)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFramebuffer_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pFramebuffer);
    }

    public static explicit operator PFN_vkCreateFramebuffer(void* ptr) => new(ptr);
}


