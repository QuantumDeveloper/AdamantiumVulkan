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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 20910 Column: 26
public unsafe struct PFN_vkCmdCopyAccelerationStructureToMemoryKHR
{
    public PFN_vkCmdCopyAccelerationStructureToMemoryKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureToMemoryInfoKHR*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureToMemoryInfoKHR*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
    {
         InvokeFunc(commandBuffer, pInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureToMemoryInfoKHR*, void>)ptr)(commandBuffer, pInfo);
    }

    public static explicit operator PFN_vkCmdCopyAccelerationStructureToMemoryKHR(void* ptr) => new(ptr);
}


