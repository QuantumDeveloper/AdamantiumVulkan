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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 13247 Column: 1
public unsafe partial class CuModuleNVX
{
    internal VkCuModuleNVX_T __Instance;
    public CuModuleNVX()
    {
    }

    public CuModuleNVX(AdamantiumVulkan.Core.Interop.VkCuModuleNVX_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkCuModuleNVX_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkCuModuleNVX_T(CuModuleNVX c)
    {
        return c?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkCuModuleNVX_T();
    }

    public static implicit operator CuModuleNVX(AdamantiumVulkan.Core.Interop.VkCuModuleNVX_T c)
    {
        return new CuModuleNVX(c);
    }

}



