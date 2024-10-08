// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;
using AdamantiumVulkan;

namespace AdamantiumVulkan.Core;

public unsafe partial class VideoDecodeH265CapabilitiesKHR : QBDisposableObject
{
    public VideoDecodeH265CapabilitiesKHR()
    {
    }

    public VideoDecodeH265CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH265CapabilitiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxLevelIdc = _internal.maxLevelIdc;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoH265LevelIdc MaxLevelIdc { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoDecodeH265CapabilitiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoDecodeH265CapabilitiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxLevelIdc != default)
        {
            _internal.maxLevelIdc = MaxLevelIdc;
        }
        return _internal;
    }

    public static implicit operator VideoDecodeH265CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH265CapabilitiesKHR v)
    {
        return new VideoDecodeH265CapabilitiesKHR(v);
    }

}



