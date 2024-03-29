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

public unsafe partial class ImageViewAddressPropertiesNVX : QBDisposableObject
{
    public ImageViewAddressPropertiesNVX()
    {
    }

    public ImageViewAddressPropertiesNVX(AdamantiumVulkan.Core.Interop.VkImageViewAddressPropertiesNVX _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DeviceAddress = _internal.deviceAddress;
        Size = _internal.size;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkDeviceAddress DeviceAddress { get; set; }
    public VkDeviceSize Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageViewAddressPropertiesNVX ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageViewAddressPropertiesNVX();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.deviceAddress = DeviceAddress;
        _internal.size = Size;
        return _internal;
    }

    public static implicit operator ImageViewAddressPropertiesNVX(AdamantiumVulkan.Core.Interop.VkImageViewAddressPropertiesNVX i)
    {
        return new ImageViewAddressPropertiesNVX(i);
    }

}



