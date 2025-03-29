// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Spirv.Cross;

namespace AdamantiumVulkan.Spirv.Cross.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\spirv_cross\spirv_cross_c.h Line: 536 Column: 16
///<summary>
/// Maps to C++ API.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SpvcMslConstexprSampler
{
    public MslSamplerCoord coord;
    public MslSamplerFilter min_filter;
    public MslSamplerFilter mag_filter;
    public MslSamplerMipFilter mip_filter;
    public MslSamplerAddress s_address;
    public MslSamplerAddress t_address;
    public MslSamplerAddress r_address;
    public MslSamplerCompareFunc compare_func;
    public MslSamplerBorderColor border_color;
    public float lod_clamp_min;
    public float lod_clamp_max;
    public int max_anisotropy;
    public SpvcBool compare_enable;
    public SpvcBool lod_clamp_enable;
    public SpvcBool anisotropy_enable;
}



