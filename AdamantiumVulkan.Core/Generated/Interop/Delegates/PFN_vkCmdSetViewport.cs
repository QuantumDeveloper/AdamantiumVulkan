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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4247 Column: 26
public unsafe struct PFN_vkCmdSetViewport
{
    public PFN_vkCmdSetViewport(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewport* pViewports)
    {
         InvokeFunc(commandBuffer, firstViewport, viewportCount, pViewports);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewport* pViewports)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewport*, void>)ptr)(commandBuffer, firstViewport, viewportCount, pViewports);
    }

    public static explicit operator PFN_vkCmdSetViewport(void* ptr) => new(ptr);
}


