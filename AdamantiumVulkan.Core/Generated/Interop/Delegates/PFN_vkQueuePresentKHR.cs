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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 7729 Column: 30
public unsafe struct PFN_vkQueuePresentKHR
{
    public PFN_vkQueuePresentKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkPresentInfoKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkPresentInfoKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkQueue_T queue, AdamantiumVulkan.Core.Interop.VkPresentInfoKHR* pPresentInfo)
    {
        return InvokeFunc(queue, pPresentInfo);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkQueue_T queue, AdamantiumVulkan.Core.Interop.VkPresentInfoKHR* pPresentInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkPresentInfoKHR*, Result>)ptr)(queue, pPresentInfo);
    }

    public static explicit operator PFN_vkQueuePresentKHR(void* ptr) => new(ptr);
}


