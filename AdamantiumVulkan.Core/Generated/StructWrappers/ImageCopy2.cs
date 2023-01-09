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

public unsafe partial class ImageCopy2 : QBDisposableObject
{
    public ImageCopy2()
    {
    }

    public ImageCopy2(AdamantiumVulkan.Core.Interop.VkImageCopy2 _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SrcSubresource = new ImageSubresourceLayers(_internal.srcSubresource);
        SrcOffset = new Offset3D(_internal.srcOffset);
        DstSubresource = new ImageSubresourceLayers(_internal.dstSubresource);
        DstOffset = new Offset3D(_internal.dstOffset);
        Extent = new Extent3D(_internal.extent);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ImageSubresourceLayers SrcSubresource { get; set; }
    public Offset3D SrcOffset { get; set; }
    public ImageSubresourceLayers DstSubresource { get; set; }
    public Offset3D DstOffset { get; set; }
    public Extent3D Extent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageCopy2 ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageCopy2();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (SrcSubresource != null)
        {
            _internal.srcSubresource = SrcSubresource.ToNative();
        }
        if (SrcOffset != null)
        {
            _internal.srcOffset = SrcOffset.ToNative();
        }
        if (DstSubresource != null)
        {
            _internal.dstSubresource = DstSubresource.ToNative();
        }
        if (DstOffset != null)
        {
            _internal.dstOffset = DstOffset.ToNative();
        }
        if (Extent != null)
        {
            _internal.extent = Extent.ToNative();
        }
        return _internal;
    }

    public static implicit operator ImageCopy2(AdamantiumVulkan.Core.Interop.VkImageCopy2 i)
    {
        return new ImageCopy2(i);
    }

}



