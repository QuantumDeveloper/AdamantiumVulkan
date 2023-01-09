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

public unsafe struct PFN_vkResetCommandBuffer
{
    public PFN_vkResetCommandBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkCommandBufferResetFlags, Result>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkCommandBufferResetFlags, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkCommandBuffer_T commandBuffer, VkCommandBufferResetFlags flags)
    {
        return InvokeFunc(commandBuffer, flags);
    }
    public static Result Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkCommandBufferResetFlags flags)
    {
        return ((delegate* unmanaged<VkCommandBuffer_T, VkCommandBufferResetFlags, Result>)ptr)(commandBuffer, flags);
    }

    public static explicit operator PFN_vkResetCommandBuffer(void* ptr) => new(ptr);
}

