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

public unsafe partial class PhysicalDeviceLineRasterizationPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceLineRasterizationPropertiesEXT()
    {
    }

    public PhysicalDeviceLineRasterizationPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        LineSubPixelPrecisionBits = _internal.lineSubPixelPrecisionBits;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint LineSubPixelPrecisionBits { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.lineSubPixelPrecisionBits = LineSubPixelPrecisionBits;
        return _internal;
    }

    public static implicit operator PhysicalDeviceLineRasterizationPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesEXT p)
    {
        return new PhysicalDeviceLineRasterizationPropertiesEXT(p);
    }

}



