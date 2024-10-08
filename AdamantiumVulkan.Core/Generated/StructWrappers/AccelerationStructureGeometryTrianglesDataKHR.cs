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

public unsafe partial class AccelerationStructureGeometryTrianglesDataKHR : QBDisposableObject
{
    public AccelerationStructureGeometryTrianglesDataKHR()
    {
    }

    public AccelerationStructureGeometryTrianglesDataKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryTrianglesDataKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VertexFormat = _internal.vertexFormat;
        VertexData = new DeviceOrHostAddressConstKHR(_internal.vertexData);
        VertexStride = _internal.vertexStride;
        MaxVertex = _internal.maxVertex;
        IndexType = _internal.indexType;
        IndexData = new DeviceOrHostAddressConstKHR(_internal.indexData);
        TransformData = new DeviceOrHostAddressConstKHR(_internal.transformData);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Format VertexFormat { get; set; }
    public DeviceOrHostAddressConstKHR VertexData { get; set; }
    public VkDeviceSize VertexStride { get; set; }
    public uint MaxVertex { get; set; }
    public IndexType IndexType { get; set; }
    public DeviceOrHostAddressConstKHR IndexData { get; set; }
    public DeviceOrHostAddressConstKHR TransformData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryTrianglesDataKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryTrianglesDataKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (VertexFormat != default)
        {
            _internal.vertexFormat = VertexFormat;
        }
        if (VertexData != default)
        {
            _internal.vertexData = VertexData.ToNative();
        }
        if (VertexStride != (ulong)default)
        {
            _internal.vertexStride = VertexStride;
        }
        if (MaxVertex != default)
        {
            _internal.maxVertex = MaxVertex;
        }
        if (IndexType != default)
        {
            _internal.indexType = IndexType;
        }
        if (IndexData != default)
        {
            _internal.indexData = IndexData.ToNative();
        }
        if (TransformData != default)
        {
            _internal.transformData = TransformData.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        VertexData?.Dispose();
        IndexData?.Dispose();
        TransformData?.Dispose();
    }


    public static implicit operator AccelerationStructureGeometryTrianglesDataKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryTrianglesDataKHR a)
    {
        return new AccelerationStructureGeometryTrianglesDataKHR(a);
    }

}



