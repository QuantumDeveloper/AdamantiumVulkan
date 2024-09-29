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

public unsafe partial class CopyImageToBufferInfo2 : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkBufferImageCopy2> _pRegions;

    public CopyImageToBufferInfo2()
    {
    }

    public CopyImageToBufferInfo2(AdamantiumVulkan.Core.Interop.VkCopyImageToBufferInfo2 _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SrcImage = new Image(_internal.srcImage);
        SrcImageLayout = _internal.srcImageLayout;
        DstBuffer = new Buffer(_internal.dstBuffer);
        RegionCount = _internal.regionCount;
        PRegions = new BufferImageCopy2(*_internal.pRegions);
        NativeUtils.Free(_internal.pRegions);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Image SrcImage { get; set; }
    public ImageLayout SrcImageLayout { get; set; }
    public Buffer DstBuffer { get; set; }
    public uint RegionCount { get; set; }
    public BufferImageCopy2 PRegions { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyImageToBufferInfo2 ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyImageToBufferInfo2();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SrcImage != default)
        {
            _internal.srcImage = SrcImage;
        }
        if (SrcImageLayout != default)
        {
            _internal.srcImageLayout = SrcImageLayout;
        }
        if (DstBuffer != default)
        {
            _internal.dstBuffer = DstBuffer;
        }
        if (RegionCount != default)
        {
            _internal.regionCount = RegionCount;
        }
        _pRegions.Dispose();
        if (PRegions != default)
        {
            var struct0 = PRegions.ToNative();
            _pRegions = new NativeStruct<AdamantiumVulkan.Core.Interop.VkBufferImageCopy2>(struct0);
            _internal.pRegions = _pRegions.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pRegions.Dispose();
    }


    public static implicit operator CopyImageToBufferInfo2(AdamantiumVulkan.Core.Interop.VkCopyImageToBufferInfo2 c)
    {
        return new CopyImageToBufferInfo2(c);
    }

}



