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

// File: C:\VulkanSDK\1.4.309.0\Include\spirv_cross\spirv_cross_c.h Line: 593 Column: 18
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SpvcHlslBindingFlags
{
    public uint value;

    public static implicit operator uint(SpvcHlslBindingFlags s)
    {
        return s.value;
    }

    public static implicit operator SpvcHlslBindingFlags(uint s)
    {
        return new SpvcHlslBindingFlags(){value = s};
    }

}



