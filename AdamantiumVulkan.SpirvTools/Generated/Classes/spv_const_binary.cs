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
using AdamantiumVulkan.SpirvTools.Interop;

namespace AdamantiumVulkan.SpirvTools;

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 509 Column: 29
///<summary>
/// Type Definitions
///</summary>
public unsafe partial class spv_const_binary
{
    internal spv_const_binary_t __Instance;
    public spv_const_binary()
    {
    }

    public spv_const_binary(AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly spv_const_binary_t GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t(spv_const_binary s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t();
    }

    public static implicit operator spv_const_binary(AdamantiumVulkan.SpirvTools.Interop.spv_const_binary_t s)
    {
        return new spv_const_binary(s);
    }

}



