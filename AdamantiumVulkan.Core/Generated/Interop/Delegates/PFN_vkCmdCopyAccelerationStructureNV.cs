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

public unsafe struct PFN_vkCmdCopyAccelerationStructureNV
{
    public PFN_vkCmdCopyAccelerationStructureNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkAccelerationStructureNV_T dst, VkAccelerationStructureNV_T src, CopyAccelerationStructureModeKHR mode)
    {
         InvokeFunc(commandBuffer, dst, src, mode);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkAccelerationStructureNV_T dst, VkAccelerationStructureNV_T src, CopyAccelerationStructureModeKHR mode)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkAccelerationStructureNV_T, VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void>)ptr)(commandBuffer, dst, src, mode);
    }

    public static explicit operator PFN_vkCmdCopyAccelerationStructureNV(void* ptr) => new(ptr);
}

