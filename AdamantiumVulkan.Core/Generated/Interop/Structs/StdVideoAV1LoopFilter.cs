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

// File: C:\VulkanSDK\1.4.304.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 242 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1LoopFilter
{
    public StdVideoAV1LoopFilterFlags flags;
    public unsafe fixed byte loop_filter_level[4];
    public byte loop_filter_sharpness;
    public byte update_ref_delta;
    public unsafe fixed sbyte loop_filter_ref_deltas[8];
    public byte update_mode_delta;
    public unsafe fixed sbyte loop_filter_mode_deltas[2];
}



