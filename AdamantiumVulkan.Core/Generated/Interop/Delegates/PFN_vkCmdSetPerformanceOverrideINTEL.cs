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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 14154 Column: 30
public unsafe struct PFN_vkCmdSetPerformanceOverrideINTEL
{
    public PFN_vkCmdSetPerformanceOverrideINTEL(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL* pOverrideInfo)
    {
        return InvokeFunc(commandBuffer, pOverrideInfo);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL* pOverrideInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL*, Result>)ptr)(commandBuffer, pOverrideInfo);
    }

    public static explicit operator PFN_vkCmdSetPerformanceOverrideINTEL(void* ptr) => new(ptr);
}


