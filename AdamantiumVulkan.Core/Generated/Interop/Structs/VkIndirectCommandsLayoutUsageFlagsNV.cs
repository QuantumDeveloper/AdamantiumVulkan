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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 15395 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkIndirectCommandsLayoutUsageFlagsNV
{
    public uint value;

    public static implicit operator uint(VkIndirectCommandsLayoutUsageFlagsNV v)
    {
        return v.value;
    }

    public static implicit operator VkIndirectCommandsLayoutUsageFlagsNV(uint v)
    {
        return new VkIndirectCommandsLayoutUsageFlagsNV(){value = v};
    }

}



