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

public unsafe struct PFN_vkCreateBuffer
{
    public PFN_vkCreateBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkBufferCreateInfo*, VkAllocationCallbacks*, out VkBuffer_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkBufferCreateInfo*, VkAllocationCallbacks*, out VkBuffer_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBuffer_T pBuffer)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pBuffer);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBuffer_T pBuffer)
    {
        return ((delegate* unmanaged<VkDevice_T, VkBufferCreateInfo*, VkAllocationCallbacks*, out VkBuffer_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pBuffer);
    }

    public static explicit operator PFN_vkCreateBuffer(void* ptr) => new(ptr);
}


