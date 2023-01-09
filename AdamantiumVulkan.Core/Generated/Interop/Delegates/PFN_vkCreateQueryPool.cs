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

public unsafe struct PFN_vkCreateQueryPool
{
    public PFN_vkCreateQueryPool(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, out VkQueryPool_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, out VkQueryPool_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkQueryPool_T pQueryPool)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pQueryPool);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkQueryPool_T pQueryPool)
    {
        return ((delegate* unmanaged<VkDevice_T, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, out VkQueryPool_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pQueryPool);
    }

    public static explicit operator PFN_vkCreateQueryPool(void* ptr) => new(ptr);
}


