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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 9989 Column: 38
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkExternalMemoryFeatureFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkExternalMemoryFeatureFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkExternalMemoryFeatureFlagsKHR(uint v)
    {
        return new VkExternalMemoryFeatureFlagsKHR(){value = v};
    }

}



