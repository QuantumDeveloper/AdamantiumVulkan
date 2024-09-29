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

public unsafe partial class VideoEncodeRateControlLayerInfoKHR : QBDisposableObject
{
    public VideoEncodeRateControlLayerInfoKHR()
    {
    }

    public VideoEncodeRateControlLayerInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeRateControlLayerInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AverageBitrate = _internal.averageBitrate;
        MaxBitrate = _internal.maxBitrate;
        FrameRateNumerator = _internal.frameRateNumerator;
        FrameRateDenominator = _internal.frameRateDenominator;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ulong AverageBitrate { get; set; }
    public ulong MaxBitrate { get; set; }
    public uint FrameRateNumerator { get; set; }
    public uint FrameRateDenominator { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeRateControlLayerInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeRateControlLayerInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (AverageBitrate != default)
        {
            _internal.averageBitrate = AverageBitrate;
        }
        if (MaxBitrate != default)
        {
            _internal.maxBitrate = MaxBitrate;
        }
        if (FrameRateNumerator != default)
        {
            _internal.frameRateNumerator = FrameRateNumerator;
        }
        if (FrameRateDenominator != default)
        {
            _internal.frameRateDenominator = FrameRateDenominator;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeRateControlLayerInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeRateControlLayerInfoKHR v)
    {
        return new VideoEncodeRateControlLayerInfoKHR(v);
    }

}


