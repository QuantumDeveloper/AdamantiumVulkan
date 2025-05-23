// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class VideoEncodeAV1FrameSizeKHR : QBDisposableObject
{
    public VideoEncodeAV1FrameSizeKHR()
    {
    }

    public VideoEncodeAV1FrameSizeKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1FrameSizeKHR _internal)
    {
        IntraFrameSize = _internal.intraFrameSize;
        PredictiveFrameSize = _internal.predictiveFrameSize;
        BipredictiveFrameSize = _internal.bipredictiveFrameSize;
    }

    public uint IntraFrameSize { get; set; }
    public uint PredictiveFrameSize { get; set; }
    public uint BipredictiveFrameSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1FrameSizeKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1FrameSizeKHR();
        if (IntraFrameSize != default)
        {
            _internal.intraFrameSize = IntraFrameSize;
        }
        if (PredictiveFrameSize != default)
        {
            _internal.predictiveFrameSize = PredictiveFrameSize;
        }
        if (BipredictiveFrameSize != default)
        {
            _internal.bipredictiveFrameSize = BipredictiveFrameSize;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeAV1FrameSizeKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1FrameSizeKHR v)
    {
        return new VideoEncodeAV1FrameSizeKHR(v);
    }

}



