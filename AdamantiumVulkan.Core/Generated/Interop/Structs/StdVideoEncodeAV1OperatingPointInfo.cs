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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_av1std_encode.h Line: 50 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoEncodeAV1OperatingPointInfo
{
    public StdVideoEncodeAV1OperatingPointInfoFlags flags;
    public ushort operating_point_idc;
    public byte seq_level_idx;
    public byte seq_tier;
    public uint decoder_buffer_delay;
    public uint encoder_buffer_delay;
    public byte initial_display_delay_minus_1;
}



