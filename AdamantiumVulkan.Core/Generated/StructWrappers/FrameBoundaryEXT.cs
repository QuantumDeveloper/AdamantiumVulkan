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

public unsafe partial class FrameBoundaryEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkImage_T> _pImages;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkBuffer_T> _pBuffers;

    public FrameBoundaryEXT()
    {
    }

    public FrameBoundaryEXT(AdamantiumVulkan.Core.Interop.VkFrameBoundaryEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        FrameID = _internal.frameID;
        ImageCount = _internal.imageCount;
        PImages = new Image(*_internal.pImages);
        NativeUtils.Free(_internal.pImages);
        BufferCount = _internal.bufferCount;
        PBuffers = new Buffer(*_internal.pBuffers);
        NativeUtils.Free(_internal.pBuffers);
        TagName = _internal.tagName;
        TagSize = _internal.tagSize;
        PTag = _internal.pTag;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkFrameBoundaryFlagsEXT Flags { get; set; }
    public ulong FrameID { get; set; }
    public uint ImageCount { get; set; }
    public Image PImages { get; set; }
    public uint BufferCount { get; set; }
    public Buffer PBuffers { get; set; }
    public ulong TagName { get; set; }
    public ulong TagSize { get; set; }
    public void* PTag { get; set; }

    public AdamantiumVulkan.Core.Interop.VkFrameBoundaryEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkFrameBoundaryEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (FrameID != default)
        {
            _internal.frameID = FrameID;
        }
        if (ImageCount != default)
        {
            _internal.imageCount = ImageCount;
        }
        _pImages.Dispose();
        if (PImages != default)
        {
            AdamantiumVulkan.Core.Interop.VkImage_T struct0 = PImages;
            _pImages = new NativeStruct<AdamantiumVulkan.Core.Interop.VkImage_T>(struct0);
            _internal.pImages = _pImages.Handle;
        }
        if (BufferCount != default)
        {
            _internal.bufferCount = BufferCount;
        }
        _pBuffers.Dispose();
        if (PBuffers != default)
        {
            AdamantiumVulkan.Core.Interop.VkBuffer_T struct1 = PBuffers;
            _pBuffers = new NativeStruct<AdamantiumVulkan.Core.Interop.VkBuffer_T>(struct1);
            _internal.pBuffers = _pBuffers.Handle;
        }
        if (TagName != default)
        {
            _internal.tagName = TagName;
        }
        if (TagSize != default)
        {
            _internal.tagSize = TagSize;
        }
        _internal.pTag = PTag;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pImages.Dispose();
        _pBuffers.Dispose();
    }


    public static implicit operator FrameBoundaryEXT(AdamantiumVulkan.Core.Interop.VkFrameBoundaryEXT f)
    {
        return new FrameBoundaryEXT(f);
    }

}



