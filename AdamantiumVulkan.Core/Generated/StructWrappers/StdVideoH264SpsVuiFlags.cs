// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan;

public unsafe partial class StdVideoH264SpsVuiFlags : QBDisposableObject
{
    public StdVideoH264SpsVuiFlags()
    {
    }

    public StdVideoH264SpsVuiFlags(AdamantiumVulkan.Interop.StdVideoH264SpsVuiFlags _internal)
    {
        Aspect_ratio_info_present_flag = _internal.aspect_ratio_info_present_flag;
        Overscan_info_present_flag = _internal.overscan_info_present_flag;
        Overscan_appropriate_flag = _internal.overscan_appropriate_flag;
        Video_signal_type_present_flag = _internal.video_signal_type_present_flag;
        Video_full_range_flag = _internal.video_full_range_flag;
        Color_description_present_flag = _internal.color_description_present_flag;
        Chroma_loc_info_present_flag = _internal.chroma_loc_info_present_flag;
        Timing_info_present_flag = _internal.timing_info_present_flag;
        Fixed_frame_rate_flag = _internal.fixed_frame_rate_flag;
        Bitstream_restriction_flag = _internal.bitstream_restriction_flag;
        Nal_hrd_parameters_present_flag = _internal.nal_hrd_parameters_present_flag;
        Vcl_hrd_parameters_present_flag = _internal.vcl_hrd_parameters_present_flag;
    }

    public uint Aspect_ratio_info_present_flag { get; set; }
    public uint Overscan_info_present_flag { get; set; }
    public uint Overscan_appropriate_flag { get; set; }
    public uint Video_signal_type_present_flag { get; set; }
    public uint Video_full_range_flag { get; set; }
    public uint Color_description_present_flag { get; set; }
    public uint Chroma_loc_info_present_flag { get; set; }
    public uint Timing_info_present_flag { get; set; }
    public uint Fixed_frame_rate_flag { get; set; }
    public uint Bitstream_restriction_flag { get; set; }
    public uint Nal_hrd_parameters_present_flag { get; set; }
    public uint Vcl_hrd_parameters_present_flag { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH264SpsVuiFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH264SpsVuiFlags();
        if (Aspect_ratio_info_present_flag != default)
        {
            _internal.aspect_ratio_info_present_flag = Aspect_ratio_info_present_flag;
        }
        if (Overscan_info_present_flag != default)
        {
            _internal.overscan_info_present_flag = Overscan_info_present_flag;
        }
        if (Overscan_appropriate_flag != default)
        {
            _internal.overscan_appropriate_flag = Overscan_appropriate_flag;
        }
        if (Video_signal_type_present_flag != default)
        {
            _internal.video_signal_type_present_flag = Video_signal_type_present_flag;
        }
        if (Video_full_range_flag != default)
        {
            _internal.video_full_range_flag = Video_full_range_flag;
        }
        if (Color_description_present_flag != default)
        {
            _internal.color_description_present_flag = Color_description_present_flag;
        }
        if (Chroma_loc_info_present_flag != default)
        {
            _internal.chroma_loc_info_present_flag = Chroma_loc_info_present_flag;
        }
        if (Timing_info_present_flag != default)
        {
            _internal.timing_info_present_flag = Timing_info_present_flag;
        }
        if (Fixed_frame_rate_flag != default)
        {
            _internal.fixed_frame_rate_flag = Fixed_frame_rate_flag;
        }
        if (Bitstream_restriction_flag != default)
        {
            _internal.bitstream_restriction_flag = Bitstream_restriction_flag;
        }
        if (Nal_hrd_parameters_present_flag != default)
        {
            _internal.nal_hrd_parameters_present_flag = Nal_hrd_parameters_present_flag;
        }
        if (Vcl_hrd_parameters_present_flag != default)
        {
            _internal.vcl_hrd_parameters_present_flag = Vcl_hrd_parameters_present_flag;
        }
        return _internal;
    }

    public static implicit operator StdVideoH264SpsVuiFlags(AdamantiumVulkan.Interop.StdVideoH264SpsVuiFlags s)
    {
        return new StdVideoH264SpsVuiFlags(s);
    }

}



