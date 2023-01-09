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

public unsafe struct PFN_vkCmdSetExclusiveScissorNV
{
    public PFN_vkCmdSetExclusiveScissorNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
    {
         InvokeFunc(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void>)ptr)(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
    }

    public static explicit operator PFN_vkCmdSetExclusiveScissorNV(void* ptr) => new(ptr);
}


