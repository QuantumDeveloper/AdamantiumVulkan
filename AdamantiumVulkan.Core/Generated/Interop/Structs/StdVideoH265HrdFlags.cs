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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_h265std.h Line: 139 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH265HrdFlags
{
    public uint nal_hrd_parameters_present_flag;
    public uint vcl_hrd_parameters_present_flag;
    public uint sub_pic_hrd_params_present_flag;
    public uint sub_pic_cpb_params_in_pic_timing_sei_flag;
    public uint fixed_pic_rate_general_flag;
    public uint fixed_pic_rate_within_cvs_flag;
    public uint low_delay_hrd_flag;
}



