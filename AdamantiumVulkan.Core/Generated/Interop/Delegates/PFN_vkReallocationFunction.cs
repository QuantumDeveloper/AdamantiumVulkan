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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 3115 Column: 27
public unsafe struct PFN_vkReallocationFunction
{
    public PFN_vkReallocationFunction(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<void*, void*, ulong, ulong, SystemAllocationScope, void*>)ptr;
    }

    private delegate* unmanaged<void*, void*, ulong, ulong, SystemAllocationScope, void*> InvokeFunc;

    public void* NativePointer { get; }

    public void* Invoke(void* pUserData, void* pOriginal, ulong size, ulong alignment, SystemAllocationScope allocationScope)
    {
        return InvokeFunc(pUserData, pOriginal, size, alignment, allocationScope);
    }
    public static void* Invoke(void* ptr, void* pUserData, void* pOriginal, ulong size, ulong alignment, SystemAllocationScope allocationScope)
    {
        return ((delegate* unmanaged<void*, void*, ulong, ulong, SystemAllocationScope, void*>)ptr)(pUserData, pOriginal, size, alignment, allocationScope);
    }

    public static explicit operator PFN_vkReallocationFunction(void* ptr) => new(ptr);
}


