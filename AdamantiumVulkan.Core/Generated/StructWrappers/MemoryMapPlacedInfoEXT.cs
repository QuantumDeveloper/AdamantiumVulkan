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

public unsafe partial class MemoryMapPlacedInfoEXT : QBDisposableObject
{
    public MemoryMapPlacedInfoEXT()
    {
    }

    public MemoryMapPlacedInfoEXT(AdamantiumVulkan.Core.Interop.VkMemoryMapPlacedInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PlacedAddress = _internal.pPlacedAddress;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public void* PlacedAddress { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryMapPlacedInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryMapPlacedInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _internal.pPlacedAddress = PlacedAddress;
        return _internal;
    }

    public static implicit operator MemoryMapPlacedInfoEXT(AdamantiumVulkan.Core.Interop.VkMemoryMapPlacedInfoEXT m)
    {
        return new MemoryMapPlacedInfoEXT(m);
    }

}



