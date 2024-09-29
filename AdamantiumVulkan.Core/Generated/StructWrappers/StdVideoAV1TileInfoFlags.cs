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

public unsafe partial class StdVideoAV1TileInfoFlags : QBDisposableObject
{
    public StdVideoAV1TileInfoFlags()
    {
    }

    public StdVideoAV1TileInfoFlags(AdamantiumVulkan.Interop.StdVideoAV1TileInfoFlags _internal)
    {
        Uniform_tile_spacing_flag = _internal.uniform_tile_spacing_flag;
        Reserved = _internal.reserved;
    }

    public uint Uniform_tile_spacing_flag { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1TileInfoFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1TileInfoFlags();
        if (Uniform_tile_spacing_flag != default)
        {
            _internal.uniform_tile_spacing_flag = Uniform_tile_spacing_flag;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoAV1TileInfoFlags(AdamantiumVulkan.Interop.StdVideoAV1TileInfoFlags s)
    {
        return new StdVideoAV1TileInfoFlags(s);
    }

}


