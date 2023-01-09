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

public unsafe partial class SurfaceCapabilitiesKHR
{
    public SurfaceCapabilitiesKHR()
    {
    }

    public SurfaceCapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilitiesKHR _internal)
    {
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
    }

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

    public AdamantiumVulkan.Core.Interop.VkSurfaceCapabilitiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSurfaceCapabilitiesKHR();
        _internal.minImageCount = MinImageCount;
        _internal.maxImageCount = MaxImageCount;
        if (CurrentExtent != null)
        {
            _internal.currentExtent = CurrentExtent.ToNative();
        }
        if (MinImageExtent != null)
        {
            _internal.minImageExtent = MinImageExtent.ToNative();
        }
        if (MaxImageExtent != null)
        {
            _internal.maxImageExtent = MaxImageExtent.ToNative();
        }
        _internal.maxImageArrayLayers = MaxImageArrayLayers;
        _internal.supportedTransforms = SupportedTransforms;
        _internal.currentTransform = CurrentTransform;
        _internal.supportedCompositeAlpha = SupportedCompositeAlpha;
        _internal.supportedUsageFlags = SupportedUsageFlags;
        return _internal;
    }

    public static implicit operator SurfaceCapabilitiesKHR(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilitiesKHR s)
    {
        return new SurfaceCapabilitiesKHR(s);
    }

}


