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

public unsafe partial class VideoEncodeH265RateControlLayerInfoKHR : QBDisposableObject
{
    public VideoEncodeH265RateControlLayerInfoKHR()
    {
    }

    public VideoEncodeH265RateControlLayerInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlLayerInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        UseMinQp = _internal.useMinQp;
        MinQp = new VideoEncodeH265QpKHR(_internal.minQp);
        UseMaxQp = _internal.useMaxQp;
        MaxQp = new VideoEncodeH265QpKHR(_internal.maxQp);
        UseMaxFrameSize = _internal.useMaxFrameSize;
        MaxFrameSize = new VideoEncodeH265FrameSizeKHR(_internal.maxFrameSize);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 UseMinQp { get; set; }
    public VideoEncodeH265QpKHR MinQp { get; set; }
    public VkBool32 UseMaxQp { get; set; }
    public VideoEncodeH265QpKHR MaxQp { get; set; }
    public VkBool32 UseMaxFrameSize { get; set; }
    public VideoEncodeH265FrameSizeKHR MaxFrameSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlLayerInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlLayerInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (UseMinQp != (uint)default)
        {
            _internal.useMinQp = UseMinQp;
        }
        if (MinQp != default)
        {
            _internal.minQp = MinQp.ToNative();
        }
        if (UseMaxQp != (uint)default)
        {
            _internal.useMaxQp = UseMaxQp;
        }
        if (MaxQp != default)
        {
            _internal.maxQp = MaxQp.ToNative();
        }
        if (UseMaxFrameSize != (uint)default)
        {
            _internal.useMaxFrameSize = UseMaxFrameSize;
        }
        if (MaxFrameSize != default)
        {
            _internal.maxFrameSize = MaxFrameSize.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        MinQp?.Dispose();
        MaxQp?.Dispose();
        MaxFrameSize?.Dispose();
    }


    public static implicit operator VideoEncodeH265RateControlLayerInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH265RateControlLayerInfoKHR v)
    {
        return new VideoEncodeH265RateControlLayerInfoKHR(v);
    }

}



