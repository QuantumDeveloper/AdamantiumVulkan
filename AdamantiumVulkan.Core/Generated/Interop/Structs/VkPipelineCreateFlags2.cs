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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 7792 Column: 19
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineCreateFlags2
{
    public ulong value;

    public static implicit operator ulong(VkPipelineCreateFlags2 v)
    {
        return v.value;
    }

    public static implicit operator VkPipelineCreateFlags2(ulong v)
    {
        return new VkPipelineCreateFlags2(){value = v};
    }

}



