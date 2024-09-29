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

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_h265std.h Line: 149 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH265HrdParameters
{
    public StdVideoH265HrdFlags flags;
    public byte tick_divisor_minus2;
    public byte du_cpb_removal_delay_increment_length_minus1;
    public byte dpb_output_delay_du_length_minus1;
    public byte bit_rate_scale;
    public byte cpb_size_scale;
    public byte cpb_size_du_scale;
    public byte initial_cpb_removal_delay_length_minus1;
    public byte au_cpb_removal_delay_length_minus1;
    public byte dpb_output_delay_length_minus1;
    public unsafe fixed byte cpb_cnt_minus1[7];
    public unsafe fixed ushort elemental_duration_in_tc_minus1[7];
    public unsafe fixed ushort reserved[3];
    public AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;
    public AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
}



