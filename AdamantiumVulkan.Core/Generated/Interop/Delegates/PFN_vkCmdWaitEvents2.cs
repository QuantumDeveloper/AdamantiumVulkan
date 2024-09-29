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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7333 Column: 26
public unsafe struct PFN_vkCmdWaitEvents2
{
    public PFN_vkCmdWaitEvents2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, AdamantiumVulkan.Core.Interop.VkDependencyInfo*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, AdamantiumVulkan.Core.Interop.VkDependencyInfo*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint eventCount, AdamantiumVulkan.Core.Interop.VkEvent_T* pEvents, AdamantiumVulkan.Core.Interop.VkDependencyInfo* pDependencyInfos)
    {
         InvokeFunc(commandBuffer, eventCount, pEvents, pDependencyInfos);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint eventCount, AdamantiumVulkan.Core.Interop.VkEvent_T* pEvents, AdamantiumVulkan.Core.Interop.VkDependencyInfo* pDependencyInfos)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, AdamantiumVulkan.Core.Interop.VkDependencyInfo*, void>)ptr)(commandBuffer, eventCount, pEvents, pDependencyInfos);
    }

    public static explicit operator PFN_vkCmdWaitEvents2(void* ptr) => new(ptr);
}


