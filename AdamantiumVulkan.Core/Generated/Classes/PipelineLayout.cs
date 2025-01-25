// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 119 Column: 1
public unsafe partial class PipelineLayout
{
    internal VkPipelineLayout_T __Instance;
    public PipelineLayout()
    {
    }

    public PipelineLayout(AdamantiumVulkan.Core.Interop.VkPipelineLayout_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkPipelineLayout_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkPipelineLayout_T(PipelineLayout p)
    {
        return p?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkPipelineLayout_T();
    }

    public static implicit operator PipelineLayout(AdamantiumVulkan.Core.Interop.VkPipelineLayout_T p)
    {
        return new PipelineLayout(p);
    }

}



