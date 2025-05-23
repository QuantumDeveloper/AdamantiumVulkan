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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 15017 Column: 26
public unsafe struct PFN_vkCmdBuildAccelerationStructureNV
{
    public PFN_vkCmdBuildAccelerationStructureNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV*, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkBool32, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV*, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkBool32, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV* pInfo, AdamantiumVulkan.Core.Interop.VkBuffer_T instanceData, VkDeviceSize instanceOffset, VkBool32 update, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T dst, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T src, AdamantiumVulkan.Core.Interop.VkBuffer_T scratch, VkDeviceSize scratchOffset)
    {
         InvokeFunc(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV* pInfo, AdamantiumVulkan.Core.Interop.VkBuffer_T instanceData, VkDeviceSize instanceOffset, VkBool32 update, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T dst, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T src, AdamantiumVulkan.Core.Interop.VkBuffer_T scratch, VkDeviceSize scratchOffset)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV*, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkBool32, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, void>)ptr)(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }

    public static explicit operator PFN_vkCmdBuildAccelerationStructureNV(void* ptr) => new(ptr);
}


