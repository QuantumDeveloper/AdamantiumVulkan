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
public unsafe partial struct VkFormatFeatureFlagBits2KHR
{
    public ulong value;

    public static implicit operator ulong(VkFormatFeatureFlagBits2KHR v)
    {
        return v.value;
    }

    public static implicit operator VkFormatFeatureFlagBits2KHR(ulong v)
    {
        return new VkFormatFeatureFlagBits2KHR(){value = v};
    }

}



