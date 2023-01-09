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

public unsafe partial class PerformanceStreamMarkerInfoINTEL : QBDisposableObject
{
    public PerformanceStreamMarkerInfoINTEL()
    {
    }

    public PerformanceStreamMarkerInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceStreamMarkerInfoINTEL _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Marker = _internal.marker;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint Marker { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPerformanceStreamMarkerInfoINTEL ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPerformanceStreamMarkerInfoINTEL();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.marker = Marker;
        return _internal;
    }

    public static implicit operator PerformanceStreamMarkerInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceStreamMarkerInfoINTEL p)
    {
        return new PerformanceStreamMarkerInfoINTEL(p);
    }

}



