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

public unsafe partial class VideoEncodeQualityLevelPropertiesKHR : QBDisposableObject
{
    public VideoEncodeQualityLevelPropertiesKHR()
    {
    }

    public VideoEncodeQualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PreferredRateControlMode = _internal.preferredRateControlMode;
        PreferredRateControlLayerCount = _internal.preferredRateControlLayerCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VideoEncodeRateControlModeFlagBitsKHR PreferredRateControlMode { get; set; }
    public uint PreferredRateControlLayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelPropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PreferredRateControlMode != default)
        {
            _internal.preferredRateControlMode = PreferredRateControlMode;
        }
        if (PreferredRateControlLayerCount != default)
        {
            _internal.preferredRateControlLayerCount = PreferredRateControlLayerCount;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeQualityLevelPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelPropertiesKHR v)
    {
        return new VideoEncodeQualityLevelPropertiesKHR(v);
    }

}


