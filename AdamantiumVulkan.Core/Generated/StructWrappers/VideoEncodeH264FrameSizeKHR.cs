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

public unsafe partial class VideoEncodeH264FrameSizeKHR : QBDisposableObject
{
    public VideoEncodeH264FrameSizeKHR()
    {
    }

    public VideoEncodeH264FrameSizeKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264FrameSizeKHR _internal)
    {
        FrameISize = _internal.frameISize;
        FramePSize = _internal.framePSize;
        FrameBSize = _internal.frameBSize;
    }

    public uint FrameISize { get; set; }
    public uint FramePSize { get; set; }
    public uint FrameBSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH264FrameSizeKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH264FrameSizeKHR();
        if (FrameISize != default)
        {
            _internal.frameISize = FrameISize;
        }
        if (FramePSize != default)
        {
            _internal.framePSize = FramePSize;
        }
        if (FrameBSize != default)
        {
            _internal.frameBSize = FrameBSize;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeH264FrameSizeKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264FrameSizeKHR v)
    {
        return new VideoEncodeH264FrameSizeKHR(v);
    }

}



