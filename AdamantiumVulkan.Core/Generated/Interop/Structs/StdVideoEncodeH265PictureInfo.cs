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

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_h265std_encode.h Line: 124 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoEncodeH265PictureInfo
{
    public StdVideoEncodeH265PictureInfoFlags flags;
    public StdVideoH265PictureType pic_type;
    public byte sps_video_parameter_set_id;
    public byte pps_seq_parameter_set_id;
    public byte pps_pic_parameter_set_id;
    public byte short_term_ref_pic_set_idx;
    public int PicOrderCntVal;
    public byte TemporalId;
    public unsafe fixed byte reserved1[7];
    public AdamantiumVulkan.Interop.StdVideoEncodeH265ReferenceListsInfo* pRefLists;
    public AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
    public AdamantiumVulkan.Interop.StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;
}



