// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Windows.Interop;

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_win32.h Line: 26 Column: 17
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkWin32SurfaceCreateFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkWin32SurfaceCreateFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkWin32SurfaceCreateFlagsKHR(uint v)
    {
        return new VkWin32SurfaceCreateFlagsKHR(){value = v};
    }

}



