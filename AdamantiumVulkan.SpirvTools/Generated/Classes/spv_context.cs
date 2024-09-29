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

// File: C:\VulkanSDK\1.3.283.0\Include\spirv-tools\libspirv.h Line: 495 Column: 24
public unsafe partial class spv_context
{
    internal spv_context_t __Instance;
    public spv_context()
    {
    }

    public spv_context(AdamantiumVulkan.SpirvTools.Interop.spv_context_t __Instance)
    {
        this.__Instance = __Instance;
    }

    ///<summary>
    /// Destroys the given context object.
    ///</summary>
    public void SpvContextDestroy()
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvContextDestroy(this);
    }

    public ref readonly spv_context_t GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.SpirvTools.Interop.spv_context_t(spv_context s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.SpirvTools.Interop.spv_context_t();
    }

    public static implicit operator spv_context(AdamantiumVulkan.SpirvTools.Interop.spv_context_t s)
    {
        return new spv_context(s);
    }

}


