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

public unsafe partial class ImageSubresourceLayers
{
    public ImageSubresourceLayers()
    {
    }

    public ImageSubresourceLayers(AdamantiumVulkan.Core.Interop.VkImageSubresourceLayers _internal)
    {
        AspectMask = _internal.aspectMask;
        MipLevel = _internal.mipLevel;
        BaseArrayLayer = _internal.baseArrayLayer;
        LayerCount = _internal.layerCount;
    }

    public ImageAspectFlagBits AspectMask { get; set; }
    public uint MipLevel { get; set; }
    public uint BaseArrayLayer { get; set; }
    public uint LayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageSubresourceLayers ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageSubresourceLayers();
        _internal.aspectMask = AspectMask;
        _internal.mipLevel = MipLevel;
        _internal.baseArrayLayer = BaseArrayLayer;
        _internal.layerCount = LayerCount;
        return _internal;
    }

    public static implicit operator ImageSubresourceLayers(AdamantiumVulkan.Core.Interop.VkImageSubresourceLayers i)
    {
        return new ImageSubresourceLayers(i);
    }

}



