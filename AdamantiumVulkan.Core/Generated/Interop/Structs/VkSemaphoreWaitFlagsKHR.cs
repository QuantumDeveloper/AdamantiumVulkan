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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 11023 Column: 30
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSemaphoreWaitFlagsKHR
{
    public uint value;

    public static implicit operator uint(VkSemaphoreWaitFlagsKHR v)
    {
        return v.value;
    }

    public static implicit operator VkSemaphoreWaitFlagsKHR(uint v)
    {
        return new VkSemaphoreWaitFlagsKHR(){value = v};
    }

}



