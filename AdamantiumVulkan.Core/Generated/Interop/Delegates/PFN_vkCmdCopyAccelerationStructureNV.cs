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
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T dst, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T src, CopyAccelerationStructureModeKHR mode)
    {
         InvokeFunc(commandBuffer, dst, src, mode);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T dst, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T src, CopyAccelerationStructureModeKHR mode)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, CopyAccelerationStructureModeKHR, void>)ptr)(commandBuffer, dst, src, mode);
    }

    public static explicit operator PFN_vkCmdCopyAccelerationStructureNV(void* ptr) => new(ptr);
}


