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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 14818 Column: 28
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkGeometryFlagsNV
{
    public uint value;

    public static implicit operator uint(VkGeometryFlagsNV v)
    {
        return v.value;
    }

    public static implicit operator VkGeometryFlagsNV(uint v)
    {
        return new VkGeometryFlagsNV(){value = v};
    }

}



