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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 20902 Column: 26
public unsafe struct PFN_vkCmdBuildAccelerationStructuresKHR
{
    public PFN_vkCmdBuildAccelerationStructuresKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildRangeInfoKHR**, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildRangeInfoKHR**, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint infoCount, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR* pInfos, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
    {
         InvokeFunc(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint infoCount, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR* pInfos, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildRangeInfoKHR**, void>)ptr)(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
    }

    public static explicit operator PFN_vkCmdBuildAccelerationStructuresKHR(void* ptr) => new(ptr);
}


