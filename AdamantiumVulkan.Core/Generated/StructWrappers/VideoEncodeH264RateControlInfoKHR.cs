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

public unsafe partial class VideoEncodeH264RateControlInfoKHR : QBDisposableObject
{
    public VideoEncodeH264RateControlInfoKHR()
    {
    }

    public VideoEncodeH264RateControlInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264RateControlInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        GopFrameCount = _internal.gopFrameCount;
        IdrPeriod = _internal.idrPeriod;
        ConsecutiveBFrameCount = _internal.consecutiveBFrameCount;
        TemporalLayerCount = _internal.temporalLayerCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeH264RateControlFlagsKHR Flags { get; set; }
    public uint GopFrameCount { get; set; }
    public uint IdrPeriod { get; set; }
    public uint ConsecutiveBFrameCount { get; set; }
    public uint TemporalLayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH264RateControlInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH264RateControlInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (GopFrameCount != default)
        {
            _internal.gopFrameCount = GopFrameCount;
        }
        if (IdrPeriod != default)
        {
            _internal.idrPeriod = IdrPeriod;
        }
        if (ConsecutiveBFrameCount != default)
        {
            _internal.consecutiveBFrameCount = ConsecutiveBFrameCount;
        }
        if (TemporalLayerCount != default)
        {
            _internal.temporalLayerCount = TemporalLayerCount;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeH264RateControlInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264RateControlInfoKHR v)
    {
        return new VideoEncodeH264RateControlInfoKHR(v);
    }

}



