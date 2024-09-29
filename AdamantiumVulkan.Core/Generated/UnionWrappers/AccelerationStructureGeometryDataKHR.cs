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

public unsafe partial class AccelerationStructureGeometryDataKHR : QBDisposableObject
{
    public AccelerationStructureGeometryDataKHR()
    {
    }

    public AccelerationStructureGeometryDataKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryDataKHR _internal)
    {
        Triangles = new AccelerationStructureGeometryTrianglesDataKHR(_internal.triangles);
        Aabbs = new AccelerationStructureGeometryAabbsDataKHR(_internal.aabbs);
        Instances = new AccelerationStructureGeometryInstancesDataKHR(_internal.instances);
    }

    public AccelerationStructureGeometryTrianglesDataKHR Triangles { get; set; }
    public AccelerationStructureGeometryAabbsDataKHR Aabbs { get; set; }
    public AccelerationStructureGeometryInstancesDataKHR Instances { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryDataKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryDataKHR();
        if (Triangles != default)
        {
            _internal.triangles = Triangles.ToNative();
        }
        if (Aabbs != default)
        {
            _internal.aabbs = Aabbs.ToNative();
        }
        if (Instances != default)
        {
            _internal.instances = Instances.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Triangles?.Dispose();
        Aabbs?.Dispose();
        Instances?.Dispose();
    }


    public static implicit operator AccelerationStructureGeometryDataKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryDataKHR a)
    {
        return new AccelerationStructureGeometryDataKHR(a);
    }

}



