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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 14817 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkGeometryFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkGeometryFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkGeometryFlagsKHR(uint v)
    {
        return new VkGeometryFlagsKHR(){value = v};
    }

}



