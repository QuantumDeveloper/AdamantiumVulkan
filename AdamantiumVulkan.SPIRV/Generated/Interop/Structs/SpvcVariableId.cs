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

///<summary>
/// Maps to a SPIRVariable.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SpvcVariableId
{
    public uint value;

    public static implicit operator uint(SpvcVariableId s)
    {
        return s.value;
    }

    public static implicit operator SpvcVariableId(uint s)
    {
        return new SpvcVariableId(){value = s};
    }

}


