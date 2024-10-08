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

public unsafe partial class DeviceFaultCountsEXT : QBDisposableObject
{
    public DeviceFaultCountsEXT()
    {
    }

    public DeviceFaultCountsEXT(AdamantiumVulkan.Core.Interop.VkDeviceFaultCountsEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AddressInfoCount = _internal.addressInfoCount;
        VendorInfoCount = _internal.vendorInfoCount;
        VendorBinarySize = _internal.vendorBinarySize;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint AddressInfoCount { get; set; }
    public uint VendorInfoCount { get; set; }
    public VkDeviceSize VendorBinarySize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceFaultCountsEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceFaultCountsEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (AddressInfoCount != default)
        {
            _internal.addressInfoCount = AddressInfoCount;
        }
        if (VendorInfoCount != default)
        {
            _internal.vendorInfoCount = VendorInfoCount;
        }
        if (VendorBinarySize != (ulong)default)
        {
            _internal.vendorBinarySize = VendorBinarySize;
        }
        return _internal;
    }

    public static implicit operator DeviceFaultCountsEXT(AdamantiumVulkan.Core.Interop.VkDeviceFaultCountsEXT d)
    {
        return new DeviceFaultCountsEXT(d);
    }

}



