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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 124 Column: 1
public unsafe partial class DescriptorSet
{
    internal VkDescriptorSet_T __Instance;
    public DescriptorSet()
    {
    }

    public DescriptorSet(AdamantiumVulkan.Core.Interop.VkDescriptorSet_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDescriptorSet_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDescriptorSet_T(DescriptorSet d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDescriptorSet_T();
    }

    public static implicit operator DescriptorSet(AdamantiumVulkan.Core.Interop.VkDescriptorSet_T d)
    {
        return new DescriptorSet(d);
    }

}



