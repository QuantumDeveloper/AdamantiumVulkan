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

public unsafe struct PFN_vkAllocateCommandBuffers
{
    public PFN_vkAllocateCommandBuffers(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkCommandBufferAllocateInfo*, out VkCommandBuffer_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkCommandBufferAllocateInfo*, out VkCommandBuffer_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkCommandBufferAllocateInfo* pAllocateInfo, out VkCommandBuffer_T pCommandBuffers)
    {
        return InvokeFunc(device, pAllocateInfo, out pCommandBuffers);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkCommandBufferAllocateInfo* pAllocateInfo, out VkCommandBuffer_T pCommandBuffers)
    {
        return ((delegate* unmanaged<VkDevice_T, VkCommandBufferAllocateInfo*, out VkCommandBuffer_T, Result>)ptr)(device, pAllocateInfo, out pCommandBuffers);
    }

    public static explicit operator PFN_vkAllocateCommandBuffers(void* ptr) => new(ptr);
}

