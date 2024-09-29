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

public unsafe partial class VideoDecodeH264CapabilitiesKHR : QBDisposableObject
{
    public VideoDecodeH264CapabilitiesKHR()
    {
    }

    public VideoDecodeH264CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264CapabilitiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxLevelIdc = _internal.maxLevelIdc;
        FieldOffsetGranularity = new Offset2D(_internal.fieldOffsetGranularity);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoH264LevelIdc MaxLevelIdc { get; set; }
    public Offset2D FieldOffsetGranularity { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoDecodeH264CapabilitiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoDecodeH264CapabilitiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxLevelIdc != default)
        {
            _internal.maxLevelIdc = MaxLevelIdc;
        }
        if (FieldOffsetGranularity != default)
        {
            _internal.fieldOffsetGranularity = FieldOffsetGranularity.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        FieldOffsetGranularity?.Dispose();
    }


    public static implicit operator VideoDecodeH264CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoDecodeH264CapabilitiesKHR v)
    {
        return new VideoDecodeH264CapabilitiesKHR(v);
    }

}



