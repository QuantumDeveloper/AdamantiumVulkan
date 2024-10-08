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

public unsafe partial class PhysicalDeviceLineRasterizationPropertiesKHR : QBDisposableObject
{
    public PhysicalDeviceLineRasterizationPropertiesKHR()
    {
    }

    public PhysicalDeviceLineRasterizationPropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        LineSubPixelPrecisionBits = _internal.lineSubPixelPrecisionBits;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint LineSubPixelPrecisionBits { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (LineSubPixelPrecisionBits != default)
        {
            _internal.lineSubPixelPrecisionBits = LineSubPixelPrecisionBits;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceLineRasterizationPropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationPropertiesKHR p)
    {
        return new PhysicalDeviceLineRasterizationPropertiesKHR(p);
    }

}



