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

public unsafe partial class PhysicalDeviceMapMemoryPlacedPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceMapMemoryPlacedPropertiesEXT()
    {
    }

    public PhysicalDeviceMapMemoryPlacedPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMapMemoryPlacedPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MinPlacedMemoryMapAlignment = _internal.minPlacedMemoryMapAlignment;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkDeviceSize MinPlacedMemoryMapAlignment { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMapMemoryPlacedPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMapMemoryPlacedPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MinPlacedMemoryMapAlignment != (ulong)default)
        {
            _internal.minPlacedMemoryMapAlignment = MinPlacedMemoryMapAlignment;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMapMemoryPlacedPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMapMemoryPlacedPropertiesEXT p)
    {
        return new PhysicalDeviceMapMemoryPlacedPropertiesEXT(p);
    }

}



