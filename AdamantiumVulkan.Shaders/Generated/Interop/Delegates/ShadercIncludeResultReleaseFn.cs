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

namespace AdamantiumVulkan.Shaders.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\shaderc\shaderc.h Line: 380 Column: 16
///<summary>
/// An includer callback type for destroying an include result.
///</summary>
public unsafe struct ShadercIncludeResultReleaseFn
{
    public ShadercIncludeResultReleaseFn(void* ptr)
    {
        NativePointer = ptr;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            InvokeStdcall = (delegate* unmanaged[Stdcall]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void>)ptr;
            InvokeCdecl = default;
        }
        else
        {
            InvokeCdecl = (delegate* unmanaged[Cdecl]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void>)ptr;
            InvokeStdcall = default;
        }
    }

    private delegate* unmanaged[Stdcall]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void> InvokeStdcall;

    private delegate* unmanaged[Cdecl]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void> InvokeCdecl;

    public void* NativePointer { get; }

    public void Invoke(void* user_data, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult* include_result)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
             InvokeStdcall(user_data, include_result);
        }
        else
        {
             InvokeCdecl(user_data, include_result);
        }
    }

    public static void Invoke(void* ptr, void* user_data, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult* include_result)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
             ((delegate* unmanaged[Stdcall]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void>)ptr)(user_data, include_result);
        }
        else
        {
             ((delegate* unmanaged[Cdecl]<void*, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult*, void>)ptr)(user_data, include_result);
        }
    }

    public static explicit operator ShadercIncludeResultReleaseFn(void* ptr) => new(ptr);
}


