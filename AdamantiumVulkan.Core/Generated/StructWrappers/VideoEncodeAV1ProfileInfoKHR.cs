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

public unsafe partial class VideoEncodeAV1ProfileInfoKHR : QBDisposableObject
{
    public VideoEncodeAV1ProfileInfoKHR()
    {
    }

    public VideoEncodeAV1ProfileInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1ProfileInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        StdProfile = _internal.stdProfile;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public StdVideoAV1Profile StdProfile { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1ProfileInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1ProfileInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (StdProfile != default)
        {
            _internal.stdProfile = StdProfile;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeAV1ProfileInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeAV1ProfileInfoKHR v)
    {
        return new VideoEncodeAV1ProfileInfoKHR(v);
    }

}



