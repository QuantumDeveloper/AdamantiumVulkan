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

public unsafe partial class PhysicalDeviceSamplerYcbcrConversionFeatures : QBDisposableObject
{
    public PhysicalDeviceSamplerYcbcrConversionFeatures()
    {
    }

    public PhysicalDeviceSamplerYcbcrConversionFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSamplerYcbcrConversionFeatures _internal)
    {
        PNext = _internal.pNext;
        SamplerYcbcrConversion = _internal.samplerYcbcrConversion;
    }

    public StructureType SType => StructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;
    public void* PNext { get; set; }
    public VkBool32 SamplerYcbcrConversion { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSamplerYcbcrConversionFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSamplerYcbcrConversionFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SamplerYcbcrConversion != (uint)default)
        {
            _internal.samplerYcbcrConversion = SamplerYcbcrConversion;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceSamplerYcbcrConversionFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSamplerYcbcrConversionFeatures p)
    {
        return new PhysicalDeviceSamplerYcbcrConversionFeatures(p);
    }

}



