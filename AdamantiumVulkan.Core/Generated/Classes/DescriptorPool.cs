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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 125 Column: 1
public unsafe partial class DescriptorPool
{
    internal VkDescriptorPool_T __Instance;
    public DescriptorPool()
    {
    }

    public DescriptorPool(AdamantiumVulkan.Core.Interop.VkDescriptorPool_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDescriptorPool_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDescriptorPool_T(DescriptorPool d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDescriptorPool_T();
    }

    public static implicit operator DescriptorPool(AdamantiumVulkan.Core.Interop.VkDescriptorPool_T d)
    {
        return new DescriptorPool(d);
    }

}



