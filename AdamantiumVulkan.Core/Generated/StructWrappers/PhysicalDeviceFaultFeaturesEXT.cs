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

public unsafe partial class PhysicalDeviceFaultFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceFaultFeaturesEXT()
    {
    }

    public PhysicalDeviceFaultFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFaultFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DeviceFault = _internal.deviceFault;
        DeviceFaultVendorBinary = _internal.deviceFaultVendorBinary;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DeviceFault { get; set; }
    public VkBool32 DeviceFaultVendorBinary { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFaultFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFaultFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DeviceFault != (uint)default)
        {
            _internal.deviceFault = DeviceFault;
        }
        if (DeviceFaultVendorBinary != (uint)default)
        {
            _internal.deviceFaultVendorBinary = DeviceFaultVendorBinary;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFaultFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFaultFeaturesEXT p)
    {
        return new PhysicalDeviceFaultFeaturesEXT(p);
    }

}



