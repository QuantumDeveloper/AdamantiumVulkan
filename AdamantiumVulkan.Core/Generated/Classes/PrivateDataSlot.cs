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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6518 Column: 1
public unsafe partial class PrivateDataSlot
{
    internal VkPrivateDataSlot_T __Instance;
    public PrivateDataSlot()
    {
    }

    public PrivateDataSlot(AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkPrivateDataSlot_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T(PrivateDataSlot p)
    {
        return p?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T();
    }

    public static implicit operator PrivateDataSlot(AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T p)
    {
        return new PrivateDataSlot(p);
    }

}



