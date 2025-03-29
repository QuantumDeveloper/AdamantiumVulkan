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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 19265 Column: 26
public unsafe struct PFN_vkCmdSetColorBlendEquationEXT
{
    public PFN_vkCmdSetColorBlendEquationEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendEquationEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendEquationEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, AdamantiumVulkan.Core.Interop.VkColorBlendEquationEXT* pColorBlendEquations)
    {
         InvokeFunc(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstAttachment, uint attachmentCount, AdamantiumVulkan.Core.Interop.VkColorBlendEquationEXT* pColorBlendEquations)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkColorBlendEquationEXT*, void>)ptr)(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
    }

    public static explicit operator PFN_vkCmdSetColorBlendEquationEXT(void* ptr) => new(ptr);
}


