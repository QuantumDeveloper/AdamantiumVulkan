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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 4203 Column: 30
public unsafe struct PFN_vkEndCommandBuffer
{
    public PFN_vkEndCommandBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer)
    {
        return InvokeFunc(commandBuffer);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, Result>)ptr)(commandBuffer);
    }

    public static explicit operator PFN_vkEndCommandBuffer(void* ptr) => new(ptr);
}


