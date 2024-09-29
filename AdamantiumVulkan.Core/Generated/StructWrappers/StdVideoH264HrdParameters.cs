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

public unsafe partial class StdVideoH264HrdParameters : QBDisposableObject
{
    public StdVideoH264HrdParameters()
    {
    }

    public StdVideoH264HrdParameters(AdamantiumVulkan.Interop.StdVideoH264HrdParameters _internal)
    {
        Cpb_cnt_minus1 = _internal.cpb_cnt_minus1;
        Bit_rate_scale = _internal.bit_rate_scale;
        Cpb_size_scale = _internal.cpb_size_scale;
        Reserved1 = _internal.reserved1;
        Bit_rate_value_minus1 = NativeUtils.PointerToManagedArray(_internal.bit_rate_value_minus1, 32);
        Cpb_size_value_minus1 = NativeUtils.PointerToManagedArray(_internal.cpb_size_value_minus1, 32);
        Cbr_flag = NativeUtils.PointerToManagedArray(_internal.cbr_flag, 32);
        Initial_cpb_removal_delay_length_minus1 = _internal.initial_cpb_removal_delay_length_minus1;
        Cpb_removal_delay_length_minus1 = _internal.cpb_removal_delay_length_minus1;
        Dpb_output_delay_length_minus1 = _internal.dpb_output_delay_length_minus1;
        Time_offset_length = _internal.time_offset_length;
    }

    public byte Cpb_cnt_minus1 { get; set; }
    public byte Bit_rate_scale { get; set; }
    public byte Cpb_size_scale { get; set; }
    public byte Reserved1 { get; set; }
    public uint[] Bit_rate_value_minus1 { get; set; }
    public uint[] Cpb_size_value_minus1 { get; set; }
    public byte[] Cbr_flag { get; set; }
    public uint Initial_cpb_removal_delay_length_minus1 { get; set; }
    public uint Cpb_removal_delay_length_minus1 { get; set; }
    public uint Dpb_output_delay_length_minus1 { get; set; }
    public uint Time_offset_length { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH264HrdParameters ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH264HrdParameters();
        if (Cpb_cnt_minus1 != default)
        {
            _internal.cpb_cnt_minus1 = Cpb_cnt_minus1;
        }
        if (Bit_rate_scale != default)
        {
            _internal.bit_rate_scale = Bit_rate_scale;
        }
        if (Cpb_size_scale != default)
        {
            _internal.cpb_size_scale = Cpb_size_scale;
        }
        if (Reserved1 != default)
        {
            _internal.reserved1 = Reserved1;
        }
        if (Bit_rate_value_minus1 != default)
        {
            if (Bit_rate_value_minus1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Bit_rate_value_minus1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.bit_rate_value_minus1, 32, Bit_rate_value_minus1);
        }
        if (Cpb_size_value_minus1 != default)
        {
            if (Cpb_size_value_minus1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Cpb_size_value_minus1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.cpb_size_value_minus1, 32, Cpb_size_value_minus1);
        }
        if (Cbr_flag != default)
        {
            if (Cbr_flag.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Cbr_flag), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.cbr_flag, 32, Cbr_flag);
        }
        if (Initial_cpb_removal_delay_length_minus1 != default)
        {
            _internal.initial_cpb_removal_delay_length_minus1 = Initial_cpb_removal_delay_length_minus1;
        }
        if (Cpb_removal_delay_length_minus1 != default)
        {
            _internal.cpb_removal_delay_length_minus1 = Cpb_removal_delay_length_minus1;
        }
        if (Dpb_output_delay_length_minus1 != default)
        {
            _internal.dpb_output_delay_length_minus1 = Dpb_output_delay_length_minus1;
        }
        if (Time_offset_length != default)
        {
            _internal.time_offset_length = Time_offset_length;
        }
        return _internal;
    }

    public static implicit operator StdVideoH264HrdParameters(AdamantiumVulkan.Interop.StdVideoH264HrdParameters s)
    {
        return new StdVideoH264HrdParameters(s);
    }

}


