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

public unsafe partial class StdVideoH265SubLayerHrdParameters : QBDisposableObject
{
    public StdVideoH265SubLayerHrdParameters()
    {
    }

    public StdVideoH265SubLayerHrdParameters(AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters _internal)
    {
        Bit_rate_value_minus1 = NativeUtils.PointerToManagedArray(_internal.bit_rate_value_minus1, 32);
        Cpb_size_value_minus1 = NativeUtils.PointerToManagedArray(_internal.cpb_size_value_minus1, 32);
        Cpb_size_du_value_minus1 = NativeUtils.PointerToManagedArray(_internal.cpb_size_du_value_minus1, 32);
        Bit_rate_du_value_minus1 = NativeUtils.PointerToManagedArray(_internal.bit_rate_du_value_minus1, 32);
        Cbr_flag = _internal.cbr_flag;
    }

    public uint[] Bit_rate_value_minus1 { get; set; }
    public uint[] Cpb_size_value_minus1 { get; set; }
    public uint[] Cpb_size_du_value_minus1 { get; set; }
    public uint[] Bit_rate_du_value_minus1 { get; set; }
    public uint Cbr_flag { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters();
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
        if (Cpb_size_du_value_minus1 != default)
        {
            if (Cpb_size_du_value_minus1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Cpb_size_du_value_minus1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.cpb_size_du_value_minus1, 32, Cpb_size_du_value_minus1);
        }
        if (Bit_rate_du_value_minus1 != default)
        {
            if (Bit_rate_du_value_minus1.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(Bit_rate_du_value_minus1), "Array is out of bounds. Size should not be more than 32");

            NativeUtils.PrimitiveToFixedArray(_internal.bit_rate_du_value_minus1, 32, Bit_rate_du_value_minus1);
        }
        if (Cbr_flag != default)
        {
            _internal.cbr_flag = Cbr_flag;
        }
        return _internal;
    }

    public static implicit operator StdVideoH265SubLayerHrdParameters(AdamantiumVulkan.Interop.StdVideoH265SubLayerHrdParameters s)
    {
        return new StdVideoH265SubLayerHrdParameters(s);
    }

}


