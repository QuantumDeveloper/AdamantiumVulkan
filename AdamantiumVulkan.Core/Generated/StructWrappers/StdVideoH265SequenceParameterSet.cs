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

public unsafe partial class StdVideoH265SequenceParameterSet : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevel> _pProfileTierLevel;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265DecPicBufMgr> _pDecPicBufMgr;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ScalingLists> _pScalingLists;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSet> _pShortTermRefPicSet;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265LongTermRefPicsSps> _pLongTermRefPicsSps;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSetVui> _pSequenceParameterSetVui;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH265PredictorPaletteEntries> _pPredictorPaletteEntries;

    public StdVideoH265SequenceParameterSet()
    {
    }

    public StdVideoH265SequenceParameterSet(AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSet _internal)
    {
        Flags = new StdVideoH265SpsFlags(_internal.flags);
        Chroma_format_idc = _internal.chroma_format_idc;
        Pic_width_in_luma_samples = _internal.pic_width_in_luma_samples;
        Pic_height_in_luma_samples = _internal.pic_height_in_luma_samples;
        Sps_video_parameter_set_id = _internal.sps_video_parameter_set_id;
        Sps_max_sub_layers_minus1 = _internal.sps_max_sub_layers_minus1;
        Sps_seq_parameter_set_id = _internal.sps_seq_parameter_set_id;
        Bit_depth_luma_minus8 = _internal.bit_depth_luma_minus8;
        Bit_depth_chroma_minus8 = _internal.bit_depth_chroma_minus8;
        Log2_max_pic_order_cnt_lsb_minus4 = _internal.log2_max_pic_order_cnt_lsb_minus4;
        Log2_min_luma_coding_block_size_minus3 = _internal.log2_min_luma_coding_block_size_minus3;
        Log2_diff_max_min_luma_coding_block_size = _internal.log2_diff_max_min_luma_coding_block_size;
        Log2_min_luma_transform_block_size_minus2 = _internal.log2_min_luma_transform_block_size_minus2;
        Log2_diff_max_min_luma_transform_block_size = _internal.log2_diff_max_min_luma_transform_block_size;
        Max_transform_hierarchy_depth_inter = _internal.max_transform_hierarchy_depth_inter;
        Max_transform_hierarchy_depth_intra = _internal.max_transform_hierarchy_depth_intra;
        Num_short_term_ref_pic_sets = _internal.num_short_term_ref_pic_sets;
        Num_long_term_ref_pics_sps = _internal.num_long_term_ref_pics_sps;
        Pcm_sample_bit_depth_luma_minus1 = _internal.pcm_sample_bit_depth_luma_minus1;
        Pcm_sample_bit_depth_chroma_minus1 = _internal.pcm_sample_bit_depth_chroma_minus1;
        Log2_min_pcm_luma_coding_block_size_minus3 = _internal.log2_min_pcm_luma_coding_block_size_minus3;
        Log2_diff_max_min_pcm_luma_coding_block_size = _internal.log2_diff_max_min_pcm_luma_coding_block_size;
        Reserved1 = _internal.reserved1;
        Reserved2 = _internal.reserved2;
        Palette_max_size = _internal.palette_max_size;
        Delta_palette_max_predictor_size = _internal.delta_palette_max_predictor_size;
        Motion_vector_resolution_control_idc = _internal.motion_vector_resolution_control_idc;
        Sps_num_palette_predictor_initializers_minus1 = _internal.sps_num_palette_predictor_initializers_minus1;
        Conf_win_left_offset = _internal.conf_win_left_offset;
        Conf_win_right_offset = _internal.conf_win_right_offset;
        Conf_win_top_offset = _internal.conf_win_top_offset;
        Conf_win_bottom_offset = _internal.conf_win_bottom_offset;
        ProfileTierLevel = new StdVideoH265ProfileTierLevel(*_internal.pProfileTierLevel);
        NativeUtils.Free(_internal.pProfileTierLevel);
        PDecPicBufMgr = new StdVideoH265DecPicBufMgr(*_internal.pDecPicBufMgr);
        NativeUtils.Free(_internal.pDecPicBufMgr);
        PScalingLists = new StdVideoH265ScalingLists(*_internal.pScalingLists);
        NativeUtils.Free(_internal.pScalingLists);
        PShortTermRefPicSet = new StdVideoH265ShortTermRefPicSet(*_internal.pShortTermRefPicSet);
        NativeUtils.Free(_internal.pShortTermRefPicSet);
        PLongTermRefPicsSps = new StdVideoH265LongTermRefPicsSps(*_internal.pLongTermRefPicsSps);
        NativeUtils.Free(_internal.pLongTermRefPicsSps);
        PSequenceParameterSetVui = new StdVideoH265SequenceParameterSetVui(*_internal.pSequenceParameterSetVui);
        NativeUtils.Free(_internal.pSequenceParameterSetVui);
        PredictorPaletteEntries = new StdVideoH265PredictorPaletteEntries(*_internal.pPredictorPaletteEntries);
        NativeUtils.Free(_internal.pPredictorPaletteEntries);
    }

    public StdVideoH265SpsFlags Flags { get; set; }
    public StdVideoH265ChromaFormatIdc Chroma_format_idc { get; set; }
    public uint Pic_width_in_luma_samples { get; set; }
    public uint Pic_height_in_luma_samples { get; set; }
    public byte Sps_video_parameter_set_id { get; set; }
    public byte Sps_max_sub_layers_minus1 { get; set; }
    public byte Sps_seq_parameter_set_id { get; set; }
    public byte Bit_depth_luma_minus8 { get; set; }
    public byte Bit_depth_chroma_minus8 { get; set; }
    public byte Log2_max_pic_order_cnt_lsb_minus4 { get; set; }
    public byte Log2_min_luma_coding_block_size_minus3 { get; set; }
    public byte Log2_diff_max_min_luma_coding_block_size { get; set; }
    public byte Log2_min_luma_transform_block_size_minus2 { get; set; }
    public byte Log2_diff_max_min_luma_transform_block_size { get; set; }
    public byte Max_transform_hierarchy_depth_inter { get; set; }
    public byte Max_transform_hierarchy_depth_intra { get; set; }
    public byte Num_short_term_ref_pic_sets { get; set; }
    public byte Num_long_term_ref_pics_sps { get; set; }
    public byte Pcm_sample_bit_depth_luma_minus1 { get; set; }
    public byte Pcm_sample_bit_depth_chroma_minus1 { get; set; }
    public byte Log2_min_pcm_luma_coding_block_size_minus3 { get; set; }
    public byte Log2_diff_max_min_pcm_luma_coding_block_size { get; set; }
    public byte Reserved1 { get; set; }
    public byte Reserved2 { get; set; }
    public byte Palette_max_size { get; set; }
    public byte Delta_palette_max_predictor_size { get; set; }
    public byte Motion_vector_resolution_control_idc { get; set; }
    public byte Sps_num_palette_predictor_initializers_minus1 { get; set; }
    public uint Conf_win_left_offset { get; set; }
    public uint Conf_win_right_offset { get; set; }
    public uint Conf_win_top_offset { get; set; }
    public uint Conf_win_bottom_offset { get; set; }
    public StdVideoH265ProfileTierLevel ProfileTierLevel { get; set; }
    public StdVideoH265DecPicBufMgr PDecPicBufMgr { get; set; }
    public StdVideoH265ScalingLists PScalingLists { get; set; }
    public StdVideoH265ShortTermRefPicSet PShortTermRefPicSet { get; set; }
    public StdVideoH265LongTermRefPicsSps PLongTermRefPicsSps { get; set; }
    public StdVideoH265SequenceParameterSetVui PSequenceParameterSetVui { get; set; }
    public StdVideoH265PredictorPaletteEntries PredictorPaletteEntries { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSet ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSet();
        if (Flags != null)
        {
            _internal.flags = Flags.ToNative();
        }
        _internal.chroma_format_idc = Chroma_format_idc;
        _internal.pic_width_in_luma_samples = Pic_width_in_luma_samples;
        _internal.pic_height_in_luma_samples = Pic_height_in_luma_samples;
        _internal.sps_video_parameter_set_id = Sps_video_parameter_set_id;
        _internal.sps_max_sub_layers_minus1 = Sps_max_sub_layers_minus1;
        _internal.sps_seq_parameter_set_id = Sps_seq_parameter_set_id;
        _internal.bit_depth_luma_minus8 = Bit_depth_luma_minus8;
        _internal.bit_depth_chroma_minus8 = Bit_depth_chroma_minus8;
        _internal.log2_max_pic_order_cnt_lsb_minus4 = Log2_max_pic_order_cnt_lsb_minus4;
        _internal.log2_min_luma_coding_block_size_minus3 = Log2_min_luma_coding_block_size_minus3;
        _internal.log2_diff_max_min_luma_coding_block_size = Log2_diff_max_min_luma_coding_block_size;
        _internal.log2_min_luma_transform_block_size_minus2 = Log2_min_luma_transform_block_size_minus2;
        _internal.log2_diff_max_min_luma_transform_block_size = Log2_diff_max_min_luma_transform_block_size;
        _internal.max_transform_hierarchy_depth_inter = Max_transform_hierarchy_depth_inter;
        _internal.max_transform_hierarchy_depth_intra = Max_transform_hierarchy_depth_intra;
        _internal.num_short_term_ref_pic_sets = Num_short_term_ref_pic_sets;
        _internal.num_long_term_ref_pics_sps = Num_long_term_ref_pics_sps;
        _internal.pcm_sample_bit_depth_luma_minus1 = Pcm_sample_bit_depth_luma_minus1;
        _internal.pcm_sample_bit_depth_chroma_minus1 = Pcm_sample_bit_depth_chroma_minus1;
        _internal.log2_min_pcm_luma_coding_block_size_minus3 = Log2_min_pcm_luma_coding_block_size_minus3;
        _internal.log2_diff_max_min_pcm_luma_coding_block_size = Log2_diff_max_min_pcm_luma_coding_block_size;
        _internal.reserved1 = Reserved1;
        _internal.reserved2 = Reserved2;
        _internal.palette_max_size = Palette_max_size;
        _internal.delta_palette_max_predictor_size = Delta_palette_max_predictor_size;
        _internal.motion_vector_resolution_control_idc = Motion_vector_resolution_control_idc;
        _internal.sps_num_palette_predictor_initializers_minus1 = Sps_num_palette_predictor_initializers_minus1;
        _internal.conf_win_left_offset = Conf_win_left_offset;
        _internal.conf_win_right_offset = Conf_win_right_offset;
        _internal.conf_win_top_offset = Conf_win_top_offset;
        _internal.conf_win_bottom_offset = Conf_win_bottom_offset;
        _pProfileTierLevel.Dispose();
        if (ProfileTierLevel != null)
        {
            var struct0 = ProfileTierLevel.ToNative();
            _pProfileTierLevel = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevel>(struct0);
            _internal.pProfileTierLevel = _pProfileTierLevel.Handle;
        }
        _pDecPicBufMgr.Dispose();
        if (PDecPicBufMgr != null)
        {
            var struct1 = PDecPicBufMgr.ToNative();
            _pDecPicBufMgr = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265DecPicBufMgr>(struct1);
            _internal.pDecPicBufMgr = _pDecPicBufMgr.Handle;
        }
        _pScalingLists.Dispose();
        if (PScalingLists != null)
        {
            var struct2 = PScalingLists.ToNative();
            _pScalingLists = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ScalingLists>(struct2);
            _internal.pScalingLists = _pScalingLists.Handle;
        }
        _pShortTermRefPicSet.Dispose();
        if (PShortTermRefPicSet != null)
        {
            var struct3 = PShortTermRefPicSet.ToNative();
            _pShortTermRefPicSet = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSet>(struct3);
            _internal.pShortTermRefPicSet = _pShortTermRefPicSet.Handle;
        }
        _pLongTermRefPicsSps.Dispose();
        if (PLongTermRefPicsSps != null)
        {
            var struct4 = PLongTermRefPicsSps.ToNative();
            _pLongTermRefPicsSps = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265LongTermRefPicsSps>(struct4);
            _internal.pLongTermRefPicsSps = _pLongTermRefPicsSps.Handle;
        }
        _pSequenceParameterSetVui.Dispose();
        if (PSequenceParameterSetVui != null)
        {
            var struct5 = PSequenceParameterSetVui.ToNative();
            _pSequenceParameterSetVui = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSetVui>(struct5);
            _internal.pSequenceParameterSetVui = _pSequenceParameterSetVui.Handle;
        }
        _pPredictorPaletteEntries.Dispose();
        if (PredictorPaletteEntries != null)
        {
            var struct6 = PredictorPaletteEntries.ToNative();
            _pPredictorPaletteEntries = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH265PredictorPaletteEntries>(struct6);
            _internal.pPredictorPaletteEntries = _pPredictorPaletteEntries.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pProfileTierLevel.Dispose();
        _pDecPicBufMgr.Dispose();
        _pScalingLists.Dispose();
        _pShortTermRefPicSet.Dispose();
        _pLongTermRefPicsSps.Dispose();
        _pSequenceParameterSetVui.Dispose();
        _pPredictorPaletteEntries.Dispose();
    }


    public static implicit operator StdVideoH265SequenceParameterSet(AdamantiumVulkan.Interop.StdVideoH265SequenceParameterSet s)
    {
        return new StdVideoH265SequenceParameterSet(s);
    }

}



