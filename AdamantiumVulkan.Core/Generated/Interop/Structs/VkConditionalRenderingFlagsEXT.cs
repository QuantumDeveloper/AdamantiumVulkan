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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 13505 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkConditionalRenderingFlagsEXT
{
    public uint value;

    public static implicit operator uint(VkConditionalRenderingFlagsEXT v)
    {
        return v.value;
    }

    public static implicit operator VkConditionalRenderingFlagsEXT(uint v)
    {
        return new VkConditionalRenderingFlagsEXT(){value = v};
    }

}



