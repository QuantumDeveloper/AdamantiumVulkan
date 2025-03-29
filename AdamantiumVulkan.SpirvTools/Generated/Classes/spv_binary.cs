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

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 510 Column: 23
public unsafe partial class spv_binary
{
    internal spv_binary_t __Instance;
    public spv_binary()
    {
    }

    public spv_binary(AdamantiumVulkan.SpirvTools.Interop.spv_binary_t __Instance)
    {
        this.__Instance = __Instance;
    }

    ///<summary>
    /// Frees a binary stream from memory. This is a no-op if binary is a null pointer.
    ///</summary>
    public void SpvBinaryDestroy()
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvBinaryDestroy(this);
    }

    public ref readonly spv_binary_t GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.SpirvTools.Interop.spv_binary_t(spv_binary s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.SpirvTools.Interop.spv_binary_t();
    }

    public static implicit operator spv_binary(AdamantiumVulkan.SpirvTools.Interop.spv_binary_t s)
    {
        return new spv_binary(s);
    }

}



