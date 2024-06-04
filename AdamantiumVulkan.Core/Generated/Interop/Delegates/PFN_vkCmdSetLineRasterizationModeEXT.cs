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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 17790 Column: 26
public unsafe struct PFN_vkCmdSetLineRasterizationModeEXT
{
    public PFN_vkCmdSetLineRasterizationModeEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, LineRasterizationModeEXT, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, LineRasterizationModeEXT, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, LineRasterizationModeEXT lineRasterizationMode)
    {
         InvokeFunc(commandBuffer, lineRasterizationMode);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, LineRasterizationModeEXT lineRasterizationMode)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, LineRasterizationModeEXT, void>)ptr)(commandBuffer, lineRasterizationMode);
    }

    public static explicit operator PFN_vkCmdSetLineRasterizationModeEXT(void* ptr) => new(ptr);
}


