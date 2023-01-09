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

public unsafe partial class PhysicalDeviceRepresentativeFragmentTestFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceRepresentativeFragmentTestFeaturesNV()
    {
    }

    public PhysicalDeviceRepresentativeFragmentTestFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV _internal)
    {
        PNext = _internal.pNext;
        RepresentativeFragmentTest = _internal.representativeFragmentTest;
    }

    public StructureType SType => StructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNv;
    public void* PNext { get; set; }
    public VkBool32 RepresentativeFragmentTest { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.representativeFragmentTest = RepresentativeFragmentTest;
        return _internal;
    }

    public static implicit operator PhysicalDeviceRepresentativeFragmentTestFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV p)
    {
        return new PhysicalDeviceRepresentativeFragmentTestFeaturesNV(p);
    }

}


