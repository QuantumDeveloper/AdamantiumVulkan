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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 16530 Column: 1
public unsafe partial class IndirectCommandsLayoutNV
{
    internal VkIndirectCommandsLayoutNV_T __Instance;
    public IndirectCommandsLayoutNV()
    {
    }

    public IndirectCommandsLayoutNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkIndirectCommandsLayoutNV_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T(IndirectCommandsLayoutNV i)
    {
        return i?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T();
    }

    public static implicit operator IndirectCommandsLayoutNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutNV_T i)
    {
        return new IndirectCommandsLayoutNV(i);
    }

}



