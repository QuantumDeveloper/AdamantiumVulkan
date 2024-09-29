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

public unsafe partial class VideoEncodeH264CapabilitiesKHR : QBDisposableObject
{
    public VideoEncodeH264CapabilitiesKHR()
    {
    }

    public VideoEncodeH264CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264CapabilitiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        MaxLevelIdc = _internal.maxLevelIdc;
        MaxSliceCount = _internal.maxSliceCount;
        MaxPPictureL0ReferenceCount = _internal.maxPPictureL0ReferenceCount;
        MaxBPictureL0ReferenceCount = _internal.maxBPictureL0ReferenceCount;
        MaxL1ReferenceCount = _internal.maxL1ReferenceCount;
        MaxTemporalLayerCount = _internal.maxTemporalLayerCount;
        ExpectDyadicTemporalLayerPattern = _internal.expectDyadicTemporalLayerPattern;
        MinQp = _internal.minQp;
        MaxQp = _internal.maxQp;
        PrefersGopRemainingFrames = _internal.prefersGopRemainingFrames;
        RequiresGopRemainingFrames = _internal.requiresGopRemainingFrames;
        StdSyntaxFlags = _internal.stdSyntaxFlags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeH264CapabilityFlagsKHR Flags { get; set; }
    public StdVideoH264LevelIdc MaxLevelIdc { get; set; }
    public uint MaxSliceCount { get; set; }
    public uint MaxPPictureL0ReferenceCount { get; set; }
    public uint MaxBPictureL0ReferenceCount { get; set; }
    public uint MaxL1ReferenceCount { get; set; }
    public uint MaxTemporalLayerCount { get; set; }
    public VkBool32 ExpectDyadicTemporalLayerPattern { get; set; }
    public int MinQp { get; set; }
    public int MaxQp { get; set; }
    public VkBool32 PrefersGopRemainingFrames { get; set; }
    public VkBool32 RequiresGopRemainingFrames { get; set; }
    public VkVideoEncodeH264StdFlagsKHR StdSyntaxFlags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH264CapabilitiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH264CapabilitiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (MaxLevelIdc != default)
        {
            _internal.maxLevelIdc = MaxLevelIdc;
        }
        if (MaxSliceCount != default)
        {
            _internal.maxSliceCount = MaxSliceCount;
        }
        if (MaxPPictureL0ReferenceCount != default)
        {
            _internal.maxPPictureL0ReferenceCount = MaxPPictureL0ReferenceCount;
        }
        if (MaxBPictureL0ReferenceCount != default)
        {
            _internal.maxBPictureL0ReferenceCount = MaxBPictureL0ReferenceCount;
        }
        if (MaxL1ReferenceCount != default)
        {
            _internal.maxL1ReferenceCount = MaxL1ReferenceCount;
        }
        if (MaxTemporalLayerCount != default)
        {
            _internal.maxTemporalLayerCount = MaxTemporalLayerCount;
        }
        if (ExpectDyadicTemporalLayerPattern != (uint)default)
        {
            _internal.expectDyadicTemporalLayerPattern = ExpectDyadicTemporalLayerPattern;
        }
        if (MinQp != default)
        {
            _internal.minQp = MinQp;
        }
        if (MaxQp != default)
        {
            _internal.maxQp = MaxQp;
        }
        if (PrefersGopRemainingFrames != (uint)default)
        {
            _internal.prefersGopRemainingFrames = PrefersGopRemainingFrames;
        }
        if (RequiresGopRemainingFrames != (uint)default)
        {
            _internal.requiresGopRemainingFrames = RequiresGopRemainingFrames;
        }
        if (StdSyntaxFlags != (uint)default)
        {
            _internal.stdSyntaxFlags = StdSyntaxFlags;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeH264CapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264CapabilitiesKHR v)
    {
        return new VideoEncodeH264CapabilitiesKHR(v);
    }

}


