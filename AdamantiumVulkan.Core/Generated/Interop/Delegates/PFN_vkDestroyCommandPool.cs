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

public unsafe struct PFN_vkDestroyCommandPool
{
    public PFN_vkDestroyCommandPool(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkCommandPool_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkCommandPool_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkCommandPool_T commandPool, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, commandPool, pAllocator);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkCommandPool_T commandPool, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkDevice_T, VkCommandPool_T, VkAllocationCallbacks*, void>)ptr)(device, commandPool, pAllocator);
    }

    public static explicit operator PFN_vkDestroyCommandPool(void* ptr) => new(ptr);
}


