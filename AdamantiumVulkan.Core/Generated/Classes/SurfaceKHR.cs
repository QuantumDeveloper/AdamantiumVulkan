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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 7513 Column: 1
public unsafe partial class SurfaceKHR
{
    internal VkSurfaceKHR_T __Instance;
    public SurfaceKHR()
    {
    }

    public SurfaceKHR(AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkSurfaceKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T(SurfaceKHR s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T();
    }

    public static implicit operator SurfaceKHR(AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T s)
    {
        return new SurfaceKHR(s);
    }

}



