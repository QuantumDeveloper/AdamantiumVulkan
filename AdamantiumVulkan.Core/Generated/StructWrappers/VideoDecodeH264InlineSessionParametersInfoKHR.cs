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

public unsafe partial class VideoDecodeH264InlineSessionParametersInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet> _pStdSPS;

    private NativeStruct<AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet> _pStdPPS;

    public VideoDecodeH264InlineSessionParametersInfoKHR()
    {
    }

    public VideoDecodeH264InlineSessionParametersInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264InlineSessionParametersInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PStdSPS = new StdVideoH264SequenceParameterSet(*_internal.pStdSPS);
        NativeUtils.Free(_internal.pStdSPS);
        PStdPPS = new StdVideoH264PictureParameterSet(*_internal.pStdPPS);
        NativeUtils.Free(_internal.pStdPPS);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoH264SequenceParameterSet PStdSPS { get; set; }
    public StdVideoH264PictureParameterSet PStdPPS { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoDecodeH264InlineSessionParametersInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoDecodeH264InlineSessionParametersInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _pStdSPS.Dispose();
        if (PStdSPS != default)
        {
            var struct0 = PStdSPS.ToNative();
            _pStdSPS = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet>(struct0);
            _internal.pStdSPS = _pStdSPS.Handle;
        }
        _pStdPPS.Dispose();
        if (PStdPPS != default)
        {
            var struct1 = PStdPPS.ToNative();
            _pStdPPS = new NativeStruct<AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet>(struct1);
            _internal.pStdPPS = _pStdPPS.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStdSPS.Dispose();
        _pStdPPS.Dispose();
    }


    public static implicit operator VideoDecodeH264InlineSessionParametersInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264InlineSessionParametersInfoKHR v)
    {
        return new VideoDecodeH264InlineSessionParametersInfoKHR(v);
    }

}



