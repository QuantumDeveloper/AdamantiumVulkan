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

public unsafe struct PFN_vkFreeMemory
{
    public PFN_vkFreeMemory(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkDeviceMemory_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkDeviceMemory_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkDeviceMemory_T memory, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, memory, pAllocator);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkDeviceMemory_T memory, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkDevice_T, VkDeviceMemory_T, VkAllocationCallbacks*, void>)ptr)(device, memory, pAllocator);
    }

    public static explicit operator PFN_vkFreeMemory(void* ptr) => new(ptr);
}

