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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 15024 Column: 26
public unsafe struct PFN_vkCmdWriteAccelerationStructuresPropertiesNV
{
    public PFN_vkCmdWriteAccelerationStructuresPropertiesNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T*, QueryType, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T*, QueryType, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint accelerationStructureCount, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T* pAccelerationStructures, QueryType queryType, AdamantiumVulkan.Core.Interop.VkQueryPool_T queryPool, uint firstQuery)
    {
         InvokeFunc(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint accelerationStructureCount, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T* pAccelerationStructures, QueryType queryType, AdamantiumVulkan.Core.Interop.VkQueryPool_T queryPool, uint firstQuery)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T*, QueryType, AdamantiumVulkan.Core.Interop.VkQueryPool_T, uint, void>)ptr)(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
    }

    public static explicit operator PFN_vkCmdWriteAccelerationStructuresPropertiesNV(void* ptr) => new(ptr);
}


