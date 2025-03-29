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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4171 Column: 30
public unsafe struct PFN_vkQueueSubmit
{
    public PFN_vkQueueSubmit(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, uint, AdamantiumVulkan.Core.Interop.VkSubmitInfo*, AdamantiumVulkan.Core.Interop.VkFence_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, uint, AdamantiumVulkan.Core.Interop.VkSubmitInfo*, AdamantiumVulkan.Core.Interop.VkFence_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkQueue_T queue, uint submitCount, AdamantiumVulkan.Core.Interop.VkSubmitInfo* pSubmits, AdamantiumVulkan.Core.Interop.VkFence_T fence)
    {
        return InvokeFunc(queue, submitCount, pSubmits, fence);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkQueue_T queue, uint submitCount, AdamantiumVulkan.Core.Interop.VkSubmitInfo* pSubmits, AdamantiumVulkan.Core.Interop.VkFence_T fence)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, uint, AdamantiumVulkan.Core.Interop.VkSubmitInfo*, AdamantiumVulkan.Core.Interop.VkFence_T, Result>)ptr)(queue, submitCount, pSubmits, fence);
    }

    public static explicit operator PFN_vkQueueSubmit(void* ptr) => new(ptr);
}


