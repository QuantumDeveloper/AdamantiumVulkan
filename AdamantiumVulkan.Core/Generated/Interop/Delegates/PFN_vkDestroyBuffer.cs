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

public unsafe struct PFN_vkDestroyBuffer
{
    public PFN_vkDestroyBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, buffer, pAllocator);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr)(device, buffer, pAllocator);
    }

    public static explicit operator PFN_vkDestroyBuffer(void* ptr) => new(ptr);
}


