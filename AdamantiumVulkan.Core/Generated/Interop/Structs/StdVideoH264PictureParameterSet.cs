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

// File: C:\VulkanSDK\1.3.275.0\Include\vk_video/vulkan_video_codec_h264std.h Line: 293 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH264PictureParameterSet
{
    public StdVideoH264PpsFlags flags;
    public byte seq_parameter_set_id;
    public byte pic_parameter_set_id;
    public byte num_ref_idx_l0_default_active_minus1;
    public byte num_ref_idx_l1_default_active_minus1;
    public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
    public sbyte pic_init_qp_minus26;
    public sbyte pic_init_qs_minus26;
    public sbyte chroma_qp_index_offset;
    public sbyte second_chroma_qp_index_offset;
    public AdamantiumVulkan.Interop.StdVideoH264ScalingLists* pScalingLists;
}



