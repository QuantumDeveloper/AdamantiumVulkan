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

public unsafe partial class GeometryNV : QBDisposableObject
{
    public GeometryNV()
    {
    }

    public GeometryNV(AdamantiumVulkan.Core.Interop.VkGeometryNV _internal)
    {
        PNext = _internal.pNext;
        GeometryType = _internal.geometryType;
        Geometry = new GeometryDataNV(_internal.geometry);
        Flags = _internal.flags;
    }

    public StructureType SType => StructureType.GeometryNv;
    public void* PNext { get; set; }
    public GeometryTypeKHR GeometryType { get; set; }
    public GeometryDataNV Geometry { get; set; }
    public VkGeometryFlagsKHR Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGeometryNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGeometryNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.geometryType = GeometryType;
        if (Geometry != null)
        {
            _internal.geometry = Geometry.ToNative();
        }
        _internal.flags = Flags;
        return _internal;
    }

    public static implicit operator GeometryNV(AdamantiumVulkan.Core.Interop.VkGeometryNV g)
    {
        return new GeometryNV(g);
    }

}


