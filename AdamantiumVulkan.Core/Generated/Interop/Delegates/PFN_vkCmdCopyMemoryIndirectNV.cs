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

public unsafe struct PFN_vkCmdCopyMemoryIndirectNV
{
    public PFN_vkCmdCopyMemoryIndirectNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkDeviceAddress, uint, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkDeviceAddress, uint, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkDeviceAddress copyBufferAddress, uint copyCount, uint stride)
    {
         InvokeFunc(commandBuffer, copyBufferAddress, copyCount, stride);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkDeviceAddress copyBufferAddress, uint copyCount, uint stride)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkDeviceAddress, uint, uint, void>)ptr)(commandBuffer, copyBufferAddress, copyCount, stride);
    }

    public static explicit operator PFN_vkCmdCopyMemoryIndirectNV(void* ptr) => new(ptr);
}

