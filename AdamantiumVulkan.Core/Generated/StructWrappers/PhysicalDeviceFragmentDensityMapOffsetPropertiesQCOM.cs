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

public unsafe partial class PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM : QBDisposableObject
{
    public PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM()
    {
    }

    public PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FragmentDensityOffsetGranularity = new Extent2D(_internal.fragmentDensityOffsetGranularity);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Extent2D FragmentDensityOffsetGranularity { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FragmentDensityOffsetGranularity != default)
        {
            _internal.fragmentDensityOffsetGranularity = FragmentDensityOffsetGranularity.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        FragmentDensityOffsetGranularity?.Dispose();
    }


    public static implicit operator PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM p)
    {
        return new PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM(p);
    }

}



