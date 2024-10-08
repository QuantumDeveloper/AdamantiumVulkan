// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;
using AdamantiumVulkan;
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class VideoDecodeH264DpbSlotInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoDecodeH264ReferenceInfo> _pStdReferenceInfo;

    public VideoDecodeH264DpbSlotInfoKHR()
    {
    }

    public VideoDecodeH264DpbSlotInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264DpbSlotInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PStdReferenceInfo = new StdVideoDecodeH264ReferenceInfo(*_internal.pStdReferenceInfo);
        NativeUtils.Free(_internal.pStdReferenceInfo);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoDecodeH264ReferenceInfo PStdReferenceInfo { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoDecodeH264DpbSlotInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoDecodeH264DpbSlotInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _pStdReferenceInfo.Dispose();
        if (PStdReferenceInfo != default)
        {
            var struct0 = PStdReferenceInfo.ToNative();
            _pStdReferenceInfo = new NativeStruct<AdamantiumVulkan.Interop.StdVideoDecodeH264ReferenceInfo>(struct0);
            _internal.pStdReferenceInfo = _pStdReferenceInfo.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStdReferenceInfo.Dispose();
    }


    public static implicit operator VideoDecodeH264DpbSlotInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264DpbSlotInfoKHR v)
    {
        return new VideoDecodeH264DpbSlotInfoKHR(v);
    }

}



