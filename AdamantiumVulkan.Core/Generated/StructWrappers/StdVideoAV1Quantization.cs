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

public unsafe partial class StdVideoAV1Quantization : QBDisposableObject
{
    public StdVideoAV1Quantization()
    {
    }

    public StdVideoAV1Quantization(AdamantiumVulkan.Interop.StdVideoAV1Quantization _internal)
    {
        Flags = new StdVideoAV1QuantizationFlags(_internal.flags);
        Base_q_idx = _internal.base_q_idx;
        DeltaQYDc = _internal.DeltaQYDc;
        DeltaQUDc = _internal.DeltaQUDc;
        DeltaQUAc = _internal.DeltaQUAc;
        DeltaQVDc = _internal.DeltaQVDc;
        DeltaQVAc = _internal.DeltaQVAc;
        Qm_y = _internal.qm_y;
        Qm_u = _internal.qm_u;
        Qm_v = _internal.qm_v;
    }

    public StdVideoAV1QuantizationFlags Flags { get; set; }
    public byte Base_q_idx { get; set; }
    public sbyte DeltaQYDc { get; set; }
    public sbyte DeltaQUDc { get; set; }
    public sbyte DeltaQUAc { get; set; }
    public sbyte DeltaQVDc { get; set; }
    public sbyte DeltaQVAc { get; set; }
    public byte Qm_y { get; set; }
    public byte Qm_u { get; set; }
    public byte Qm_v { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1Quantization ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1Quantization();
        if (Flags != default)
        {
            _internal.flags = Flags.ToNative();
        }
        if (Base_q_idx != default)
        {
            _internal.base_q_idx = Base_q_idx;
        }
        if (DeltaQYDc != default)
        {
            _internal.DeltaQYDc = DeltaQYDc;
        }
        if (DeltaQUDc != default)
        {
            _internal.DeltaQUDc = DeltaQUDc;
        }
        if (DeltaQUAc != default)
        {
            _internal.DeltaQUAc = DeltaQUAc;
        }
        if (DeltaQVDc != default)
        {
            _internal.DeltaQVDc = DeltaQVDc;
        }
        if (DeltaQVAc != default)
        {
            _internal.DeltaQVAc = DeltaQVAc;
        }
        if (Qm_y != default)
        {
            _internal.qm_y = Qm_y;
        }
        if (Qm_u != default)
        {
            _internal.qm_u = Qm_u;
        }
        if (Qm_v != default)
        {
            _internal.qm_v = Qm_v;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Flags?.Dispose();
    }


    public static implicit operator StdVideoAV1Quantization(AdamantiumVulkan.Interop.StdVideoAV1Quantization s)
    {
        return new StdVideoAV1Quantization(s);
    }

}


