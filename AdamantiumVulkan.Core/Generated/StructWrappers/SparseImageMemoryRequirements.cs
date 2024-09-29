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

public unsafe partial class SparseImageMemoryRequirements : QBDisposableObject
{
    public SparseImageMemoryRequirements()
    {
    }

    public SparseImageMemoryRequirements(AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements _internal)
    {
        FormatProperties = new SparseImageFormatProperties(_internal.formatProperties);
        ImageMipTailFirstLod = _internal.imageMipTailFirstLod;
        ImageMipTailSize = _internal.imageMipTailSize;
        ImageMipTailOffset = _internal.imageMipTailOffset;
        ImageMipTailStride = _internal.imageMipTailStride;
    }

    public SparseImageFormatProperties FormatProperties { get; set; }
    public uint ImageMipTailFirstLod { get; set; }
    public VkDeviceSize ImageMipTailSize { get; set; }
    public VkDeviceSize ImageMipTailOffset { get; set; }
    public VkDeviceSize ImageMipTailStride { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements();
        if (FormatProperties != default)
        {
            _internal.formatProperties = FormatProperties.ToNative();
        }
        if (ImageMipTailFirstLod != default)
        {
            _internal.imageMipTailFirstLod = ImageMipTailFirstLod;
        }
        if (ImageMipTailSize != (ulong)default)
        {
            _internal.imageMipTailSize = ImageMipTailSize;
        }
        if (ImageMipTailOffset != (ulong)default)
        {
            _internal.imageMipTailOffset = ImageMipTailOffset;
        }
        if (ImageMipTailStride != (ulong)default)
        {
            _internal.imageMipTailStride = ImageMipTailStride;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        FormatProperties?.Dispose();
    }


    public static implicit operator SparseImageMemoryRequirements(AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements s)
    {
        return new SparseImageMemoryRequirements(s);
    }

}



