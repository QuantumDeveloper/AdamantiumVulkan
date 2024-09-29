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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 12770 Column: 26
public unsafe struct PFN_vkCmdSetDiscardRectangleModeEXT
{
    public PFN_vkCmdSetDiscardRectangleModeEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, DiscardRectangleModeEXT, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, DiscardRectangleModeEXT, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, DiscardRectangleModeEXT discardRectangleMode)
    {
         InvokeFunc(commandBuffer, discardRectangleMode);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, DiscardRectangleModeEXT discardRectangleMode)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, DiscardRectangleModeEXT, void>)ptr)(commandBuffer, discardRectangleMode);
    }

    public static explicit operator PFN_vkCmdSetDiscardRectangleModeEXT(void* ptr) => new(ptr);
}


