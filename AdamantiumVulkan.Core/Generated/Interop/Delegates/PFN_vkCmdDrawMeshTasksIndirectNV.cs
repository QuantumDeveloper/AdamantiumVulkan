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

public unsafe struct PFN_vkCmdDrawMeshTasksIndirectNV
{
    public PFN_vkCmdDrawMeshTasksIndirectNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkBuffer_T, VkDeviceSize, uint, uint, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkBuffer_T, VkDeviceSize, uint, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkBuffer_T buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
         InvokeFunc(commandBuffer, buffer, offset, drawCount, stride);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkBuffer_T buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkBuffer_T, VkDeviceSize, uint, uint, void>)ptr)(commandBuffer, buffer, offset, drawCount, stride);
    }

    public static explicit operator PFN_vkCmdDrawMeshTasksIndirectNV(void* ptr) => new(ptr);
}


