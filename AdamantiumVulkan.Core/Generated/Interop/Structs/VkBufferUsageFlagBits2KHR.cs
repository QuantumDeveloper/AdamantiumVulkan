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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 11146 Column: 19
///<summary>
/// Flag bits for VkBufferUsageFlagBits2KHR
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkBufferUsageFlagBits2KHR
{
    public ulong value;

    public static implicit operator ulong(VkBufferUsageFlagBits2KHR v)
    {
        return v.value;
    }

    public static implicit operator VkBufferUsageFlagBits2KHR(ulong v)
    {
        return new VkBufferUsageFlagBits2KHR(){value = v};
    }

}


