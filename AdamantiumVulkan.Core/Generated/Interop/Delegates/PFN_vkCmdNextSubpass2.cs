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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 6642 Column: 26
public unsafe struct PFN_vkCmdNextSubpass2
{
    public PFN_vkCmdNextSubpass2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassEndInfo*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassEndInfo*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo* pSubpassBeginInfo, AdamantiumVulkan.Core.Interop.VkSubpassEndInfo* pSubpassEndInfo)
    {
         InvokeFunc(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo* pSubpassBeginInfo, AdamantiumVulkan.Core.Interop.VkSubpassEndInfo* pSubpassEndInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo*, AdamantiumVulkan.Core.Interop.VkSubpassEndInfo*, void>)ptr)(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
    }

    public static explicit operator PFN_vkCmdNextSubpass2(void* ptr) => new(ptr);
}


