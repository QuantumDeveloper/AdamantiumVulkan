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

public unsafe partial class PhysicalDeviceDiscardRectanglePropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceDiscardRectanglePropertiesEXT()
    {
    }

    public PhysicalDeviceDiscardRectanglePropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDiscardRectanglePropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        MaxDiscardRectangles = _internal.maxDiscardRectangles;
    }

    public StructureType SType => StructureType.PhysicalDeviceDiscardRectanglePropertiesExt;
    public void* PNext { get; set; }
    public uint MaxDiscardRectangles { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDiscardRectanglePropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDiscardRectanglePropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.maxDiscardRectangles = MaxDiscardRectangles;
        return _internal;
    }

    public static implicit operator PhysicalDeviceDiscardRectanglePropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDiscardRectanglePropertiesEXT p)
    {
        return new PhysicalDeviceDiscardRectanglePropertiesEXT(p);
    }

}



