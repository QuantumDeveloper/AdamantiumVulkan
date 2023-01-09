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

public unsafe partial class ImageCompressionPropertiesEXT : QBDisposableObject
{
    public ImageCompressionPropertiesEXT()
    {
    }

    public ImageCompressionPropertiesEXT(AdamantiumVulkan.Core.Interop.VkImageCompressionPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageCompressionFlags = _internal.imageCompressionFlags;
        ImageCompressionFixedRateFlags = _internal.imageCompressionFixedRateFlags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkImageCompressionFlagsEXT ImageCompressionFlags { get; set; }
    public VkImageCompressionFixedRateFlagsEXT ImageCompressionFixedRateFlags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageCompressionPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageCompressionPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.imageCompressionFlags = ImageCompressionFlags;
        _internal.imageCompressionFixedRateFlags = ImageCompressionFixedRateFlags;
        return _internal;
    }

    public static implicit operator ImageCompressionPropertiesEXT(AdamantiumVulkan.Core.Interop.VkImageCompressionPropertiesEXT i)
    {
        return new ImageCompressionPropertiesEXT(i);
    }

}



