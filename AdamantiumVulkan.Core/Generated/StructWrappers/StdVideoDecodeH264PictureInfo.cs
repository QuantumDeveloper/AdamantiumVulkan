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

public unsafe partial class StdVideoDecodeH264PictureInfo : QBDisposableObject
{
    public StdVideoDecodeH264PictureInfo()
    {
    }

    public StdVideoDecodeH264PictureInfo(AdamantiumVulkan.Interop.StdVideoDecodeH264PictureInfo _internal)
    {
        Flags = new StdVideoDecodeH264PictureInfoFlags(_internal.flags);
        Seq_parameter_set_id = _internal.seq_parameter_set_id;
        Pic_parameter_set_id = _internal.pic_parameter_set_id;
        Reserved1 = _internal.reserved1;
        Reserved2 = _internal.reserved2;
        Frame_num = _internal.frame_num;
        Idr_pic_id = _internal.idr_pic_id;
        PicOrderCnt = NativeUtils.PointerToManagedArray(_internal.PicOrderCnt, 2);
    }

    public StdVideoDecodeH264PictureInfoFlags Flags { get; set; }
    public byte Seq_parameter_set_id { get; set; }
    public byte Pic_parameter_set_id { get; set; }
    public byte Reserved1 { get; set; }
    public byte Reserved2 { get; set; }
    public ushort Frame_num { get; set; }
    public ushort Idr_pic_id { get; set; }
    public int[] PicOrderCnt { get; set; }

    public AdamantiumVulkan.Interop.StdVideoDecodeH264PictureInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoDecodeH264PictureInfo();
        if (Flags != default)
        {
            _internal.flags = Flags.ToNative();
        }
        if (Seq_parameter_set_id != default)
        {
            _internal.seq_parameter_set_id = Seq_parameter_set_id;
        }
        if (Pic_parameter_set_id != default)
        {
            _internal.pic_parameter_set_id = Pic_parameter_set_id;
        }
        if (Reserved1 != default)
        {
            _internal.reserved1 = Reserved1;
        }
        if (Reserved2 != default)
        {
            _internal.reserved2 = Reserved2;
        }
        if (Frame_num != default)
        {
            _internal.frame_num = Frame_num;
        }
        if (Idr_pic_id != default)
        {
            _internal.idr_pic_id = Idr_pic_id;
        }
        if (PicOrderCnt != default)
        {
            if (PicOrderCnt.Length > 2)
                throw new System.ArgumentOutOfRangeException(nameof(PicOrderCnt), "Array is out of bounds. Size should not be more than 2");

            NativeUtils.PrimitiveToFixedArray(_internal.PicOrderCnt, 2, PicOrderCnt);
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Flags?.Dispose();
    }


    public static implicit operator StdVideoDecodeH264PictureInfo(AdamantiumVulkan.Interop.StdVideoDecodeH264PictureInfo s)
    {
        return new StdVideoDecodeH264PictureInfo(s);
    }

}



