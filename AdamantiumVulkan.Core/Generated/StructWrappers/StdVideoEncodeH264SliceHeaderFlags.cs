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

public unsafe partial class StdVideoEncodeH264SliceHeaderFlags : QBDisposableObject
{
    public StdVideoEncodeH264SliceHeaderFlags()
    {
    }

    public StdVideoEncodeH264SliceHeaderFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264SliceHeaderFlags _internal)
    {
        Direct_spatial_mv_pred_flag = _internal.direct_spatial_mv_pred_flag;
        Num_ref_idx_active_override_flag = _internal.num_ref_idx_active_override_flag;
        Reserved = _internal.reserved;
    }

    public uint Direct_spatial_mv_pred_flag { get; set; }
    public uint Num_ref_idx_active_override_flag { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264SliceHeaderFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264SliceHeaderFlags();
        if (Direct_spatial_mv_pred_flag != default)
        {
            _internal.direct_spatial_mv_pred_flag = Direct_spatial_mv_pred_flag;
        }
        if (Num_ref_idx_active_override_flag != default)
        {
            _internal.num_ref_idx_active_override_flag = Num_ref_idx_active_override_flag;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeH264SliceHeaderFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264SliceHeaderFlags s)
    {
        return new StdVideoEncodeH264SliceHeaderFlags(s);
    }

}



