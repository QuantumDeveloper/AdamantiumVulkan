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

public unsafe partial class CopyMemoryToImageIndirectCommandNV : QBDisposableObject
{
    public CopyMemoryToImageIndirectCommandNV()
    {
    }

    public CopyMemoryToImageIndirectCommandNV(AdamantiumVulkan.Core.Interop.VkCopyMemoryToImageIndirectCommandNV _internal)
    {
        SrcAddress = _internal.srcAddress;
        BufferRowLength = _internal.bufferRowLength;
        BufferImageHeight = _internal.bufferImageHeight;
        ImageSubresource = new ImageSubresourceLayers(_internal.imageSubresource);
        ImageOffset = new Offset3D(_internal.imageOffset);
        ImageExtent = new Extent3D(_internal.imageExtent);
    }

    public VkDeviceAddress SrcAddress { get; set; }
    public uint BufferRowLength { get; set; }
    public uint BufferImageHeight { get; set; }
    public ImageSubresourceLayers ImageSubresource { get; set; }
    public Offset3D ImageOffset { get; set; }
    public Extent3D ImageExtent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyMemoryToImageIndirectCommandNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyMemoryToImageIndirectCommandNV();
        if (SrcAddress != (ulong)default)
        {
            _internal.srcAddress = SrcAddress;
        }
        if (BufferRowLength != default)
        {
            _internal.bufferRowLength = BufferRowLength;
        }
        if (BufferImageHeight != default)
        {
            _internal.bufferImageHeight = BufferImageHeight;
        }
        if (ImageSubresource != default)
        {
            _internal.imageSubresource = ImageSubresource.ToNative();
        }
        if (ImageOffset != default)
        {
            _internal.imageOffset = ImageOffset.ToNative();
        }
        if (ImageExtent != default)
        {
            _internal.imageExtent = ImageExtent.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        ImageSubresource?.Dispose();
        ImageOffset?.Dispose();
        ImageExtent?.Dispose();
    }


    public static implicit operator CopyMemoryToImageIndirectCommandNV(AdamantiumVulkan.Core.Interop.VkCopyMemoryToImageIndirectCommandNV c)
    {
        return new CopyMemoryToImageIndirectCommandNV(c);
    }

}



