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

public unsafe struct PFN_vkCmdBuildAccelerationStructureNV
{
    public PFN_vkCmdBuildAccelerationStructureNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureInfoNV*, VkBuffer_T, VkDeviceSize, VkBool32, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, VkBuffer_T, VkDeviceSize, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureInfoNV*, VkBuffer_T, VkDeviceSize, VkBool32, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, VkBuffer_T, VkDeviceSize, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer_T instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV_T dst, VkAccelerationStructureNV_T src, VkBuffer_T scratch, VkDeviceSize scratchOffset)
    {
         InvokeFunc(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer_T instanceData, VkDeviceSize instanceOffset, VkBool32 update, VkAccelerationStructureNV_T dst, VkAccelerationStructureNV_T src, VkBuffer_T scratch, VkDeviceSize scratchOffset)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureInfoNV*, VkBuffer_T, VkDeviceSize, VkBool32, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, VkBuffer_T, VkDeviceSize, void>)ptr)(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
    }

    public static explicit operator PFN_vkCmdBuildAccelerationStructureNV(void* ptr) => new(ptr);
}

