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

public unsafe partial class StdVideoH264SequenceParameterSet : QBDisposableObject
{
    private NativeStruct<int> _pOffsetForRefFrame;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH264ScalingLists> _pScalingLists;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSetVui> _pSequenceParameterSetVui;

    public StdVideoH264SequenceParameterSet()
    {
    }

    public StdVideoH264SequenceParameterSet(AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet _internal)
    {
        Flags = new StdVideoH264SpsFlags(_internal.flags);
        Profile_idc = _internal.profile_idc;
        Level_idc = _internal.level_idc;
        Chroma_format_idc = _internal.chroma_format_idc;
        Seq_parameter_set_id = _internal.seq_parameter_set_id;
        Bit_depth_luma_minus8 = _internal.bit_depth_luma_minus8;
        Bit_depth_chroma_minus8 = _internal.bit_depth_chroma_minus8;
        Log2_max_frame_num_minus4 = _internal.log2_max_frame_num_minus4;
        Pic_order_cnt_type = _internal.pic_order_cnt_type;
        Offset_for_non_ref_pic = _internal.offset_for_non_ref_pic;
        Offset_for_top_to_bottom_field = _internal.offset_for_top_to_bottom_field;
        Log2_max_pic_order_cnt_lsb_minus4 = _internal.log2_max_pic_order_cnt_lsb_minus4;
        Num_ref_frames_in_pic_order_cnt_cycle = _internal.num_ref_frames_in_pic_order_cnt_cycle;
        Max_num_ref_frames = _internal.max_num_ref_frames;
        Reserved1 = _internal.reserved1;
        Pic_width_in_mbs_minus1 = _internal.pic_width_in_mbs_minus1;
        Pic_height_in_map_units_minus1 = _internal.pic_height_in_map_units_minus1;
        Frame_crop_left_offset = _internal.frame_crop_left_offset;
        Frame_crop_right_offset = _internal.frame_crop_right_offset;
        Frame_crop_top_offset = _internal.frame_crop_top_offset;
        Frame_crop_bottom_offset = _internal.frame_crop_bottom_offset;
        Reserved2 = _internal.reserved2;
        if (_internal.pOffsetForRefFrame != null)
        {
            POffsetForRefFrame = *_internal.pOffsetForRefFrame;
            NativeUtils.Free(_internal.pOffsetForRefFrame);
        }
        PScalingLists = new StdVideoH264ScalingLists(*_internal.pScalingLists);
        NativeUtils.Free(_internal.pScalingLists);
        PSequenceParameterSetVui = new StdVideoH264SequenceParameterSetVui(*_internal.pSequenceParameterSetVui);
        NativeUtils.Free(_internal.pSequenceParameterSetVui);
    }

