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

public unsafe partial class StdVideoEncodeH264PictureInfo : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoEncodeH264ReferenceListsInfo> _pRefLists;

    public StdVideoEncodeH264PictureInfo()
    {
    }

    public StdVideoEncodeH264PictureInfo(AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfo _internal)
    {
        Flags = new StdVideoEncodeH264PictureInfoFlags(_internal.flags);
        Seq_parameter_set_id = _internal.seq_parameter_set_id;
        Pic_parameter_set_id = _internal.pic_parameter_set_id;
        Idr_pic_id = _internal.idr_pic_id;
        Primary_pic_type = _internal.primary_pic_type;
        Frame_num = _internal.frame_num;
        PicOrderCnt = _internal.PicOrderCnt;
        Temporal_id = _internal.temporal_id;
        Reserved1 = NativeUtils.PointerToManagedArray(_internal.reserved1, 3);
        PRefLists = new StdVideoEncodeH264ReferenceListsInfo(*_internal.pRefLists);
        NativeUtils.Free(_internal.pRefLists);
    }

    public StdVideoEncodeH264PictureInfoFlags Flags { get; set; }
    public byte Seq_parameter_set_id { get; set; }
    public byte Pic_parameter_set_id { get; set; }
    public ushort Idr_pic_id { get; set; }
    public StdVideoH264PictureType Primary_pic_type { get; set; }
    public uint Frame_num { get; set; }
    public int PicOrderCnt { get; set; }
    public byte Temporal_id { get; set; }
    public byte[] Reserved1 { get; set; }
    public StdVideoEncodeH264ReferenceListsInfo PRefLists { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfo();
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
        if (Idr_pic_id != default)
        {
            _internal.idr_pic_id = Idr_pic_id;
        }
        if (Primary_pic_type != default)
        {
            _internal.primary_pic_type = Primary_pic_type;
        }
        if (Frame_num != default)
        {
            _internal.frame_num = Frame_num;
        }
        if (PicOrderCnt != default)
        {
            _internal.PicOrderCnt = PicOrderCnt;
        }
        if (Temporal_id != default)
        {
            _internal.temporal_id = Temporal_id;
        }
        if (Reserved1 != default)
        {
            if (Reserved1.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(Reserved1), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.reserved1, 3, Reserved1);
        }
        _pRefLists.Dispose();
        if (PRefLists != default)
        {
            var struct0 = PRefLists.ToNative();
            _pRefLists = new NativeStruct<AdamantiumVulkan.Interop.StdVideoEncodeH264ReferenceListsInfo>(struct0);
            _internal.pRefLists = _pRefLists.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pRefLists.Dispose();
        Flags?.Dispose();
    }


    public static implicit operator StdVideoEncodeH264PictureInfo(AdamantiumVulkan.Interop.StdVideoEncodeH264PictureInfo s)
    {
        return new StdVideoEncodeH264PictureInfo(s);
    }

}


