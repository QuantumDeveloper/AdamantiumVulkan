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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 6597 Column: 26
public unsafe struct PFN_vkCmdBeginRenderPass2
{
    public PFN_vkCmdBeginRenderPass2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo* pRenderPassBegin, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo* pSubpassBeginInfo)
    {
         InvokeFunc(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo* pRenderPassBegin, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo* pSubpassBeginInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, void>)ptr)(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
    }

    public static explicit operator PFN_vkCmdBeginRenderPass2(void* ptr) => new(ptr);
}


