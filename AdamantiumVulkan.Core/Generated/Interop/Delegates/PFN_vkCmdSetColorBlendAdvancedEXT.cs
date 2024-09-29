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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 18043 Column: 26
public unsafe struct PFN_vkCmdSetColorBlendAdvancedEXT
{
    public PFN_vkCmdSetColorBlendAdvancedEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT* pColorBlendAdvanced)
    {
         InvokeFunc(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT* pColorBlendAdvanced)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT*, void>)ptr)(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
    }

    public static explicit operator PFN_vkCmdSetColorBlendAdvancedEXT(void* ptr) => new(ptr);
}


