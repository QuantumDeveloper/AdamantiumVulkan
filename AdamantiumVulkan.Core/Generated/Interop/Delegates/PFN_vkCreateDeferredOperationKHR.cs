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

public unsafe struct PFN_vkCreateDeferredOperationKHR
{
    public PFN_vkCreateDeferredOperationKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkAllocationCallbacks*, out VkDeferredOperationKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkAllocationCallbacks*, out VkDeferredOperationKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkAllocationCallbacks* pAllocator, out VkDeferredOperationKHR_T pDeferredOperation)
    {
        return InvokeFunc(device, pAllocator, out pDeferredOperation);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkAllocationCallbacks* pAllocator, out VkDeferredOperationKHR_T pDeferredOperation)
    {
        return ((delegate* unmanaged<VkDevice_T, VkAllocationCallbacks*, out VkDeferredOperationKHR_T, Result>)ptr)(device, pAllocator, out pDeferredOperation);
    }

    public static explicit operator PFN_vkCreateDeferredOperationKHR(void* ptr) => new(ptr);
}

