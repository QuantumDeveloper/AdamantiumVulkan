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

public unsafe partial class StdVideoAV1TimingInfoFlags : QBDisposableObject
{
    public StdVideoAV1TimingInfoFlags()
    {
    }

    public StdVideoAV1TimingInfoFlags(AdamantiumVulkan.Interop.StdVideoAV1TimingInfoFlags _internal)
    {
        Equal_picture_interval = _internal.equal_picture_interval;
        Reserved = _internal.reserved;
    }

    public uint Equal_picture_interval { get; set; }
    public uint Reserved { get; set; }

    public AdamantiumVulkan.Interop.StdVideoAV1TimingInfoFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoAV1TimingInfoFlags();
        if (Equal_picture_interval != default)
        {
            _internal.equal_picture_interval = Equal_picture_interval;
        }
        if (Reserved != default)
        {
            _internal.reserved = Reserved;
        }
        return _internal;
    }

    public static implicit operator StdVideoAV1TimingInfoFlags(AdamantiumVulkan.Interop.StdVideoAV1TimingInfoFlags s)
    {
        return new StdVideoAV1TimingInfoFlags(s);
    }

}



