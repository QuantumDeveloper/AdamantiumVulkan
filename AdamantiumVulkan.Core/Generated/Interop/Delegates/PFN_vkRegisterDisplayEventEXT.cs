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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 12342 Column: 30
public unsafe struct PFN_vkRegisterDisplayEventEXT
{
    public PFN_vkRegisterDisplayEventEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayEventInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFence_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayEventInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFence_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayEventInfoEXT* pDisplayEventInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkFence_T pFence)
    {
        return InvokeFunc(device, display, pDisplayEventInfo, pAllocator, out pFence);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayEventInfoEXT* pDisplayEventInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkFence_T pFence)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayEventInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkFence_T, Result>)ptr)(device, display, pDisplayEventInfo, pAllocator, out pFence);
    }

    public static explicit operator PFN_vkRegisterDisplayEventEXT(void* ptr) => new(ptr);
}


