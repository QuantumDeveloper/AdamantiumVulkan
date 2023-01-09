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

public unsafe struct PFN_vkCmdSetScissor
{
    public PFN_vkCmdSetScissor(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
    {
         InvokeFunc(commandBuffer, firstScissor, scissorCount, pScissors);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkRect2D*, void>)ptr)(commandBuffer, firstScissor, scissorCount, pScissors);
    }

    public static explicit operator PFN_vkCmdSetScissor(void* ptr) => new(ptr);
}


