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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15264 Column: 30
public unsafe struct PFN_vkCreateIndirectCommandsLayoutNV
{
    public PFN_vkCreateIndirectCommandsLayoutNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T pIndirectCommandsLayout)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pIndirectCommandsLayout);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T pIndirectCommandsLayout)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pIndirectCommandsLayout);
    }

    public static explicit operator PFN_vkCreateIndirectCommandsLayoutNV(void* ptr) => new(ptr);
}


