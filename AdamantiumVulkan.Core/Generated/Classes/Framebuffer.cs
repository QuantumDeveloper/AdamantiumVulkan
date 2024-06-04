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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 122 Column: 1
public unsafe partial class Framebuffer
{
    internal VkFramebuffer_T __Instance;
    public Framebuffer()
    {
    }

    public Framebuffer(AdamantiumVulkan.Core.Interop.VkFramebuffer_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkFramebuffer_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkFramebuffer_T(Framebuffer f)
    {
        return f?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkFramebuffer_T();
    }

    public static implicit operator Framebuffer(AdamantiumVulkan.Core.Interop.VkFramebuffer_T f)
    {
        return new Framebuffer(f);
    }

}



