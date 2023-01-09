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

public unsafe struct PFN_vkCmdEndQuery
{
    public PFN_vkCmdEndQuery(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkQueryPool_T, uint, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkQueryPool_T, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkQueryPool_T queryPool, uint query)
    {
         InvokeFunc(commandBuffer, queryPool, query);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkQueryPool_T queryPool, uint query)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkQueryPool_T, uint, void>)ptr)(commandBuffer, queryPool, query);
    }

    public static explicit operator PFN_vkCmdEndQuery(void* ptr) => new(ptr);
}


