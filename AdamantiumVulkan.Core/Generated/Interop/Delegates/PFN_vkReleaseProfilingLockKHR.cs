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

public unsafe struct PFN_vkReleaseProfilingLockKHR
{
    public PFN_vkReleaseProfilingLockKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device)
    {
         InvokeFunc(device);
    }
    public static void Invoke(void* ptr, VkDevice_T device)
    {
         ((delegate* unmanaged<VkDevice_T, void>)ptr)(device);
    }

    public static explicit operator PFN_vkReleaseProfilingLockKHR(void* ptr) => new(ptr);
}


