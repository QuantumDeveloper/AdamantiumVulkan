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

public unsafe partial class VideoEncodeUsageInfoKHR : QBDisposableObject
{
    public VideoEncodeUsageInfoKHR()
    {
    }

    public VideoEncodeUsageInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeUsageInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VideoUsageHints = _internal.videoUsageHints;
        VideoContentHints = _internal.videoContentHints;
        TuningMode = _internal.tuningMode;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeUsageFlagsKHR VideoUsageHints { get; set; }
    public VkVideoEncodeContentFlagsKHR VideoContentHints { get; set; }
    public VideoEncodeTuningModeKHR TuningMode { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeUsageInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeUsageInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (VideoUsageHints != (uint)default)
        {
            _internal.videoUsageHints = VideoUsageHints;
        }
        if (VideoContentHints != (uint)default)
        {
            _internal.videoContentHints = VideoContentHints;
        }
        if (TuningMode != default)
        {
            _internal.tuningMode = TuningMode;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeUsageInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeUsageInfoKHR v)
    {
        return new VideoEncodeUsageInfoKHR(v);
    }

}



