// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Spirv.Cross.Interop;

// File: C:\VulkanSDK\1.3.275.0\Include\spirv_cross\spirv_cross_c.h Line: 160 Column: 23
///<summary>
/// Be compatible with non-C99 compilers, which do not have stdbool. Only recent MSVC compilers supports this for example, and ideally SPIRV-Cross should be linkable from a wide range of compilers in its C wrapper.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SpvcBool
{
    public byte value;

    public static implicit operator byte(SpvcBool s)
    {
        return s.value;
    }

    public static implicit operator SpvcBool(byte s)
    {
        return new SpvcBool(){value = s};
    }

}



