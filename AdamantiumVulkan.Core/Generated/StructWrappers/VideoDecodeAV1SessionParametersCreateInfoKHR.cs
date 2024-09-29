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

public unsafe partial class VideoDecodeAV1SessionParametersCreateInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoAV1SequenceHeader> _pStdSequenceHeader;

    public VideoDecodeAV1SessionParametersCreateInfoKHR()
    {
    }

    public VideoDecodeAV1SessionParametersCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeAV1SessionParametersCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PStdSequenceHeader = new StdVideoAV1SequenceHeader(*_internal.pStdSequenceHeader);
        NativeUtils.Free(_internal.pStdSequenceHeader);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoAV1SequenceHeader PStdSequenceHeader { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoDecodeAV1SessionParametersCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoDecodeAV1SessionParametersCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _pStdSequenceHeader.Dispose();
        if (PStdSequenceHeader != default)
        {
            var struct0 = PStdSequenceHeader.ToNative();
            _pStdSequenceHeader = new NativeStruct<AdamantiumVulkan.Interop.StdVideoAV1SequenceHeader>(struct0);
            _internal.pStdSequenceHeader = _pStdSequenceHeader.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStdSequenceHeader.Dispose();
    }


    public static implicit operator VideoDecodeAV1SessionParametersCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeAV1SessionParametersCreateInfoKHR v)
    {
        return new VideoDecodeAV1SessionParametersCreateInfoKHR(v);
    }

}



