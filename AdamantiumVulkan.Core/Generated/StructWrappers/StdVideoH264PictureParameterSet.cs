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

public unsafe partial class StdVideoH264PictureParameterSet : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH264ScalingLists> _pScalingLists;

    public StdVideoH264PictureParameterSet()
    {
    }

    public StdVideoH264PictureParameterSet(AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet _internal)
    {
        Flags = new StdVideoH264PpsFlags(_internal.flags);
        Seq_parameter_set_id = _internal.seq_parameter_set_id;
        Pic_parameter_set_id = _internal.pic_parameter_set_id;
        Num_ref_idx_l0_default_active_minus1 = _internal.num_ref_idx_l0_default_active_minus1;
        Num_ref_idx_l1_default_active_minus1 = _internal.num_ref_idx_l1_default_active_minus1;
        Weighted_bipred_idc = _internal.weighted_bipred_idc;
        Pic_init_qp_minus26 = _internal.pic_init_qp_minus26;
        Pic_init_qs_minus26 = _internal.pic_init_qs_minus26;
        Chroma_qp_index_offset = _internal.chroma_qp_index_offset;
        Second_chroma_qp_index_offset = _internal.second_chroma_qp_index_offset;
        PScalingLists = new StdVideoH264ScalingLists(*_internal.pScalingLists);
        NativeUtils.Free(_internal.pScalingLists);
    }

    public StdVideoH264PpsFlags Flags { get; set; }
    public byte Seq_parameter_set_id { get; set; }
    public byte Pic_parameter_set_id { get; set; }
    public byte Num_ref_idx_l0_default_active_minus1 { get; set; }
    public byte Num_ref_idx_l1_default_active_minus1 { get; set; }
    public StdVideoH264WeightedBipredIdc Weighted_bipred_idc { get; set; }
    public sbyte Pic_init_qp_minus26 { get; set; }
    public sbyte Pic_init_qs_minus26 { get; set; }
    public sbyte Chroma_qp_index_offset { get; set; }
    public sbyte Second_chroma_qp_index_offset { get; set; }
    public StdVideoH264ScalingLists PScalingLists { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet();
        if (Flags != null)
        {
            _internal.flags = Flags.ToNative();
        }
        _internal.seq_parameter_set_id = Seq_parameter_set_id;
        _internal.pic_parameter_set_id = Pic_parameter_set_id;
        _internal.num_ref_idx_l0_default_active_minus1 = Num_ref_idx_l0_default_active_minus1;
        _internal.num_ref_idx_l1_default_active_minus1 = Num_ref_idx_l1_default_active_minus1;
        _internal.weighted_bipred_idc = Weighted_bipred_idc;
        _internal.pic_init_qp_minus26 = Pic_init_qp_minus26;
        _internal.pic_init_qs_minus26 = Pic_init_qs_minus26;
        _internal.chroma_qp_index_offset = Chroma_qp_index_offset;
        _internal.second_chroma_qp_index_offset = Second_chroma_qp_index_offset;
        _pScalingLists.Dispose();
        if (PScalingLists != null)
        {
            var struct0 = PScalingLists.ToNative();
            _pScalingLists = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH264ScalingLists>(struct0);
            _internal.pScalingLists = _pScalingLists.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pScalingLists.Dispose();
    }


    public static implicit operator StdVideoH264PictureParameterSet(AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet s)
    {
        return new StdVideoH264PictureParameterSet(s);
    }

}



