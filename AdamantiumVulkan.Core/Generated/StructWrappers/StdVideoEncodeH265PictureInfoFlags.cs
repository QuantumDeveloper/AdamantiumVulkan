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

public unsafe partial class StdVideoEncodeH265PictureInfoFlags : QBDisposableObject
{
    public StdVideoEncodeH265PictureInfoFlags()
    {
    }

    public StdVideoEncodeH265PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeH265PictureInfoFlags _internal)
    {
        Is_reference = _internal.is_reference;
        IrapPicFlag = _internal.IrapPicFlag;
        Used_for_long_term_reference = _internal.used_for_long_term_reference;
        Discardable_flag = _internal.discardable_flag;
        Cross_layer_bla_flag = _internal.cross_layer_bla_flag;
        Pic_output_flag = _internal.pic_output_flag;
        No_output_of_prior_pics_flag = _internal.no_output_of_prior_pics_flag;
        Short_term_ref_pic_set_sps_flag = _internal.short_term_ref_pic_set_sps_flag;
        Slice_temporal_mvp_enabled_flag = _internal.slice_temporal_mvp_enabled_flag;
        Reserved = _internal.reserved;
    }

    public uint Is_reference { get; set; }
    public uint IrapPicFlag { get; set; }
    public uint Used_for_long_term_reference { get; set; }
    public uint Discardable_flag { get; set; }
    public uint Cross_layer_bla_flag { get; set; }
    public uint Pic_output_flag { get; set; }
    public uint No_output_of_prior_pics_flag { get; set; }
    public uint Short_term_ref_pic_set_sps_flag { get; set; }
    public uint Slice_temporal_mvp_enabled_flag { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH265PictureInfoFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH265PictureInfoFlags();
        if (Is_reference != default)
        {
            _internal.is_reference = Is_reference;
        }
        if (IrapPicFlag != default)
        {
            _internal.IrapPicFlag = IrapPicFlag;
        }
        if (Used_for_long_term_reference != default)
        {
            _internal.used_for_long_term_reference = Used_for_long_term_reference;
        }
        if (Discardable_flag != default)
        {
            _internal.discardable_flag = Discardable_flag;
        }
        if (Cross_layer_bla_flag != default)
        {
            _internal.cross_layer_bla_flag = Cross_layer_bla_flag;
        }
        if (Pic_output_flag != default)
        {
            _internal.pic_output_flag = Pic_output_flag;
        }
        if (No_output_of_prior_pics_flag != default)
        {
            _internal.no_output_of_prior_pics_flag = No_output_of_prior_pics_flag;
        }
        if (Short_term_ref_pic_set_sps_flag != default)
        {
            _internal.short_term_ref_pic_set_sps_flag = Short_term_ref_pic_set_sps_flag;
        }
        if (Slice_temporal_mvp_enabled_flag != default)
        {
            _internal.slice_temporal_mvp_enabled_flag = Slice_temporal_mvp_enabled_flag;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeH265PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeH265PictureInfoFlags s)
    {
        return new StdVideoEncodeH265PictureInfoFlags(s);
    }

}



