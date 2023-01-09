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

public unsafe partial class PhysicalDeviceFragmentDensityMap2PropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceFragmentDensityMap2PropertiesEXT()
    {
    }

    public PhysicalDeviceFragmentDensityMap2PropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMap2PropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SubsampledLoads = _internal.subsampledLoads;
        SubsampledCoarseReconstructionEarlyAccess = _internal.subsampledCoarseReconstructionEarlyAccess;
        MaxSubsampledArrayLayers = _internal.maxSubsampledArrayLayers;
        MaxDescriptorSetSubsampledSamplers = _internal.maxDescriptorSetSubsampledSamplers;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 SubsampledLoads { get; set; }
    public VkBool32 SubsampledCoarseReconstructionEarlyAccess { get; set; }
    public uint MaxSubsampledArrayLayers { get; set; }
    public uint MaxDescriptorSetSubsampledSamplers { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMap2PropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMap2PropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.subsampledLoads = SubsampledLoads;
        _internal.subsampledCoarseReconstructionEarlyAccess = SubsampledCoarseReconstructionEarlyAccess;
        _internal.maxSubsampledArrayLayers = MaxSubsampledArrayLayers;
        _internal.maxDescriptorSetSubsampledSamplers = MaxDescriptorSetSubsampledSamplers;
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentDensityMap2PropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMap2PropertiesEXT p)
    {
        return new PhysicalDeviceFragmentDensityMap2PropertiesEXT(p);
    }

}



