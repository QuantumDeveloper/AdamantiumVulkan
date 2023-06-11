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

public unsafe partial class PhysicalDeviceLegacyDitheringFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceLegacyDitheringFeaturesEXT()
    {
    }

    public PhysicalDeviceLegacyDitheringFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLegacyDitheringFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        LegacyDithering = _internal.legacyDithering;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 LegacyDithering { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLegacyDitheringFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLegacyDitheringFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.legacyDithering = LegacyDithering;
        return _internal;
    }

    public static implicit operator PhysicalDeviceLegacyDitheringFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLegacyDitheringFeaturesEXT p)
    {
        return new PhysicalDeviceLegacyDitheringFeaturesEXT(p);
    }

}


