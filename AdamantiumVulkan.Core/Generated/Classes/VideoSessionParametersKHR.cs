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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7982 Column: 1
public unsafe partial class VideoSessionParametersKHR
{
    internal VkVideoSessionParametersKHR_T __Instance;
    public VideoSessionParametersKHR()
    {
    }

    public VideoSessionParametersKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkVideoSessionParametersKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T(VideoSessionParametersKHR v)
    {
        return v?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T();
    }

    public static implicit operator VideoSessionParametersKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T v)
    {
        return new VideoSessionParametersKHR(v);
    }

}



