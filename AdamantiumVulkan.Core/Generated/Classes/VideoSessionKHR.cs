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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7981 Column: 1
public unsafe partial class VideoSessionKHR
{
    internal VkVideoSessionKHR_T __Instance;
    public VideoSessionKHR()
    {
    }

    public VideoSessionKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkVideoSessionKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkVideoSessionKHR_T(VideoSessionKHR v)
    {
        return v?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkVideoSessionKHR_T();
    }

    public static implicit operator VideoSessionKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionKHR_T v)
    {
        return new VideoSessionKHR(v);
    }

}


