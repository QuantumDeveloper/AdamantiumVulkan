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

public unsafe partial class StdVideoAV1FilmGrainFlags : QBDisposableObject
{
    public StdVideoAV1FilmGrainFlags()
    {
    }

    public StdVideoAV1FilmGrainFlags(AdamantiumVulkan.Interop.StdVideoAV1FilmGrainFlags _internal)
    {
        Chroma_scaling_from_luma = _internal.chroma_scaling_from_luma;
        Overlap_flag = _internal.overlap_flag;
        Clip_to_restricted_range = _internal.clip_to_restricted_range;
        Update_grain = _internal.update_grain;
        Reserved = _internal.reserved;
    }

    public uint Chroma_scaling_from_luma { get; set; }
    public uint Overlap_flag { get; set; }
    public uint Clip_to_restricted_range { get; set; }
    public uint Update_grain { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1FilmGrainFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1FilmGrainFlags();
        if (Chroma_scaling_from_luma != default)
        {
            _internal.chroma_scaling_from_luma = Chroma_scaling_from_luma;
        }
        if (Overlap_flag != default)
        {
            _internal.overlap_flag = Overlap_flag;
        }
        if (Clip_to_restricted_range != default)
        {
            _internal.clip_to_restricted_range = Clip_to_restricted_range;
        }
        if (Update_grain != default)
        {
            _internal.update_grain = Update_grain;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoAV1FilmGrainFlags(AdamantiumVulkan.Interop.StdVideoAV1FilmGrainFlags s)
    {
        return new StdVideoAV1FilmGrainFlags(s);
    }

}


