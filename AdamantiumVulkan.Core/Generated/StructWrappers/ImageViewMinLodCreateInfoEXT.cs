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

public unsafe partial class ImageViewMinLodCreateInfoEXT : QBDisposableObject
{
    public ImageViewMinLodCreateInfoEXT()
    {
    }

    public ImageViewMinLodCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkImageViewMinLodCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MinLod = _internal.minLod;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public float MinLod { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageViewMinLodCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageViewMinLodCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MinLod != default)
        {
            _internal.minLod = MinLod;
        }
        return _internal;
    }

    public static implicit operator ImageViewMinLodCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkImageViewMinLodCreateInfoEXT i)
    {
        return new ImageViewMinLodCreateInfoEXT(i);
    }

}



