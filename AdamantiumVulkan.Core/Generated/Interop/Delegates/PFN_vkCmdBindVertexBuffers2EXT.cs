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

public unsafe struct PFN_vkCmdBindVertexBuffers2EXT
{
    public PFN_vkCmdBindVertexBuffers2EXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstBinding, uint bindingCount, VkBuffer_T* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
         InvokeFunc(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstBinding, uint bindingCount, VkBuffer_T* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkBuffer_T*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void>)ptr)(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }

    public static explicit operator PFN_vkCmdBindVertexBuffers2EXT(void* ptr) => new(ptr);
}


