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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6706 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSubmitFlags
{
    public uint value;

    public static implicit operator uint(VkSubmitFlags v)
    {
        return v.value;
    }

    public static implicit operator VkSubmitFlags(uint v)
    {
        return new VkSubmitFlags(){value = v};
    }

}



