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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 6894 Column: 19
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkFormatFeatureFlags2
{
    public ulong value;

    public static implicit operator ulong(VkFormatFeatureFlags2 v)
    {
        return v.value;
    }

    public static implicit operator VkFormatFeatureFlags2(ulong v)
    {
        return new VkFormatFeatureFlags2(){value = v};
    }

}



