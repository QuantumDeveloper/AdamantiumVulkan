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

public unsafe struct PFN_vkDestroySurfaceKHR
{
    public PFN_vkDestroySurfaceKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkInstance_T, VkSurfaceKHR_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkInstance_T, VkSurfaceKHR_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkInstance_T instance, VkSurfaceKHR_T surface, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(instance, surface, pAllocator);
    }
    public static void Invoke(void* ptr, VkInstance_T instance, VkSurfaceKHR_T surface, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkInstance_T, VkSurfaceKHR_T, VkAllocationCallbacks*, void>)ptr)(instance, surface, pAllocator);
    }

    public static explicit operator PFN_vkDestroySurfaceKHR(void* ptr) => new(ptr);
}


