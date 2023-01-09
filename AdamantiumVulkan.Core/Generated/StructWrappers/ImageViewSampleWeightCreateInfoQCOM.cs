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

public unsafe partial class ImageViewSampleWeightCreateInfoQCOM : QBDisposableObject
{
    public ImageViewSampleWeightCreateInfoQCOM()
    {
    }

    public ImageViewSampleWeightCreateInfoQCOM(AdamantiumVulkan.Core.Interop.VkImageViewSampleWeightCreateInfoQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FilterCenter = new Offset2D(_internal.filterCenter);
        FilterSize = new Extent2D(_internal.filterSize);
        NumPhases = _internal.numPhases;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Offset2D FilterCenter { get; set; }
    public Extent2D FilterSize { get; set; }
    public uint NumPhases { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageViewSampleWeightCreateInfoQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageViewSampleWeightCreateInfoQCOM();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (FilterCenter != null)
        {
            _internal.filterCenter = FilterCenter.ToNative();
        }
        if (FilterSize != null)
        {
            _internal.filterSize = FilterSize.ToNative();
        }
        _internal.numPhases = NumPhases;
        return _internal;
    }

    public static implicit operator ImageViewSampleWeightCreateInfoQCOM(AdamantiumVulkan.Core.Interop.VkImageViewSampleWeightCreateInfoQCOM i)
    {
        return new ImageViewSampleWeightCreateInfoQCOM(i);
    }

}


