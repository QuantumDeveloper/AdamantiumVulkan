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

namespace AdamantiumVulkan.Spirv.Cross.Interop;

// File: C:\VulkanSDK\1.3.283.0\Include\spirv_cross\spirv_cross_c.h Line: 754 Column: 16
///<summary>
/// Get notified in a callback when an error triggers. Useful for debugging.
///</summary>
public unsafe struct ErrorCallback
{
    public ErrorCallback(void* ptr)
    {
        NativePointer = ptr;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            InvokeStdcall = (delegate* unmanaged[Stdcall]<void*, out sbyte, void>)ptr;
            InvokeCdecl = default;
        }
        else
        {
            InvokeCdecl = (delegate* unmanaged[Cdecl]<void*, out sbyte, void>)ptr;
            InvokeStdcall = default;
        }
    }

    private delegate* unmanaged[Stdcall]<void*, out sbyte, void> InvokeStdcall;

    private delegate* unmanaged[Cdecl]<void*, out sbyte, void> InvokeCdecl;

    public void* NativePointer { get; }

    public void Invoke(void* userdata, out sbyte error)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
             InvokeStdcall(userdata, out error);
        }
        else
        {
             InvokeCdecl(userdata, out error);
        }
    }

    public static void Invoke(void* ptr, void* userdata, out sbyte error)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
             ((delegate* unmanaged[Stdcall]<void*, out sbyte, void>)ptr)(userdata, out error);
        }
        else
        {
             ((delegate* unmanaged[Cdecl]<void*, out sbyte, void>)ptr)(userdata, out error);
        }
    }

    public static explicit operator ErrorCallback(void* ptr) => new(ptr);
}


