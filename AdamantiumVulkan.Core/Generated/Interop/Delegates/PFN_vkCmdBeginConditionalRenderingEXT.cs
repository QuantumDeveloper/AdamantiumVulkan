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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 13527 Column: 26
public unsafe struct PFN_vkCmdBeginConditionalRenderingEXT
{
    public PFN_vkCmdBeginConditionalRenderingEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkConditionalRenderingBeginInfoEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkConditionalRenderingBeginInfoEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
    {
         InvokeFunc(commandBuffer, pConditionalRenderingBegin);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkConditionalRenderingBeginInfoEXT*, void>)ptr)(commandBuffer, pConditionalRenderingBegin);
    }

    public static explicit operator PFN_vkCmdBeginConditionalRenderingEXT(void* ptr) => new(ptr);
}


