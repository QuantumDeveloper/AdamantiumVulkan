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
public unsafe partial struct VkOpticalFlowGridSizeFlagsNV
{
    public uint value;

    public static implicit operator uint(VkOpticalFlowGridSizeFlagsNV v)
    {
        return v.value;
    }

    public static implicit operator VkOpticalFlowGridSizeFlagsNV(uint v)
    {
        return new VkOpticalFlowGridSizeFlagsNV(){value = v};
    }

}



