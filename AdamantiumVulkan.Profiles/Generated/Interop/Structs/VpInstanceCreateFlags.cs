// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Profiles.Interop;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VpInstanceCreateFlags
{
    public uint value;

    public static implicit operator uint(VpInstanceCreateFlags v)
    {
        return v.value;
    }

    public static implicit operator VpInstanceCreateFlags(uint v)
    {
        return new VpInstanceCreateFlags(){value = v};
    }

}



