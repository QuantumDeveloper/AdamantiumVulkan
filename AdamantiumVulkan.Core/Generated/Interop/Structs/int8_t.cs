// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Interop;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct int8_t
{
    public sbyte value;

    public static implicit operator sbyte(int8_t i)
    {
        return i.value;
    }

    public static implicit operator int8_t(sbyte i)
    {
        return new int8_t(){value = i};
    }

}



