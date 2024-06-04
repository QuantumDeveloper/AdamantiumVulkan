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

public unsafe partial class StdVideoEncodeH264WeightTableFlags
{
    public StdVideoEncodeH264WeightTableFlags()
    {
    }

    public StdVideoEncodeH264WeightTableFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTableFlags _internal)
    {
        Luma_weight_l0_flag = _internal.luma_weight_l0_flag;
        Chroma_weight_l0_flag = _internal.chroma_weight_l0_flag;
        Luma_weight_l1_flag = _internal.luma_weight_l1_flag;
        Chroma_weight_l1_flag = _internal.chroma_weight_l1_flag;
    }

    public uint Luma_weight_l0_flag { get; set; }
    public uint Chroma_weight_l0_flag { get; set; }
    public uint Luma_weight_l1_flag { get; set; }
    public uint Chroma_weight_l1_flag { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTableFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTableFlags();
        _internal.luma_weight_l0_flag = Luma_weight_l0_flag;
        _internal.chroma_weight_l0_flag = Chroma_weight_l0_flag;
        _internal.luma_weight_l1_flag = Luma_weight_l1_flag;
        _internal.chroma_weight_l1_flag = Chroma_weight_l1_flag;
        return _internal;
    }

    public static implicit operator StdVideoEncodeH264WeightTableFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264WeightTableFlags s)
    {
        return new StdVideoEncodeH264WeightTableFlags(s);
    }

}



