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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 12850 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDebugReportFlagsEXT
{
    public uint value;

    public static implicit operator uint(VkDebugReportFlagsEXT v)
    {
        return v.value;
    }

    public static implicit operator VkDebugReportFlagsEXT(uint v)
    {
        return new VkDebugReportFlagsEXT(){value = v};
    }

}



