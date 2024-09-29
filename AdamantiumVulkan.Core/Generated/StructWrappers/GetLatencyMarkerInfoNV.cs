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

public unsafe partial class GetLatencyMarkerInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkLatencyTimingsFrameReportNV> _pTimings;

    public GetLatencyMarkerInfoNV()
    {
    }

    public GetLatencyMarkerInfoNV(AdamantiumVulkan.Core.Interop.VkGetLatencyMarkerInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        TimingCount = _internal.timingCount;
        PTimings = new LatencyTimingsFrameReportNV(*_internal.pTimings);
        NativeUtils.Free(_internal.pTimings);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint TimingCount { get; set; }
    public LatencyTimingsFrameReportNV PTimings { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGetLatencyMarkerInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGetLatencyMarkerInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (TimingCount != default)
        {
            _internal.timingCount = TimingCount;
        }
        _pTimings.Dispose();
        if (PTimings != default)
        {
            var struct0 = PTimings.ToNative();
            _pTimings = new NativeStruct<AdamantiumVulkan.Core.Interop.VkLatencyTimingsFrameReportNV>(struct0);
            _internal.pTimings = _pTimings.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pTimings.Dispose();
    }


    public static implicit operator GetLatencyMarkerInfoNV(AdamantiumVulkan.Core.Interop.VkGetLatencyMarkerInfoNV g)
    {
        return new GetLatencyMarkerInfoNV(g);
    }

}


