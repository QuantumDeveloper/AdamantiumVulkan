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

public unsafe partial class VideoEncodeQualityLevelInfoKHR : QBDisposableObject
{
    public VideoEncodeQualityLevelInfoKHR()
    {
    }

    public VideoEncodeQualityLevelInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        QualityLevel = _internal.qualityLevel;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint QualityLevel { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (QualityLevel != default)
        {
            _internal.qualityLevel = QualityLevel;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeQualityLevelInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeQualityLevelInfoKHR v)
    {
        return new VideoEncodeQualityLevelInfoKHR(v);
    }

}



