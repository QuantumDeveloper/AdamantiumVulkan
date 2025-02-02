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

public unsafe partial class VideoEncodeAV1QualityLevelPropertiesKHR : QBDisposableObject
{
    public VideoEncodeAV1QualityLevelPropertiesKHR()
    {
    }

    public VideoEncodeAV1QualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1QualityLevelPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PreferredRateControlFlags = _internal.preferredRateControlFlags;
        PreferredGopFrameCount = _internal.preferredGopFrameCount;
        PreferredKeyFramePeriod = _internal.preferredKeyFramePeriod;
        PreferredConsecutiveBipredictiveFrameCount = _internal.preferredConsecutiveBipredictiveFrameCount;
        PreferredTemporalLayerCount = _internal.preferredTemporalLayerCount;
        PreferredConstantQIndex = new VideoEncodeAV1QIndexKHR(_internal.preferredConstantQIndex);
        PreferredMaxSingleReferenceCount = _internal.preferredMaxSingleReferenceCount;
        PreferredSingleReferenceNameMask = _internal.preferredSingleReferenceNameMask;
        PreferredMaxUnidirectionalCompoundReferenceCount = _internal.preferredMaxUnidirectionalCompoundReferenceCount;
        PreferredMaxUnidirectionalCompoundGroup1ReferenceCount = _internal.preferredMaxUnidirectionalCompoundGroup1ReferenceCount;
        PreferredUnidirectionalCompoundReferenceNameMask = _internal.preferredUnidirectionalCompoundReferenceNameMask;
        PreferredMaxBidirectionalCompoundReferenceCount = _internal.preferredMaxBidirectionalCompoundReferenceCount;
        PreferredMaxBidirectionalCompoundGroup1ReferenceCount = _internal.preferredMaxBidirectionalCompoundGroup1ReferenceCount;
        PreferredMaxBidirectionalCompoundGroup2ReferenceCount = _internal.preferredMaxBidirectionalCompoundGroup2ReferenceCount;
        PreferredBidirectionalCompoundReferenceNameMask = _internal.preferredBidirectionalCompoundReferenceNameMask;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeAV1RateControlFlagsKHR PreferredRateControlFlags { get; set; }
    public uint PreferredGopFrameCount { get; set; }
    public uint PreferredKeyFramePeriod { get; set; }
    public uint PreferredConsecutiveBipredictiveFrameCount { get; set; }
    public uint PreferredTemporalLayerCount { get; set; }
    public VideoEncodeAV1QIndexKHR PreferredConstantQIndex { get; set; }
    public uint PreferredMaxSingleReferenceCount { get; set; }
    public uint PreferredSingleReferenceNameMask { get; set; }
    public uint PreferredMaxUnidirectionalCompoundReferenceCount { get; set; }
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount { get; set; }
    public uint PreferredUnidirectionalCompoundReferenceNameMask { get; set; }
    public uint PreferredMaxBidirectionalCompoundReferenceCount { get; set; }
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount { get; set; }
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount { get; set; }
    public uint PreferredBidirectionalCompoundReferenceNameMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1QualityLevelPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1QualityLevelPropertiesKHR();
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
        if (PreferredKeyFramePeriod != default)
        {
            _internal.preferredKeyFramePeriod = PreferredKeyFramePeriod;
        }
        if (PreferredConsecutiveBipredictiveFrameCount != default)
        {
            _internal.preferredConsecutiveBipredictiveFrameCount = PreferredConsecutiveBipredictiveFrameCount;
        }
        if (PreferredTemporalLayerCount != default)
        {
            _internal.preferredTemporalLayerCount = PreferredTemporalLayerCount;
        }
        if (PreferredConstantQIndex != default)
        {
            _internal.preferredConstantQIndex = PreferredConstantQIndex.ToNative();
        }
        if (PreferredMaxSingleReferenceCount != default)
        {
            _internal.preferredMaxSingleReferenceCount = PreferredMaxSingleReferenceCount;
        }
        if (PreferredSingleReferenceNameMask != default)
        {
            _internal.preferredSingleReferenceNameMask = PreferredSingleReferenceNameMask;
        }
        if (PreferredMaxUnidirectionalCompoundReferenceCount != default)
        {
            _internal.preferredMaxUnidirectionalCompoundReferenceCount = PreferredMaxUnidirectionalCompoundReferenceCount;
        }
        if (PreferredMaxUnidirectionalCompoundGroup1ReferenceCount != default)
        {
            _internal.preferredMaxUnidirectionalCompoundGroup1ReferenceCount = PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;
        }
        if (PreferredUnidirectionalCompoundReferenceNameMask != default)
        {
            _internal.preferredUnidirectionalCompoundReferenceNameMask = PreferredUnidirectionalCompoundReferenceNameMask;
        }
        if (PreferredMaxBidirectionalCompoundReferenceCount != default)
        {
            _internal.preferredMaxBidirectionalCompoundReferenceCount = PreferredMaxBidirectionalCompoundReferenceCount;
        }
        if (PreferredMaxBidirectionalCompoundGroup1ReferenceCount != default)
        {
            _internal.preferredMaxBidirectionalCompoundGroup1ReferenceCount = PreferredMaxBidirectionalCompoundGroup1ReferenceCount;
        }
        if (PreferredMaxBidirectionalCompoundGroup2ReferenceCount != default)
        {
            _internal.preferredMaxBidirectionalCompoundGroup2ReferenceCount = PreferredMaxBidirectionalCompoundGroup2ReferenceCount;
        }
        if (PreferredBidirectionalCompoundReferenceNameMask != default)
        {
            _internal.preferredBidirectionalCompoundReferenceNameMask = PreferredBidirectionalCompoundReferenceNameMask;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        PreferredConstantQIndex?.Dispose();
    }


    public static implicit operator VideoEncodeAV1QualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1QualityLevelPropertiesKHR v)
    {
        return new VideoEncodeAV1QualityLevelPropertiesKHR(v);
    }

}



