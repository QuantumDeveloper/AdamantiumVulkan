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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7825 Column: 1
public unsafe partial class DisplayKHR
{
    internal VkDisplayKHR_T __Instance;
    public DisplayKHR()
    {
    }

    public DisplayKHR(AdamantiumVulkan.Core.Interop.VkDisplayKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDisplayKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDisplayKHR_T(DisplayKHR d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDisplayKHR_T();
    }

    public static implicit operator DisplayKHR(AdamantiumVulkan.Core.Interop.VkDisplayKHR_T d)
    {
        return new DisplayKHR(d);
    }

}



