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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 17780 Column: 26
public unsafe struct PFN_vkCmdSetColorBlendEnableEXT
{
    public PFN_vkCmdSetColorBlendEnableEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, VkBool32*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, VkBool32*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
    {
         InvokeFunc(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, VkBool32*, void>)ptr)(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
    }

    public static explicit operator PFN_vkCmdSetColorBlendEnableEXT(void* ptr) => new(ptr);
}


