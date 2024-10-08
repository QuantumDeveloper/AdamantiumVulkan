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

public unsafe partial class PhysicalDeviceCoherentMemoryFeaturesAMD : QBDisposableObject
{
    public PhysicalDeviceCoherentMemoryFeaturesAMD()
    {
    }

    public PhysicalDeviceCoherentMemoryFeaturesAMD(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCoherentMemoryFeaturesAMD _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DeviceCoherentMemory = _internal.deviceCoherentMemory;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DeviceCoherentMemory { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCoherentMemoryFeaturesAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCoherentMemoryFeaturesAMD();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DeviceCoherentMemory != (uint)default)
        {
            _internal.deviceCoherentMemory = DeviceCoherentMemory;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceCoherentMemoryFeaturesAMD(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCoherentMemoryFeaturesAMD p)
    {
        return new PhysicalDeviceCoherentMemoryFeaturesAMD(p);
    }

}



