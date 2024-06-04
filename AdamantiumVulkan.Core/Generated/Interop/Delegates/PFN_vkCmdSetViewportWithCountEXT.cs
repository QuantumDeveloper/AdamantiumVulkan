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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 14764 Column: 26
public unsafe struct PFN_vkCmdSetViewportWithCountEXT
{
    public PFN_vkCmdSetViewportWithCountEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewport* pViewports)
    {
         InvokeFunc(commandBuffer, viewportCount, pViewports);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewport* pViewports)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void>)ptr)(commandBuffer, viewportCount, pViewports);
    }

    public static explicit operator PFN_vkCmdSetViewportWithCountEXT(void* ptr) => new(ptr);
}


