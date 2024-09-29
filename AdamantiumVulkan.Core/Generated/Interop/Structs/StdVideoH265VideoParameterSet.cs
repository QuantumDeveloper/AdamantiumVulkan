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

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_h265std.h Line: 188 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH265VideoParameterSet
{
    public StdVideoH265VpsFlags flags;
    public byte vps_video_parameter_set_id;
    public byte vps_max_sub_layers_minus1;
    public byte reserved1;
    public byte reserved2;
    public uint vps_num_units_in_tick;
    public uint vps_time_scale;
    public uint vps_num_ticks_poc_diff_one_minus1;
    public uint reserved3;
    public AdamantiumVulkan.Interop.StdVideoH265DecPicBufMgr* pDecPicBufMgr;
    public AdamantiumVulkan.Interop.StdVideoH265HrdParameters* pHrdParameters;
    public AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevel* pProfileTierLevel;
}