    public StdVideoH264SpsFlags Flags { get; set; }
    public StdVideoH264ProfileIdc Profile_idc { get; set; }
    public StdVideoH264LevelIdc Level_idc { get; set; }
    public StdVideoH264ChromaFormatIdc Chroma_format_idc { get; set; }
    public byte Seq_parameter_set_id { get; set; }
    public byte Bit_depth_luma_minus8 { get; set; }
    public byte Bit_depth_chroma_minus8 { get; set; }
    public byte Log2_max_frame_num_minus4 { get; set; }
    public StdVideoH264PocType Pic_order_cnt_type { get; set; }
    public int Offset_for_non_ref_pic { get; set; }
    public int Offset_for_top_to_bottom_field { get; set; }
    public byte Log2_max_pic_order_cnt_lsb_minus4 { get; set; }
    public byte Num_ref_frames_in_pic_order_cnt_cycle { get; set; }
    public byte Max_num_ref_frames { get; set; }
    public byte Reserved1 { get; set; }
    public uint Pic_width_in_mbs_minus1 { get; set; }
    public uint Pic_height_in_map_units_minus1 { get; set; }
    public uint Frame_crop_left_offset { get; set; }
    public uint Frame_crop_right_offset { get; set; }
    public uint Frame_crop_top_offset { get; set; }
    public uint Frame_crop_bottom_offset { get; set; }
    public uint Reserved2 { get; set; }
    public int? POffsetForRefFrame { get; set; }
    public StdVideoH264ScalingLists PScalingLists { get; set; }
    public StdVideoH264SequenceParameterSetVui PSequenceParameterSetVui { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet();
        if (Flags != default)
        {
            _internal.flags = Flags.ToNative();
        }
        if (Profile_idc != default)
        {
            _internal.profile_idc = Profile_idc;
        }
        if (Level_idc != default)
        {
            _internal.level_idc = Level_idc;
        }
        if (Chroma_format_idc != default)
        {
            _internal.chroma_format_idc = Chroma_format_idc;
        }
        if (Seq_parameter_set_id != default)
        {
            _internal.seq_parameter_set_id = Seq_parameter_set_id;
        }
        if (Bit_depth_luma_minus8 != default)
        {
            _internal.bit_depth_luma_minus8 = Bit_depth_luma_minus8;
        }
        if (Bit_depth_chroma_minus8 != default)
        {
            _internal.bit_depth_chroma_minus8 = Bit_depth_chroma_minus8;
        }
        if (Log2_max_frame_num_minus4 != default)
        {
            _internal.log2_max_frame_num_minus4 = Log2_max_frame_num_minus4;
        }
        if (Pic_order_cnt_type != default)
        {
            _internal.pic_order_cnt_type = Pic_order_cnt_type;
        }
        if (Offset_for_non_ref_pic != default)
        {
            _internal.offset_for_non_ref_pic = Offset_for_non_ref_pic;
        }
        if (Offset_for_top_to_bottom_field != default)
        {
            _internal.offset_for_top_to_bottom_field = Offset_for_top_to_bottom_field;
        }
        if (Log2_max_pic_order_cnt_lsb_minus4 != default)
        {
            _internal.log2_max_pic_order_cnt_lsb_minus4 = Log2_max_pic_order_cnt_lsb_minus4;
        }
        if (Num_ref_frames_in_pic_order_cnt_cycle != default)
        {
            _internal.num_ref_frames_in_pic_order_cnt_cycle = Num_ref_frames_in_pic_order_cnt_cycle;
        }
        if (Max_num_ref_frames != default)
        {
            _internal.max_num_ref_frames = Max_num_ref_frames;
        }
        if (Reserved1 != default)
        {
            _internal.reserved1 = Reserved1;
        }
        if (Pic_width_in_mbs_minus1 != default)
        {
            _internal.pic_width_in_mbs_minus1 = Pic_width_in_mbs_minus1;
        }
        if (Pic_height_in_map_units_minus1 != default)
        {
            _internal.pic_height_in_map_units_minus1 = Pic_height_in_map_units_minus1;
        }
        if (Frame_crop_left_offset != default)
        {
            _internal.frame_crop_left_offset = Frame_crop_left_offset;
        }
        if (Frame_crop_right_offset != default)
        {
            _internal.frame_crop_right_offset = Frame_crop_right_offset;
        }
        if (Frame_crop_top_offset != default)
        {
            _internal.frame_crop_top_offset = Frame_crop_top_offset;
        }
        if (Frame_crop_bottom_offset != default)
        {
            _internal.frame_crop_bottom_offset = Frame_crop_bottom_offset;
        }
        if (Reserved2 != default)
        {
            _internal.reserved2 = Reserved2;
        }
        _pOffsetForRefFrame.Dispose();
        if (POffsetForRefFrame.HasValue)
        {
            _pOffsetForRefFrame = new NativeStruct<int>(POffsetForRefFrame.Value);
            _internal.pOffsetForRefFrame = _pOffsetForRefFrame.Handle;
        }
        _pScalingLists.Dispose();
        if (PScalingLists != default)
        {
            var struct1 = PScalingLists.ToNative();
            _pScalingLists = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH264ScalingLists>(struct1);
            _internal.pScalingLists = _pScalingLists.Handle;
        }
        _pSequenceParameterSetVui.Dispose();
        if (PSequenceParameterSetVui != default)
        {
            var struct2 = PSequenceParameterSetVui.ToNative();
            _pSequenceParameterSetVui = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSetVui>(struct2);
            _internal.pSequenceParameterSetVui = _pSequenceParameterSetVui.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pOffsetForRefFrame.Dispose();
        _pScalingLists.Dispose();
        _pSequenceParameterSetVui.Dispose();
        Flags?.Dispose();
    }


    public static implicit operator StdVideoH264SequenceParameterSet(AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet s)
    {
        return new StdVideoH264SequenceParameterSet(s);
    }

}



