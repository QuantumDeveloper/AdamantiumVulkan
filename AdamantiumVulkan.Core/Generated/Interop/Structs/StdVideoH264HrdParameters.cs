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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_h264std.h Line: 195 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH264HrdParameters
{
    public byte cpb_cnt_minus1;
    public byte bit_rate_scale;
    public byte cpb_size_scale;
    public byte reserved1;
    public unsafe fixed uint bit_rate_value_minus1[32];
    public unsafe fixed uint cpb_size_value_minus1[32];
    public unsafe fixed byte cbr_flag[32];
    public uint initial_cpb_removal_delay_length_minus1;
    public uint cpb_removal_delay_length_minus1;
    public uint dpb_output_delay_length_minus1;
    public uint time_offset_length;
}



