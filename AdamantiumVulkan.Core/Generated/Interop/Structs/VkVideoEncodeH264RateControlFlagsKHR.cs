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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 8340 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeH264RateControlFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkVideoEncodeH264RateControlFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkVideoEncodeH264RateControlFlagsKHR(uint v)
    {
        return new VkVideoEncodeH264RateControlFlagsKHR(){value = v};
    }

}



