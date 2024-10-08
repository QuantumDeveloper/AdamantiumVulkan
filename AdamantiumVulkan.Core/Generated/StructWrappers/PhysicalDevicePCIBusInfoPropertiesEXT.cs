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

public unsafe partial class PhysicalDevicePCIBusInfoPropertiesEXT : QBDisposableObject
{
    public PhysicalDevicePCIBusInfoPropertiesEXT()
    {
    }

    public PhysicalDevicePCIBusInfoPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePCIBusInfoPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        PciDomain = _internal.pciDomain;
        PciBus = _internal.pciBus;
        PciDevice = _internal.pciDevice;
        PciFunction = _internal.pciFunction;
    }

    public StructureType SType => StructureType.PhysicalDevicePciBusInfoPropertiesExt;
    public void* PNext { get; set; }
    public uint PciDomain { get; set; }
    public uint PciBus { get; set; }
    public uint PciDevice { get; set; }
    public uint PciFunction { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePCIBusInfoPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePCIBusInfoPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PciDomain != default)
        {
            _internal.pciDomain = PciDomain;
        }
        if (PciBus != default)
        {
            _internal.pciBus = PciBus;
        }
        if (PciDevice != default)
        {
            _internal.pciDevice = PciDevice;
        }
        if (PciFunction != default)
        {
            _internal.pciFunction = PciFunction;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePCIBusInfoPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePCIBusInfoPropertiesEXT p)
    {
        return new PhysicalDevicePCIBusInfoPropertiesEXT(p);
    }

}



