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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 20943 Column: 1
public unsafe partial class IndirectExecutionSetEXT
{
    internal VkIndirectExecutionSetEXT_T __Instance;
    public IndirectExecutionSetEXT()
    {
    }

    public IndirectExecutionSetEXT(AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkIndirectExecutionSetEXT_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T(IndirectExecutionSetEXT i)
    {
        return i?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T();
    }

    public static implicit operator IndirectExecutionSetEXT(AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T i)
    {
        return new IndirectExecutionSetEXT(i);
    }

}



