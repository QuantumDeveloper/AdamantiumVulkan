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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 11627 Column: 31
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineStageFlags2KHR
{
    public ulong value;

    public static implicit operator ulong(VkPipelineStageFlags2KHR v)
    {
        return v.value;
    }

    public static implicit operator VkPipelineStageFlags2KHR(ulong v)
    {
        return new VkPipelineStageFlags2KHR(){value = v};
    }

}



