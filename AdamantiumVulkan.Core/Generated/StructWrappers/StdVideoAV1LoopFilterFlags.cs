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

public unsafe partial class StdVideoAV1LoopFilterFlags : QBDisposableObject
{
    public StdVideoAV1LoopFilterFlags()
    {
    }

    public StdVideoAV1LoopFilterFlags(AdamantiumVulkan.Interop.StdVideoAV1LoopFilterFlags _internal)
    {
        Loop_filter_delta_enabled = _internal.loop_filter_delta_enabled;
        Loop_filter_delta_update = _internal.loop_filter_delta_update;
        Reserved = _internal.reserved;
    }

    public uint Loop_filter_delta_enabled { get; set; }
    public uint Loop_filter_delta_update { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1LoopFilterFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1LoopFilterFlags();
        if (Loop_filter_delta_enabled != default)
        {
            _internal.loop_filter_delta_enabled = Loop_filter_delta_enabled;
        }
        if (Loop_filter_delta_update != default)
        {
            _internal.loop_filter_delta_update = Loop_filter_delta_update;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoAV1LoopFilterFlags(AdamantiumVulkan.Interop.StdVideoAV1LoopFilterFlags s)
    {
        return new StdVideoAV1LoopFilterFlags(s);
    }

}



