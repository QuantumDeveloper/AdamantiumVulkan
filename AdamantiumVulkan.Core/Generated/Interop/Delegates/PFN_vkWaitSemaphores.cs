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

public unsafe struct PFN_vkWaitSemaphores
{
    public PFN_vkWaitSemaphores(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkSemaphoreWaitInfo*, ulong, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkSemaphoreWaitInfo*, ulong, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
    {
        return InvokeFunc(device, pWaitInfo, timeout);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
    {
        return ((delegate* unmanaged<VkDevice_T, VkSemaphoreWaitInfo*, ulong, Result>)ptr)(device, pWaitInfo, timeout);
    }

    public static explicit operator PFN_vkWaitSemaphores(void* ptr) => new(ptr);
}


