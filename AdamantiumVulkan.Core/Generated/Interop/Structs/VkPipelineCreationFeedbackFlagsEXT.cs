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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 13873 Column: 41
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPipelineCreationFeedbackFlagsEXT
{
    public uint value;

    public static implicit operator uint(VkPipelineCreationFeedbackFlagsEXT v)
    {
        return v.value;
    }

    public static implicit operator VkPipelineCreationFeedbackFlagsEXT(uint v)
    {
        return new VkPipelineCreationFeedbackFlagsEXT(){value = v};
    }

}



