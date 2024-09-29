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

public unsafe partial class StdVideoH265ShortTermRefPicSetFlags : QBDisposableObject
{
    public StdVideoH265ShortTermRefPicSetFlags()
    {
    }

    public StdVideoH265ShortTermRefPicSetFlags(AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSetFlags _internal)
    {
        Inter_ref_pic_set_prediction_flag = _internal.inter_ref_pic_set_prediction_flag;
        Delta_rps_sign = _internal.delta_rps_sign;
    }

    public uint Inter_ref_pic_set_prediction_flag { get; set; }
    public uint Delta_rps_sign { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSetFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSetFlags();
        if (Inter_ref_pic_set_prediction_flag != default)
        {
            _internal.inter_ref_pic_set_prediction_flag = Inter_ref_pic_set_prediction_flag;
        }
        if (Delta_rps_sign != default)
        {
            _internal.delta_rps_sign = Delta_rps_sign;
        }
        return _internal;
    }

    public static implicit operator StdVideoH265ShortTermRefPicSetFlags(AdamantiumVulkan.Interop.StdVideoH265ShortTermRefPicSetFlags s)
    {
        return new StdVideoH265ShortTermRefPicSetFlags(s);
    }

}



