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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 10689 Column: 23
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSubmitFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkSubmitFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkSubmitFlagsKHR(uint v)
    {
        return new VkSubmitFlagsKHR(){value = v};
    }

}



