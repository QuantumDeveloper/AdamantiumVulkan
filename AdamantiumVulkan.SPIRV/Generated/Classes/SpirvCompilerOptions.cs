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

// File: C:\VulkanSDK\1.4.304.0\Include\spirv_cross\spirv_cross_c.h Line: 75 Column: 41
public unsafe partial class SpirvCompilerOptions
{
    internal SpvcCompilerOptionsS __Instance;
    public SpirvCompilerOptions()
    {
    }

    public SpirvCompilerOptions(AdamantiumVulkan.Spirv.Cross.Interop.SpvcCompilerOptionsS __Instance)
    {
        this.__Instance = __Instance;
    }

    ///<summary>
    /// Override options. Will return error if e.g. MSL options are used for the HLSL backend, etc.
    ///</summary>
    public Result SetBool(CompilerOption option, SpvcBool value)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_compiler_options_set_bool(this, option, value);
    }

    public Result SetUint(CompilerOption option, uint value)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_compiler_options_set_uint(this, option, value);
    }

    public ref readonly SpvcCompilerOptionsS GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Spirv.Cross.Interop.SpvcCompilerOptionsS(SpirvCompilerOptions s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Spirv.Cross.Interop.SpvcCompilerOptionsS();
    }

    public static implicit operator SpirvCompilerOptions(AdamantiumVulkan.Spirv.Cross.Interop.SpvcCompilerOptionsS s)
    {
        return new SpirvCompilerOptions(s);
    }

}



