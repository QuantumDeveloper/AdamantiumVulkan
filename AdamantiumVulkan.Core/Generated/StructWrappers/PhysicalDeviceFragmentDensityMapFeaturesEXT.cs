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

public unsafe partial class PhysicalDeviceFragmentDensityMapFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceFragmentDensityMapFeaturesEXT()
    {
    }

    public PhysicalDeviceFragmentDensityMapFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapFeaturesEXT _internal)
    {
        PNext = _internal.pNext;
        FragmentDensityMap = _internal.fragmentDensityMap;
        FragmentDensityMapDynamic = _internal.fragmentDensityMapDynamic;
        FragmentDensityMapNonSubsampledImages = _internal.fragmentDensityMapNonSubsampledImages;
    }

    public StructureType SType => StructureType.PhysicalDeviceFragmentDensityMapFeaturesExt;
    public void* PNext { get; set; }
    public VkBool32 FragmentDensityMap { get; set; }
    public VkBool32 FragmentDensityMapDynamic { get; set; }
    public VkBool32 FragmentDensityMapNonSubsampledImages { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.fragmentDensityMap = FragmentDensityMap;
        _internal.fragmentDensityMapDynamic = FragmentDensityMapDynamic;
        _internal.fragmentDensityMapNonSubsampledImages = FragmentDensityMapNonSubsampledImages;
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentDensityMapFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapFeaturesEXT p)
    {
        return new PhysicalDeviceFragmentDensityMapFeaturesEXT(p);
    }

}



