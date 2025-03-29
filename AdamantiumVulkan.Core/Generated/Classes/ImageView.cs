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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 116 Column: 1
public unsafe partial class ImageView
{
    internal VkImageView_T __Instance;
    public ImageView()
    {
    }

    public ImageView(AdamantiumVulkan.Core.Interop.VkImageView_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkImageView_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkImageView_T(ImageView i)
    {
        return i?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkImageView_T();
    }

    public static implicit operator ImageView(AdamantiumVulkan.Core.Interop.VkImageView_T i)
    {
        return new ImageView(i);
    }

}



