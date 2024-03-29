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

public unsafe partial class DeviceFaultAddressInfoEXT
{
    public DeviceFaultAddressInfoEXT()
    {
    }

    public DeviceFaultAddressInfoEXT(AdamantiumVulkan.Core.Interop.VkDeviceFaultAddressInfoEXT _internal)
    {
        AddressType = _internal.addressType;
        ReportedAddress = _internal.reportedAddress;
        AddressPrecision = _internal.addressPrecision;
    }

    public DeviceFaultAddressTypeEXT AddressType { get; set; }
    public VkDeviceAddress ReportedAddress { get; set; }
    public VkDeviceSize AddressPrecision { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceFaultAddressInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceFaultAddressInfoEXT();
        _internal.addressType = AddressType;
        _internal.reportedAddress = ReportedAddress;
        _internal.addressPrecision = AddressPrecision;
        return _internal;
    }

    public static implicit operator DeviceFaultAddressInfoEXT(AdamantiumVulkan.Core.Interop.VkDeviceFaultAddressInfoEXT d)
    {
        return new DeviceFaultAddressInfoEXT(d);
    }

}



