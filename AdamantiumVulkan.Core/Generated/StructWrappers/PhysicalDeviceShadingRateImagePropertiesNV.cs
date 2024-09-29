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

public unsafe partial class PhysicalDeviceShadingRateImagePropertiesNV : QBDisposableObject
{
    public PhysicalDeviceShadingRateImagePropertiesNV()
    {
    }

    public PhysicalDeviceShadingRateImagePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShadingRateImagePropertiesNV _internal)
    {
        PNext = _internal.pNext;
        ShadingRateTexelSize = new Extent2D(_internal.shadingRateTexelSize);
        ShadingRatePaletteSize = _internal.shadingRatePaletteSize;
        ShadingRateMaxCoarseSamples = _internal.shadingRateMaxCoarseSamples;
    }

    public StructureType SType => StructureType.PhysicalDeviceShadingRateImagePropertiesNv;
    public void* PNext { get; set; }
    public Extent2D ShadingRateTexelSize { get; set; }
    public uint ShadingRatePaletteSize { get; set; }
    public uint ShadingRateMaxCoarseSamples { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShadingRateImagePropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShadingRateImagePropertiesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShadingRateTexelSize != default)
        {
            _internal.shadingRateTexelSize = ShadingRateTexelSize.ToNative();
        }
        if (ShadingRatePaletteSize != default)
        {
            _internal.shadingRatePaletteSize = ShadingRatePaletteSize;
        }
        if (ShadingRateMaxCoarseSamples != default)
        {
            _internal.shadingRateMaxCoarseSamples = ShadingRateMaxCoarseSamples;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        ShadingRateTexelSize?.Dispose();
    }


    public static implicit operator PhysicalDeviceShadingRateImagePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShadingRateImagePropertiesNV p)
    {
        return new PhysicalDeviceShadingRateImagePropertiesNV(p);
    }

}



