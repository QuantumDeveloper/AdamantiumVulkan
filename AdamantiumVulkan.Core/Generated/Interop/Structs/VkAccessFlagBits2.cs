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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6631 Column: 19
///<summary>
/// Flag bits for VkAccessFlagBits2
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkAccessFlagBits2
{
    public ulong value;

    public static implicit operator ulong(VkAccessFlagBits2 v)
    {
        return v.value;
    }

    public static implicit operator VkAccessFlagBits2(ulong v)
    {
        return new VkAccessFlagBits2(){value = v};
    }

}



