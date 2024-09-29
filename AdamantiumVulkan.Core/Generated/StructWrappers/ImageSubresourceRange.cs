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

public unsafe partial class ImageSubresourceRange : QBDisposableObject
{
    public ImageSubresourceRange()
    {
    }

    public ImageSubresourceRange(AdamantiumVulkan.Core.Interop.VkImageSubresourceRange _internal)
    {
        AspectMask = _internal.aspectMask;
        BaseMipLevel = _internal.baseMipLevel;
        LevelCount = _internal.levelCount;
        BaseArrayLayer = _internal.baseArrayLayer;
        LayerCount = _internal.layerCount;
    }

    public ImageAspectFlagBits AspectMask { get; set; }
    public uint BaseMipLevel { get; set; }
    public uint LevelCount { get; set; }
    public uint BaseArrayLayer { get; set; }
    public uint LayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageSubresourceRange ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageSubresourceRange();
        if (AspectMask != default)
        {
            _internal.aspectMask = AspectMask;
        }
        if (BaseMipLevel != default)
        {
            _internal.baseMipLevel = BaseMipLevel;
        }
        if (LevelCount != default)
        {
            _internal.levelCount = LevelCount;
        }
        if (BaseArrayLayer != default)
        {
            _internal.baseArrayLayer = BaseArrayLayer;
        }
        if (LayerCount != default)
        {
            _internal.layerCount = LayerCount;
        }
        return _internal;
    }

    public static implicit operator ImageSubresourceRange(AdamantiumVulkan.Core.Interop.VkImageSubresourceRange i)
    {
        return new ImageSubresourceRange(i);
    }

}



