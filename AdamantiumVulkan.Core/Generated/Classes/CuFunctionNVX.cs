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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 13124 Column: 1
public unsafe partial class CuFunctionNVX
{
    internal VkCuFunctionNVX_T __Instance;
    public CuFunctionNVX()
    {
    }

    public CuFunctionNVX(AdamantiumVulkan.Core.Interop.VkCuFunctionNVX_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkCuFunctionNVX_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkCuFunctionNVX_T(CuFunctionNVX c)
    {
        return c?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkCuFunctionNVX_T();
    }

    public static implicit operator CuFunctionNVX(AdamantiumVulkan.Core.Interop.VkCuFunctionNVX_T c)
    {
        return new CuFunctionNVX(c);
    }

}



