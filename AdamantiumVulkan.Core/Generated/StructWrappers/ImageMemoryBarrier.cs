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

public unsafe partial class ImageMemoryBarrier : QBDisposableObject
{
    public ImageMemoryBarrier()
    {
    }

    public ImageMemoryBarrier(AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier _internal)
    {
        PNext = _internal.pNext;
        SrcAccessMask = _internal.srcAccessMask;
        DstAccessMask = _internal.dstAccessMask;
        OldLayout = _internal.oldLayout;
        NewLayout = _internal.newLayout;
        SrcQueueFamilyIndex = _internal.srcQueueFamilyIndex;
        DstQueueFamilyIndex = _internal.dstQueueFamilyIndex;
        Image = new Image(_internal.image);
        SubresourceRange = new ImageSubresourceRange(_internal.subresourceRange);
    }

    public StructureType SType => StructureType.ImageMemoryBarrier;
    public void* PNext { get; set; }
    public VkAccessFlags SrcAccessMask { get; set; }
    public VkAccessFlags DstAccessMask { get; set; }
    public ImageLayout OldLayout { get; set; }
    public ImageLayout NewLayout { get; set; }
    public uint SrcQueueFamilyIndex { get; set; }
    public uint DstQueueFamilyIndex { get; set; }
    public Image Image { get; set; }
    public ImageSubresourceRange SubresourceRange { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.srcAccessMask = SrcAccessMask;
        _internal.dstAccessMask = DstAccessMask;
        _internal.oldLayout = OldLayout;
        _internal.newLayout = NewLayout;
        _internal.srcQueueFamilyIndex = SrcQueueFamilyIndex;
        _internal.dstQueueFamilyIndex = DstQueueFamilyIndex;
        _internal.image = Image;
        if (SubresourceRange != null)
        {
            _internal.subresourceRange = SubresourceRange.ToNative();
        }
        return _internal;
    }

    public static implicit operator ImageMemoryBarrier(AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier i)
    {
        return new ImageMemoryBarrier(i);
    }

}


