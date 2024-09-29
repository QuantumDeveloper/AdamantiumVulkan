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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 116 Column: 1
public unsafe partial class Pipeline
{
    internal VkPipeline_T __Instance;
    public Pipeline()
    {
    }

    public Pipeline(AdamantiumVulkan.Core.Interop.VkPipeline_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkPipeline_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkPipeline_T(Pipeline p)
    {
        return p?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkPipeline_T();
    }

    public static implicit operator Pipeline(AdamantiumVulkan.Core.Interop.VkPipeline_T p)
    {
        return new Pipeline(p);
    }

}



