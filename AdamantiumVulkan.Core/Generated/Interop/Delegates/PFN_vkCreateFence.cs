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

public unsafe struct PFN_vkCreateFence
{
    public PFN_vkCreateFence(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkFenceCreateInfo*, VkAllocationCallbacks*, out VkFence_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkFenceCreateInfo*, VkAllocationCallbacks*, out VkFence_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkFence_T pFence)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pFence);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkFence_T pFence)
    {
        return ((delegate* unmanaged<VkDevice_T, VkFenceCreateInfo*, VkAllocationCallbacks*, out VkFence_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pFence);
    }

    public static explicit operator PFN_vkCreateFence(void* ptr) => new(ptr);
}

