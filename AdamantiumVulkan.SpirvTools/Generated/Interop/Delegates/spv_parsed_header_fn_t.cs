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
using AdamantiumVulkan.SpirvTools;

namespace AdamantiumVulkan.SpirvTools.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 946 Column: 24
///<summary>
/// A pointer to a function that accepts a parsed SPIR-V header. The integer arguments are the 32-bit words from the header, as specified in SPIR-V 1.0 Section 2.3 Table 1. The function should return SPV_SUCCESS if parsing should continue.
///</summary>
public unsafe struct spv_parsed_header_fn_t
{
    public spv_parsed_header_fn_t(void* ptr)
    {
        NativePointer = ptr;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            InvokeStdcall = (delegate* unmanaged[Stdcall]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t>)ptr;
            InvokeCdecl = default;
        }
        else
        {
            InvokeCdecl = (delegate* unmanaged[Cdecl]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t>)ptr;
            InvokeStdcall = default;
        }
    }

    private delegate* unmanaged[Stdcall]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t> InvokeStdcall;

    private delegate* unmanaged[Cdecl]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t> InvokeCdecl;

    public void* NativePointer { get; }

    public spv_result_t Invoke(void* user_data, spv_endianness_t endian, uint magic, uint version, uint generator, uint id_bound, uint reserved)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return InvokeStdcall(user_data, endian, magic, version, generator, id_bound, reserved);
        }
        else
        {
            return InvokeCdecl(user_data, endian, magic, version, generator, id_bound, reserved);
        }
    }

    public static spv_result_t Invoke(void* ptr, void* user_data, spv_endianness_t endian, uint magic, uint version, uint generator, uint id_bound, uint reserved)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return ((delegate* unmanaged[Stdcall]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t>)ptr)(user_data, endian, magic, version, generator, id_bound, reserved);
        }
        else
        {
            return ((delegate* unmanaged[Cdecl]<void*, spv_endianness_t, uint, uint, uint, uint, uint, spv_result_t>)ptr)(user_data, endian, magic, version, generator, id_bound, reserved);
        }
    }

    public static explicit operator spv_parsed_header_fn_t(void* ptr) => new(ptr);
}


