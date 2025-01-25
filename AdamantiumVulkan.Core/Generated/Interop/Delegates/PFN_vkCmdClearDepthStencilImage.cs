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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 4232 Column: 26
public unsafe struct PFN_vkCmdClearDepthStencilImage
{
    public PFN_vkCmdClearDepthStencilImage(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkClearDepthStencilValue*, uint, AdamantiumVulkan.Core.Interop.VkImageSubresourceRange*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkClearDepthStencilValue*, uint, AdamantiumVulkan.Core.Interop.VkImageSubresourceRange*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkImage_T image, ImageLayout imageLayout, AdamantiumVulkan.Core.Interop.VkClearDepthStencilValue* pDepthStencil, uint rangeCount, AdamantiumVulkan.Core.Interop.VkImageSubresourceRange* pRanges)
    {
         InvokeFunc(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkImage_T image, ImageLayout imageLayout, AdamantiumVulkan.Core.Interop.VkClearDepthStencilValue* pDepthStencil, uint rangeCount, AdamantiumVulkan.Core.Interop.VkImageSubresourceRange* pRanges)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkClearDepthStencilValue*, uint, AdamantiumVulkan.Core.Interop.VkImageSubresourceRange*, void>)ptr)(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
    }

    public static explicit operator PFN_vkCmdClearDepthStencilImage(void* ptr) => new(ptr);
}


