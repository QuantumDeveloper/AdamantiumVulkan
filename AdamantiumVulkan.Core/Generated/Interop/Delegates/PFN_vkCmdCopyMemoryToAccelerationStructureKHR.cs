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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 21542 Column: 26
public unsafe struct PFN_vkCmdCopyMemoryToAccelerationStructureKHR
{
    public PFN_vkCmdCopyMemoryToAccelerationStructureKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
         InvokeFunc(commandBuffer, pInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, void>)ptr)(commandBuffer, pInfo);
    }

    public static explicit operator PFN_vkCmdCopyMemoryToAccelerationStructureKHR(void* ptr) => new(ptr);
}


