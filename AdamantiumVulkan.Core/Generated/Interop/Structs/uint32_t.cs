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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vk_platform.h Line: 72 Column: 34
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct uint32_t
{
    public uint value;

    public static implicit operator uint(uint32_t u)
    {
        return u.value;
    }

    public static implicit operator uint32_t(uint u)
    {
        return new uint32_t(){value = u};
    }

}



