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
using AdamantiumVulkan.Spirv.Cross.Interop;

namespace AdamantiumVulkan.Spirv.Cross;

// File: C:\VulkanSDK\1.3.283.0\Include\spirv_cross\spirv_cross_c.h Line: 81 Column: 34
public unsafe partial class SpirvSet
{
    internal SpvcSetS __Instance;
    public SpirvSet()
    {
    }

    public SpirvSet(AdamantiumVulkan.Spirv.Cross.Interop.SpvcSetS __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly SpvcSetS GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Spirv.Cross.Interop.SpvcSetS(SpirvSet s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Spirv.Cross.Interop.SpvcSetS();
    }

    public static implicit operator SpirvSet(AdamantiumVulkan.Spirv.Cross.Interop.SpvcSetS s)
    {
        return new SpirvSet(s);
    }

}



