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

public unsafe partial class ImageCopy
{
    public ImageCopy()
    {
    }

    public ImageCopy(AdamantiumVulkan.Core.Interop.VkImageCopy _internal)
    {
        SrcSubresource = new ImageSubresourceLayers(_internal.srcSubresource);
        SrcOffset = new Offset3D(_internal.srcOffset);
        DstSubresource = new ImageSubresourceLayers(_internal.dstSubresource);
        DstOffset = new Offset3D(_internal.dstOffset);
        Extent = new Extent3D(_internal.extent);
    }

    public ImageSubresourceLayers SrcSubresource { get; set; }
    public Offset3D SrcOffset { get; set; }
    public ImageSubresourceLayers DstSubresource { get; set; }
    public Offset3D DstOffset { get; set; }
    public Extent3D Extent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageCopy ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageCopy();
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

    public static implicit operator ImageCopy(AdamantiumVulkan.Core.Interop.VkImageCopy i)
    {
        return new ImageCopy(i);
    }

}



