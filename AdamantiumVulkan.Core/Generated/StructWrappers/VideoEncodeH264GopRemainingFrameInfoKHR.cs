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

public unsafe partial class VideoEncodeH264GopRemainingFrameInfoKHR : QBDisposableObject
{
    public VideoEncodeH264GopRemainingFrameInfoKHR()
    {
    }

    public VideoEncodeH264GopRemainingFrameInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264GopRemainingFrameInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        UseGopRemainingFrames = _internal.useGopRemainingFrames;
        GopRemainingI = _internal.gopRemainingI;
        GopRemainingP = _internal.gopRemainingP;
        GopRemainingB = _internal.gopRemainingB;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 UseGopRemainingFrames { get; set; }
    public uint GopRemainingI { get; set; }
    public uint GopRemainingP { get; set; }
    public uint GopRemainingB { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH264GopRemainingFrameInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH264GopRemainingFrameInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.useGopRemainingFrames = UseGopRemainingFrames;
        _internal.gopRemainingI = GopRemainingI;
        _internal.gopRemainingP = GopRemainingP;
        _internal.gopRemainingB = GopRemainingB;
        return _internal;
    }

    public static implicit operator VideoEncodeH264GopRemainingFrameInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264GopRemainingFrameInfoKHR v)
    {
        return new VideoEncodeH264GopRemainingFrameInfoKHR(v);
    }

}



