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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 6893 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkRenderingFlags
{
    public uint value;

    public static implicit operator uint(VkRenderingFlags v)
    {
        return v.value;
    }

    public static implicit operator VkRenderingFlags(uint v)
    {
        return new VkRenderingFlags(){value = v};
    }

}



