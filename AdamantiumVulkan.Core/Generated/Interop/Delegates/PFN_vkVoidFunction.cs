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

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 3122 Column: 26
public unsafe struct PFN_vkVoidFunction
{
    public PFN_vkVoidFunction(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<void*>)ptr;
    }

    private delegate* unmanaged<void*> InvokeFunc;

    public void* NativePointer { get; }

    public void* Invoke()
    {
        return InvokeFunc();
    }
    public static void* Invoke(void* ptr)
    {
        return ((delegate* unmanaged<void*>)ptr)();
    }

    public static explicit operator PFN_vkVoidFunction(void* ptr) => new(ptr);
}


