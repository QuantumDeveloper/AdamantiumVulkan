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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 5097 Column: 1
public unsafe partial class DescriptorUpdateTemplate
{
    internal VkDescriptorUpdateTemplate_T __Instance;
    public DescriptorUpdateTemplate()
    {
    }

    public DescriptorUpdateTemplate(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplate_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDescriptorUpdateTemplate_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplate_T(DescriptorUpdateTemplate d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplate_T();
    }

    public static implicit operator DescriptorUpdateTemplate(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplate_T d)
    {
        return new DescriptorUpdateTemplate(d);
    }

}



