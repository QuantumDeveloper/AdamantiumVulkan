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

public unsafe partial class StdVideoAV1LoopFilter : QBDisposableObject
{
    public StdVideoAV1LoopFilter()
    {
    }

    public StdVideoAV1LoopFilter(AdamantiumVulkan.Interop.StdVideoAV1LoopFilter _internal)
    {
        Flags = new StdVideoAV1LoopFilterFlags(_internal.flags);
        Loop_filter_level = NativeUtils.PointerToManagedArray(_internal.loop_filter_level, 4);
        Loop_filter_sharpness = _internal.loop_filter_sharpness;
        Update_ref_delta = _internal.update_ref_delta;
        Loop_filter_ref_deltas = new string((sbyte*)_internal.loop_filter_ref_deltas);
        Update_mode_delta = _internal.update_mode_delta;
        Loop_filter_mode_deltas = new string((sbyte*)_internal.loop_filter_mode_deltas);
    }

    public StdVideoAV1LoopFilterFlags Flags { get; set; }
    public byte[] Loop_filter_level { get; set; }
    public byte Loop_filter_sharpness { get; set; }
    public byte Update_ref_delta { get; set; }
    public string Loop_filter_ref_deltas { get; set; }
    public byte Update_mode_delta { get; set; }
    public string Loop_filter_mode_deltas { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1LoopFilter ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1LoopFilter();
        if (Flags != default)
        {
            _internal.flags = Flags.ToNative();
        }
        if (Loop_filter_level != default)
        {
            if (Loop_filter_level.Length > 4)
                throw new System.ArgumentOutOfRangeException(nameof(Loop_filter_level), "Array is out of bounds. Size should not be more than 4");

            NativeUtils.PrimitiveToFixedArray(_internal.loop_filter_level, 4, Loop_filter_level);
        }
        if (Loop_filter_sharpness != default)
        {
            _internal.loop_filter_sharpness = Loop_filter_sharpness;
        }
        if (Update_ref_delta != default)
        {
            _internal.update_ref_delta = Update_ref_delta;
        }
        if (Loop_filter_ref_deltas != default)
        {
            if (Loop_filter_ref_deltas.Length > 8)
                throw new System.ArgumentOutOfRangeException(nameof(Loop_filter_ref_deltas), "Array is out of bounds. Size should not be more than 8");

            NativeUtils.StringToFixedArray(_internal.loop_filter_ref_deltas, 8, Loop_filter_ref_deltas, false);
        }
        if (Update_mode_delta != default)
        {
            _internal.update_mode_delta = Update_mode_delta;
        }
        if (Loop_filter_mode_deltas != default)
        {
            if (Loop_filter_mode_deltas.Length > 2)
                throw new System.ArgumentOutOfRangeException(nameof(Loop_filter_mode_deltas), "Array is out of bounds. Size should not be more than 2");

            NativeUtils.StringToFixedArray(_internal.loop_filter_mode_deltas, 2, Loop_filter_mode_deltas, false);
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Flags?.Dispose();
    }


    public static implicit operator StdVideoAV1LoopFilter(AdamantiumVulkan.Interop.StdVideoAV1LoopFilter s)
    {
        return new StdVideoAV1LoopFilter(s);
    }

}



