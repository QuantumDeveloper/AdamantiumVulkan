// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.MacOS.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_macos.h Line: 26 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkMacOSSurfaceCreateFlagsMVK
{
    public uint value;

    public static implicit operator uint(VkMacOSSurfaceCreateFlagsMVK v)
    {
        return v.value;
    }

    public static implicit operator VkMacOSSurfaceCreateFlagsMVK(uint v)
    {
        return new VkMacOSSurfaceCreateFlagsMVK(){value = v};
    }

}



