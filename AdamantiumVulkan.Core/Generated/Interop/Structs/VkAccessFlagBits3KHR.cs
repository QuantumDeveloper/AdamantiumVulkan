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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 12846 Column: 19
///<summary>
/// Flag bits for VkAccessFlagBits3KHR
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkAccessFlagBits3KHR
{
    public ulong value;

    public static implicit operator ulong(VkAccessFlagBits3KHR v)
    {
        return v.value;
    }

    public static implicit operator VkAccessFlagBits3KHR(ulong v)
    {
        return new VkAccessFlagBits3KHR(){value = v};
    }

}



