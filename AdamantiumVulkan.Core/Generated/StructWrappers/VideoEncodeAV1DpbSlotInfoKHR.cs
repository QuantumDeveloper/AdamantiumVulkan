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

public unsafe partial class VideoEncodeAV1DpbSlotInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoEncodeAV1ReferenceInfo> _pStdReferenceInfo;

    public VideoEncodeAV1DpbSlotInfoKHR()
    {
    }

    public VideoEncodeAV1DpbSlotInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1DpbSlotInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PStdReferenceInfo = new StdVideoEncodeAV1ReferenceInfo(*_internal.pStdReferenceInfo);
        NativeUtils.Free(_internal.pStdReferenceInfo);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoEncodeAV1ReferenceInfo PStdReferenceInfo { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1DpbSlotInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1DpbSlotInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _pStdReferenceInfo.Dispose();
        if (PStdReferenceInfo != default)
        {
            var struct0 = PStdReferenceInfo.ToNative();
            _pStdReferenceInfo = new NativeStruct<AdamantiumVulkan.Interop.StdVideoEncodeAV1ReferenceInfo>(struct0);
            _internal.pStdReferenceInfo = _pStdReferenceInfo.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStdReferenceInfo.Dispose();
    }


    public static implicit operator VideoEncodeAV1DpbSlotInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1DpbSlotInfoKHR v)
    {
        return new VideoEncodeAV1DpbSlotInfoKHR(v);
    }

}



