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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 3011 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkQueryControlFlags
{
    public uint value;

    public static implicit operator uint(VkQueryControlFlags v)
    {
        return v.value;
    }

    public static implicit operator VkQueryControlFlags(uint v)
    {
        return new VkQueryControlFlags(){value = v};
    }

}



