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

public unsafe partial class StdVideoEncodeAV1PictureInfoFlags : QBDisposableObject
{
    public StdVideoEncodeAV1PictureInfoFlags()
    {
    }

    public StdVideoEncodeAV1PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeAV1PictureInfoFlags _internal)
    {
        Error_resilient_mode = _internal.error_resilient_mode;
        Disable_cdf_update = _internal.disable_cdf_update;
        Use_superres = _internal.use_superres;
        Render_and_frame_size_different = _internal.render_and_frame_size_different;
        Allow_screen_content_tools = _internal.allow_screen_content_tools;
        Is_filter_switchable = _internal.is_filter_switchable;
        Force_integer_mv = _internal.force_integer_mv;
        Frame_size_override_flag = _internal.frame_size_override_flag;
        Buffer_removal_time_present_flag = _internal.buffer_removal_time_present_flag;
        Allow_intrabc = _internal.allow_intrabc;
        Frame_refs_short_signaling = _internal.frame_refs_short_signaling;
        Allow_high_precision_mv = _internal.allow_high_precision_mv;
        Is_motion_mode_switchable = _internal.is_motion_mode_switchable;
        Use_ref_frame_mvs = _internal.use_ref_frame_mvs;
        Disable_frame_end_update_cdf = _internal.disable_frame_end_update_cdf;
        Allow_warped_motion = _internal.allow_warped_motion;
        Reduced_tx_set = _internal.reduced_tx_set;
        Skip_mode_present = _internal.skip_mode_present;
        Delta_q_present = _internal.delta_q_present;
        Delta_lf_present = _internal.delta_lf_present;
        Delta_lf_multi = _internal.delta_lf_multi;
        Segmentation_enabled = _internal.segmentation_enabled;
        Segmentation_update_map = _internal.segmentation_update_map;
        Segmentation_temporal_update = _internal.segmentation_temporal_update;
        Segmentation_update_data = _internal.segmentation_update_data;
        UsesLr = _internal.UsesLr;
        UsesChromaLr = _internal.usesChromaLr;
        Show_frame = _internal.show_frame;
        Showable_frame = _internal.showable_frame;
        Reserved = _internal.reserved;
    }

    public uint Error_resilient_mode { get; set; }
    public uint Disable_cdf_update { get; set; }
    public uint Use_superres { get; set; }
    public uint Render_and_frame_size_different { get; set; }
    public uint Allow_screen_content_tools { get; set; }
    public uint Is_filter_switchable { get; set; }
    public uint Force_integer_mv { get; set; }
    public uint Frame_size_override_flag { get; set; }
    public uint Buffer_removal_time_present_flag { get; set; }
    public uint Allow_intrabc { get; set; }
    public uint Frame_refs_short_signaling { get; set; }
    public uint Allow_high_precision_mv { get; set; }
    public uint Is_motion_mode_switchable { get; set; }
    public uint Use_ref_frame_mvs { get; set; }
    public uint Disable_frame_end_update_cdf { get; set; }
    public uint Allow_warped_motion { get; set; }
    public uint Reduced_tx_set { get; set; }
    public uint Skip_mode_present { get; set; }
    public uint Delta_q_present { get; set; }
    public uint Delta_lf_present { get; set; }
    public uint Delta_lf_multi { get; set; }
    public uint Segmentation_enabled { get; set; }
    public uint Segmentation_update_map { get; set; }
    public uint Segmentation_temporal_update { get; set; }
    public uint Segmentation_update_data { get; set; }
    public uint UsesLr { get; set; }
    public uint UsesChromaLr { get; set; }
    public uint Show_frame { get; set; }
    public uint Showable_frame { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeAV1PictureInfoFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeAV1PictureInfoFlags();
        if (Error_resilient_mode != default)
        {
            _internal.error_resilient_mode = Error_resilient_mode;
        }
        if (Disable_cdf_update != default)
        {
            _internal.disable_cdf_update = Disable_cdf_update;
        }
        if (Use_superres != default)
        {
            _internal.use_superres = Use_superres;
        }
        if (Render_and_frame_size_different != default)
        {
            _internal.render_and_frame_size_different = Render_and_frame_size_different;
        }
        if (Allow_screen_content_tools != default)
        {
            _internal.allow_screen_content_tools = Allow_screen_content_tools;
        }
        if (Is_filter_switchable != default)
        {
            _internal.is_filter_switchable = Is_filter_switchable;
        }
        if (Force_integer_mv != default)
        {
            _internal.force_integer_mv = Force_integer_mv;
        }
        if (Frame_size_override_flag != default)
        {
            _internal.frame_size_override_flag = Frame_size_override_flag;
        }
        if (Buffer_removal_time_present_flag != default)
        {
            _internal.buffer_removal_time_present_flag = Buffer_removal_time_present_flag;
        }
        if (Allow_intrabc != default)
        {
            _internal.allow_intrabc = Allow_intrabc;
        }
        if (Frame_refs_short_signaling != default)
        {
            _internal.frame_refs_short_signaling = Frame_refs_short_signaling;
        }
        if (Allow_high_precision_mv != default)
        {
            _internal.allow_high_precision_mv = Allow_high_precision_mv;
        }
        if (Is_motion_mode_switchable != default)
        {
            _internal.is_motion_mode_switchable = Is_motion_mode_switchable;
        }
        if (Use_ref_frame_mvs != default)
        {
            _internal.use_ref_frame_mvs = Use_ref_frame_mvs;
        }
        if (Disable_frame_end_update_cdf != default)
        {
            _internal.disable_frame_end_update_cdf = Disable_frame_end_update_cdf;
        }
        if (Allow_warped_motion != default)
        {
            _internal.allow_warped_motion = Allow_warped_motion;
        }
        if (Reduced_tx_set != default)
        {
            _internal.reduced_tx_set = Reduced_tx_set;
        }
        if (Skip_mode_present != default)
        {
            _internal.skip_mode_present = Skip_mode_present;
        }
        if (Delta_q_present != default)
        {
            _internal.delta_q_present = Delta_q_present;
        }
        if (Delta_lf_present != default)
        {
            _internal.delta_lf_present = Delta_lf_present;
        }
        if (Delta_lf_multi != default)
        {
            _internal.delta_lf_multi = Delta_lf_multi;
        }
        if (Segmentation_enabled != default)
        {
            _internal.segmentation_enabled = Segmentation_enabled;
        }
        if (Segmentation_update_map != default)
        {
            _internal.segmentation_update_map = Segmentation_update_map;
        }
        if (Segmentation_temporal_update != default)
        {
            _internal.segmentation_temporal_update = Segmentation_temporal_update;
        }
        if (Segmentation_update_data != default)
        {
            _internal.segmentation_update_data = Segmentation_update_data;
        }
        if (UsesLr != default)
        {
            _internal.UsesLr = UsesLr;
        }
        if (UsesChromaLr != default)
        {
            _internal.usesChromaLr = UsesChromaLr;
        }
        if (Show_frame != default)
        {
            _internal.show_frame = Show_frame;
        }
        if (Showable_frame != default)
        {
            _internal.showable_frame = Showable_frame;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeAV1PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeAV1PictureInfoFlags s)
    {
        return new StdVideoEncodeAV1PictureInfoFlags(s);
    }

}



