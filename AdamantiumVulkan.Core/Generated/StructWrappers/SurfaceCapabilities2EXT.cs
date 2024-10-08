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

public unsafe partial class SurfaceCapabilities2EXT : QBDisposableObject
{
    public SurfaceCapabilities2EXT()
    {
    }

    public SurfaceCapabilities2EXT(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2EXT _internal)
    {
        PNext = _internal.pNext;
        MinImageCount = _internal.minImageCount;
        MaxImageCount = _internal.maxImageCount;
        CurrentExtent = new Extent2D(_internal.currentExtent);
        MinImageExtent = new Extent2D(_internal.minImageExtent);
        MaxImageExtent = new Extent2D(_internal.maxImageExtent);
        MaxImageArrayLayers = _internal.maxImageArrayLayers;
        SupportedTransforms = _internal.supportedTransforms;
        CurrentTransform = _internal.currentTransform;
        SupportedCompositeAlpha = _internal.supportedCompositeAlpha;
        SupportedUsageFlags = _internal.supportedUsageFlags;
        SupportedSurfaceCounters = _internal.supportedSurfaceCounters;
    }

    public StructureType SType => StructureType.SurfaceCapabilities2Ext;
    public void* PNext { get; set; }
    public uint MinImageCount { get; set; }
    public uint MaxImageCount { get; set; }
    public Extent2D CurrentExtent { get; set; }
    public Extent2D MinImageExtent { get; set; }
    public Extent2D MaxImageExtent { get; set; }
    public uint MaxImageArrayLayers { get; set; }
    public VkSurfaceTransformFlagsKHR SupportedTransforms { get; set; }
    public SurfaceTransformFlagBitsKHR CurrentTransform { get; set; }
    public VkCompositeAlphaFlagsKHR SupportedCompositeAlpha { get; set; }
    public VkImageUsageFlags SupportedUsageFlags { get; set; }
    public VkSurfaceCounterFlagsEXT SupportedSurfaceCounters { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2EXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2EXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MinImageCount != default)
        {
            _internal.minImageCount = MinImageCount;
        }
        if (MaxImageCount != default)
        {
            _internal.maxImageCount = MaxImageCount;
        }
        if (CurrentExtent != default)
        {
            _internal.currentExtent = CurrentExtent.ToNative();
        }
        if (MinImageExtent != default)
        {
            _internal.minImageExtent = MinImageExtent.ToNative();
        }
        if (MaxImageExtent != default)
        {
            _internal.maxImageExtent = MaxImageExtent.ToNative();
        }
        if (MaxImageArrayLayers != default)
        {
            _internal.maxImageArrayLayers = MaxImageArrayLayers;
        }
        if (SupportedTransforms != (uint)default)
        {
            _internal.supportedTransforms = SupportedTransforms;
        }
        if (CurrentTransform != default)
        {
            _internal.currentTransform = CurrentTransform;
        }
        if (SupportedCompositeAlpha != (uint)default)
        {
            _internal.supportedCompositeAlpha = SupportedCompositeAlpha;
        }
        if (SupportedUsageFlags != (uint)default)
        {
            _internal.supportedUsageFlags = SupportedUsageFlags;
        }
        if (SupportedSurfaceCounters != (uint)default)
        {
            _internal.supportedSurfaceCounters = SupportedSurfaceCounters;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        CurrentExtent?.Dispose();
        MinImageExtent?.Dispose();
        MaxImageExtent?.Dispose();
    }


    public static implicit operator SurfaceCapabilities2EXT(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2EXT s)
    {
        return new SurfaceCapabilities2EXT(s);
    }

}



