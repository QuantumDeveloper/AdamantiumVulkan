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

public unsafe partial class StdVideoEncodeH264PictureInfoFlags : QBDisposableObject
{
    public StdVideoEncodeH264PictureInfoFlags()
    {
    }

    public StdVideoEncodeH264PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfoFlags _internal)
    {
        IdrPicFlag = _internal.IdrPicFlag;
        Is_reference = _internal.is_reference;
        No_output_of_prior_pics_flag = _internal.no_output_of_prior_pics_flag;
        Long_term_reference_flag = _internal.long_term_reference_flag;
        Adaptive_ref_pic_marking_mode_flag = _internal.adaptive_ref_pic_marking_mode_flag;
        Reserved = _internal.reserved;
    }

    public uint IdrPicFlag { get; set; }
    public uint Is_reference { get; set; }
    public uint No_output_of_prior_pics_flag { get; set; }
    public uint Long_term_reference_flag { get; set; }
    public uint Adaptive_ref_pic_marking_mode_flag { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfoFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfoFlags();
        if (IdrPicFlag != default)
        {
            _internal.IdrPicFlag = IdrPicFlag;
        }
        if (Is_reference != default)
        {
            _internal.is_reference = Is_reference;
        }
        if (No_output_of_prior_pics_flag != default)
        {
            _internal.no_output_of_prior_pics_flag = No_output_of_prior_pics_flag;
        }
        if (Long_term_reference_flag != default)
        {
            _internal.long_term_reference_flag = Long_term_reference_flag;
        }
        if (Adaptive_ref_pic_marking_mode_flag != default)
        {
            _internal.adaptive_ref_pic_marking_mode_flag = Adaptive_ref_pic_marking_mode_flag;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeH264PictureInfoFlags(AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfoFlags s)
    {
        return new StdVideoEncodeH264PictureInfoFlags(s);
    }

}



