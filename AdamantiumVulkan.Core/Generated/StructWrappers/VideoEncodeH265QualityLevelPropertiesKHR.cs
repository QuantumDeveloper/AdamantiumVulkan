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

public unsafe partial class VideoEncodeH265QualityLevelPropertiesKHR : QBDisposableObject
{
    public VideoEncodeH265QualityLevelPropertiesKHR()
    {
    }

    public VideoEncodeH265QualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265QualityLevelPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PreferredRateControlFlags = _internal.preferredRateControlFlags;
        PreferredGopFrameCount = _internal.preferredGopFrameCount;
        PreferredIdrPeriod = _internal.preferredIdrPeriod;
        PreferredConsecutiveBFrameCount = _internal.preferredConsecutiveBFrameCount;
        PreferredSubLayerCount = _internal.preferredSubLayerCount;
        PreferredConstantQp = new VideoEncodeH265QpKHR(_internal.preferredConstantQp);
        PreferredMaxL0ReferenceCount = _internal.preferredMaxL0ReferenceCount;
        PreferredMaxL1ReferenceCount = _internal.preferredMaxL1ReferenceCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags { get; set; }
    public uint PreferredGopFrameCount { get; set; }
    public uint PreferredIdrPeriod { get; set; }
    public uint PreferredConsecutiveBFrameCount { get; set; }
    public uint PreferredSubLayerCount { get; set; }
    public VideoEncodeH265QpKHR PreferredConstantQp { get; set; }
    public uint PreferredMaxL0ReferenceCount { get; set; }
    public uint PreferredMaxL1ReferenceCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH265QualityLevelPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH265QualityLevelPropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PreferredRateControlFlags != (uint)default)
        {
            _internal.preferredRateControlFlags = PreferredRateControlFlags;
        }
        if (PreferredGopFrameCount != default)
        {
            _internal.preferredGopFrameCount = PreferredGopFrameCount;
        }
        if (PreferredIdrPeriod != default)
        {
            _internal.preferredIdrPeriod = PreferredIdrPeriod;
        }
        if (PreferredConsecutiveBFrameCount != default)
        {
            _internal.preferredConsecutiveBFrameCount = PreferredConsecutiveBFrameCount;
        }
        if (PreferredSubLayerCount != default)
        {
            _internal.preferredSubLayerCount = PreferredSubLayerCount;
        }
        if (PreferredConstantQp != default)
        {
            _internal.preferredConstantQp = PreferredConstantQp.ToNative();
        }
        if (PreferredMaxL0ReferenceCount != default)
        {
            _internal.preferredMaxL0ReferenceCount = PreferredMaxL0ReferenceCount;
        }
        if (PreferredMaxL1ReferenceCount != default)
        {
            _internal.preferredMaxL1ReferenceCount = PreferredMaxL1ReferenceCount;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        PreferredConstantQp?.Dispose();
    }


    public static implicit operator VideoEncodeH265QualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265QualityLevelPropertiesKHR v)
    {
        return new VideoEncodeH265QualityLevelPropertiesKHR(v);
    }

}



