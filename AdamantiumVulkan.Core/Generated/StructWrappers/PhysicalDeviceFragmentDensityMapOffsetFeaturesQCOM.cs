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

public unsafe partial class PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM : QBDisposableObject
{
    public PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM()
    {
    }

    public PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FragmentDensityMapOffset = _internal.fragmentDensityMapOffset;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 FragmentDensityMapOffset { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FragmentDensityMapOffset != (uint)default)
        {
            _internal.fragmentDensityMapOffset = FragmentDensityMapOffset;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM p)
    {
        return new PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM(p);
    }

}



