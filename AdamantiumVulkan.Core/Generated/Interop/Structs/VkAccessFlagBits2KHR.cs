// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core.Interop;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkAccessFlagBits2KHR
{
    public ulong value;

    public static implicit operator ulong(VkAccessFlagBits2KHR v)
    {
        return v.value;
    }

    public static implicit operator VkAccessFlagBits2KHR(ulong v)
    {
        return new VkAccessFlagBits2KHR(){value = v};
    }

}


