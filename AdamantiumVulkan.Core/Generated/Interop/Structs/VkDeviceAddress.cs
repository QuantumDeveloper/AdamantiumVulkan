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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 95 Column: 18
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDeviceAddress
{
    public ulong value;

    public static implicit operator ulong(VkDeviceAddress v)
    {
        return v.value;
    }

    public static implicit operator VkDeviceAddress(ulong v)
    {
        return new VkDeviceAddress(){value = v};
    }

}



