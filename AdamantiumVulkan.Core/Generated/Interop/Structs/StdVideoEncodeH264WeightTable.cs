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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_h264std_encode.h Line: 37 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoEncodeH264WeightTable
{
    public StdVideoEncodeH264WeightTableFlags flags;
    public byte luma_log2_weight_denom;
    public byte chroma_log2_weight_denom;
    public unsafe fixed sbyte luma_weight_l0[32];
    public unsafe fixed sbyte luma_offset_l0[32];
    public unsafe fixed sbyte chroma_weight_l0[64];
    public unsafe fixed sbyte chroma_offset_l0[64];
    public unsafe fixed sbyte luma_weight_l1[32];
    public unsafe fixed sbyte luma_offset_l1[32];
    public unsafe fixed sbyte chroma_weight_l1[64];
    public unsafe fixed sbyte chroma_offset_l1[64];
}



