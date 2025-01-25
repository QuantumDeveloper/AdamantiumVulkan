// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 321 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1FilmGrain
{
    public StdVideoAV1FilmGrainFlags flags;
    public byte grain_scaling_minus_8;
    public byte ar_coeff_lag;
    public byte ar_coeff_shift_minus_6;
    public byte grain_scale_shift;
    public ushort grain_seed;
    public byte film_grain_params_ref_idx;
    public byte num_y_points;
    public unsafe fixed byte point_y_value[14];
    public unsafe fixed byte point_y_scaling[14];
    public byte num_cb_points;
    public unsafe fixed byte point_cb_value[10];
    public unsafe fixed byte point_cb_scaling[10];
    public byte num_cr_points;
    public unsafe fixed byte point_cr_value[10];
    public unsafe fixed byte point_cr_scaling[10];
    public unsafe fixed sbyte ar_coeffs_y_plus_128[24];
    public unsafe fixed sbyte ar_coeffs_cb_plus_128[25];
    public unsafe fixed sbyte ar_coeffs_cr_plus_128[25];
    public byte cb_mult;
    public byte cb_luma_mult;
    public ushort cb_offset;
    public byte cr_mult;
    public byte cr_luma_mult;
    public ushort cr_offset;
}



