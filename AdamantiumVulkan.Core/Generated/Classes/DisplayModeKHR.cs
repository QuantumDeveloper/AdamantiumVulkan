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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 8781 Column: 1
public unsafe partial class DisplayModeKHR
{
    internal VkDisplayModeKHR_T __Instance;
    public DisplayModeKHR()
    {
    }

    public DisplayModeKHR(AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDisplayModeKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T(DisplayModeKHR d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T();
    }

    public static implicit operator DisplayModeKHR(AdamantiumVulkan.Core.Interop.VkDisplayModeKHR_T d)
    {
        return new DisplayModeKHR(d);
    }

}



