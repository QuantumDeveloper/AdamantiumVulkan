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

public unsafe partial class VideoEncodeH265RateControlInfoKHR : QBDisposableObject
{
    public VideoEncodeH265RateControlInfoKHR()
    {
    }

    public VideoEncodeH265RateControlInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        GopFrameCount = _internal.gopFrameCount;
        IdrPeriod = _internal.idrPeriod;
        ConsecutiveBFrameCount = _internal.consecutiveBFrameCount;
        SubLayerCount = _internal.subLayerCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeH265RateControlFlagsKHR Flags { get; set; }
    public uint GopFrameCount { get; set; }
    public uint IdrPeriod { get; set; }
    public uint ConsecutiveBFrameCount { get; set; }
    public uint SubLayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.gopFrameCount = GopFrameCount;
        _internal.idrPeriod = IdrPeriod;
        _internal.consecutiveBFrameCount = ConsecutiveBFrameCount;
        _internal.subLayerCount = SubLayerCount;
        return _internal;
    }

    public static implicit operator VideoEncodeH265RateControlInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlInfoKHR v)
    {
        return new VideoEncodeH265RateControlInfoKHR(v);
    }

}



