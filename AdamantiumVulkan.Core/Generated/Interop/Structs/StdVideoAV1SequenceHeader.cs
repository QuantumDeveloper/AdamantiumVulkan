// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan;

namespace AdamantiumVulkan.Interop;

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 370 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1SequenceHeader
{
    public StdVideoAV1SequenceHeaderFlags flags;
    public StdVideoAV1Profile seq_profile;
    public byte frame_width_bits_minus_1;
    public byte frame_height_bits_minus_1;
    public ushort max_frame_width_minus_1;
    public ushort max_frame_height_minus_1;
    public byte delta_frame_id_length_minus_2;
    public byte additional_frame_id_length_minus_1;
    public byte order_hint_bits_minus_1;
    public byte seq_force_integer_mv;
    public byte seq_force_screen_content_tools;
    public unsafe fixed byte reserved1[5];
    public AdamantiumVulkan.Interop.StdVideoAV1ColorConfig* pColorConfig;
    public AdamantiumVulkan.Interop.StdVideoAV1TimingInfo* pTimingInfo;
}


