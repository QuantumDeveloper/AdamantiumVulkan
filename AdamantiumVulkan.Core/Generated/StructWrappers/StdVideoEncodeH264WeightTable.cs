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

public unsafe partial class StdVideoEncodeH264WeightTable : QBDisposableObject
{
    public StdVideoEncodeH264WeightTable()
    {
    }

    public StdVideoEncodeH264WeightTable(AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTable _internal)
    {
        Flags = new StdVideoEncodeH264WeightTableFlags(_internal.flags);
        Luma_log2_weight_denom = _internal.luma_log2_weight_denom;
        Chroma_log2_weight_denom = _internal.chroma_log2_weight_denom;
        Luma_weight_l0 = new string((sbyte*)_internal.luma_weight_l0);
        Luma_offset_l0 = new string((sbyte*)_internal.luma_offset_l0);
        Chroma_weight_l0 = new string((sbyte*)_internal.chroma_weight_l0);
        Chroma_offset_l0 = new string((sbyte*)_internal.chroma_offset_l0);
        Luma_weight_l1 = new string((sbyte*)_internal.luma_weight_l1);
        Luma_offset_l1 = new string((sbyte*)_internal.luma_offset_l1);
        Chroma_weight_l1 = new string((sbyte*)_internal.chroma_weight_l1);
        Chroma_offset_l1 = new string((sbyte*)_internal.chroma_offset_l1);
    }

    public StdVideoEncodeH264WeightTableFlags Flags { get; set; }
    public byte Luma_log2_weight_denom { get; set; }
    public byte Chroma_log2_weight_denom { get; set; }
    public string Luma_weight_l0 { get; set; }
    public string Luma_offset_l0 { get; set; }
    public string Chroma_weight_l0 { get; set; }
    public string Chroma_offset_l0 { get; set; }
    public string Luma_weight_l1 { get; set; }
    public string Luma_offset_l1 { get; set; }
    public string Chroma_weight_l1 { get; set; }
    public string Chroma_offset_l1 { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTable ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTable();
        if (Flags != default)
        {
            _internal.flags = Flags.ToNative();
        }
        if (Luma_log2_weight_denom != default)
        {
            _internal.luma_log2_weight_denom = Luma_log2_weight_denom;
        }
        if (Chroma_log2_weight_denom != default)
        {
            _internal.chroma_log2_weight_denom = Chroma_log2_weight_denom;
        }
        if (Luma_weight_l0 != default)
        {
            if (Luma_weight_l0.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Luma_weight_l0), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.StringToFixedArray(_internal.luma_weight_l0, 32, Luma_weight_l0, false);
        }
        if (Luma_offset_l0 != default)
        {
            if (Luma_offset_l0.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Luma_offset_l0), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.StringToFixedArray(_internal.luma_offset_l0, 32, Luma_offset_l0, false);
        }
        if (Chroma_weight_l0 != default)
        {
            if (Chroma_weight_l0.Length > 64)
                throw new System.ArgumentOutOfRangeException(nameof(Chroma_weight_l0), "Array is out of bounds. Size should not be more than 64");

            NativeUtils.StringToFixedArray(_internal.chroma_weight_l0, 64, Chroma_weight_l0, false);
        }
        if (Chroma_offset_l0 != default)
        {
            if (Chroma_offset_l0.Length > 64)
                throw new System.ArgumentOutOfRangeException(nameof(Chroma_offset_l0), "Array is out of bounds. Size should not be more than 64");

            NativeUtils.StringToFixedArray(_internal.chroma_offset_l0, 64, Chroma_offset_l0, false);
        }
        if (Luma_weight_l1 != default)
        {
            if (Luma_weight_l1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Luma_weight_l1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.StringToFixedArray(_internal.luma_weight_l1, 32, Luma_weight_l1, false);
        }
        if (Luma_offset_l1 != default)
        {
            if (Luma_offset_l1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Luma_offset_l1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.StringToFixedArray(_internal.luma_offset_l1, 32, Luma_offset_l1, false);
        }
        if (Chroma_weight_l1 != default)
        {
            if (Chroma_weight_l1.Length > 64)
                throw new System.ArgumentOutOfRangeException(nameof(Chroma_weight_l1), "Array is out of bounds. Size should not be more than 64");

            NativeUtils.StringToFixedArray(_internal.chroma_weight_l1, 64, Chroma_weight_l1, false);
        }
        if (Chroma_offset_l1 != default)
        {
            if (Chroma_offset_l1.Length > 64)
                throw new System.ArgumentOutOfRangeException(nameof(Chroma_offset_l1), "Array is out of bounds. Size should not be more than 64");

            NativeUtils.StringToFixedArray(_internal.chroma_offset_l1, 64, Chroma_offset_l1, false);
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Flags?.Dispose();
    }


    public static implicit operator StdVideoEncodeH264WeightTable(AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTable s)
    {
        return new StdVideoEncodeH264WeightTable(s);
    }

}



