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

public unsafe partial class AccelerationStructureDeviceAddressInfoKHR : QBDisposableObject
{
    public AccelerationStructureDeviceAddressInfoKHR()
    {
    }

    public AccelerationStructureDeviceAddressInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureDeviceAddressInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AccelerationStructure = new AccelerationStructureKHR(_internal.accelerationStructure);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public AccelerationStructureKHR AccelerationStructure { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureDeviceAddressInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureDeviceAddressInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.accelerationStructure = AccelerationStructure;
        return _internal;
    }

    public static implicit operator AccelerationStructureDeviceAddressInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureDeviceAddressInfoKHR a)
    {
        return new AccelerationStructureDeviceAddressInfoKHR(a);
    }

}


