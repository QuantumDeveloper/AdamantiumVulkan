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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6548 Column: 19
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineStageFlags2
{
    public ulong value;

    public static implicit operator ulong(VkPipelineStageFlags2 v)
    {
        return v.value;
    }

    public static implicit operator VkPipelineStageFlags2(ulong v)
    {
        return new VkPipelineStageFlags2(){value = v};
    }

}



