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

public unsafe struct PFN_vkDestroyPrivateDataSlot
{
    public PFN_vkDestroyPrivateDataSlot(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkPrivateDataSlot_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkPrivateDataSlot_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkPrivateDataSlot_T privateDataSlot, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, privateDataSlot, pAllocator);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkPrivateDataSlot_T privateDataSlot, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkDevice_T, VkPrivateDataSlot_T, VkAllocationCallbacks*, void>)ptr)(device, privateDataSlot, pAllocator);
    }

    public static explicit operator PFN_vkDestroyPrivateDataSlot(void* ptr) => new(ptr);
}


