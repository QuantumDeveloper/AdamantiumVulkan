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

public unsafe partial class StdVideoEncodeH265LongTermRefPics : QBDisposableObject
{
    public StdVideoEncodeH265LongTermRefPics()
    {
    }

    public StdVideoEncodeH265LongTermRefPics(AdamantiumVulkan.Interop.StdVideoEncodeH265LongTermRefPics _internal)
    {
        Num_long_term_sps = _internal.num_long_term_sps;
        Num_long_term_pics = _internal.num_long_term_pics;
        Lt_idx_sps = NativeUtils.PointerToManagedArray(_internal.lt_idx_sps, 32);
        Poc_lsb_lt = NativeUtils.PointerToManagedArray(_internal.poc_lsb_lt, 16);
        Used_by_curr_pic_lt_flag = _internal.used_by_curr_pic_lt_flag;
        Delta_poc_msb_present_flag = NativeUtils.PointerToManagedArray(_internal.delta_poc_msb_present_flag, 48);
        Delta_poc_msb_cycle_lt = NativeUtils.PointerToManagedArray(_internal.delta_poc_msb_cycle_lt, 48);
    }

    public byte Num_long_term_sps { get; set; }
    public byte Num_long_term_pics { get; set; }
    public byte[] Lt_idx_sps { get; set; }
    public byte[] Poc_lsb_lt { get; set; }
    public ushort Used_by_curr_pic_lt_flag { get; set; }
    public byte[] Delta_poc_msb_present_flag { get; set; }
    public byte[] Delta_poc_msb_cycle_lt { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH265LongTermRefPics ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH265LongTermRefPics();
        if (Num_long_term_sps != default)
        {
            _internal.num_long_term_sps = Num_long_term_sps;
        }
        if (Num_long_term_pics != default)
        {
            _internal.num_long_term_pics = Num_long_term_pics;
        }
        if (Lt_idx_sps != default)
        {
            if (Lt_idx_sps.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Lt_idx_sps), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.lt_idx_sps, 32, Lt_idx_sps);
        }
        if (Poc_lsb_lt != default)
        {
            if (Poc_lsb_lt.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(Poc_lsb_lt), "Array is out of bounds. Size should not be more than 16");

            NativeUtils.PrimitiveToFixedArray(_internal.poc_lsb_lt, 16, Poc_lsb_lt);
        }
        if (Used_by_curr_pic_lt_flag != default)
        {
            _internal.used_by_curr_pic_lt_flag = Used_by_curr_pic_lt_flag;
        }
        if (Delta_poc_msb_present_flag != default)
        {
            if (Delta_poc_msb_present_flag.Length > 48)
                throw new System.ArgumentOutOfRangeException(nameof(Delta_poc_msb_present_flag), "Array is out of bounds. Size should not be more than 48");

            NativeUtils.PrimitiveToFixedArray(_internal.delta_poc_msb_present_flag, 48, Delta_poc_msb_present_flag);
        }
        if (Delta_poc_msb_cycle_lt != default)
        {
            if (Delta_poc_msb_cycle_lt.Length > 48)
                throw new System.ArgumentOutOfRangeException(nameof(Delta_poc_msb_cycle_lt), "Array is out of bounds. Size should not be more than 48");

            NativeUtils.PrimitiveToFixedArray(_internal.delta_poc_msb_cycle_lt, 48, Delta_poc_msb_cycle_lt);
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeH265LongTermRefPics(AdamantiumVulkan.Interop.StdVideoEncodeH265LongTermRefPics s)
    {
        return new StdVideoEncodeH265LongTermRefPics(s);
    }

}



