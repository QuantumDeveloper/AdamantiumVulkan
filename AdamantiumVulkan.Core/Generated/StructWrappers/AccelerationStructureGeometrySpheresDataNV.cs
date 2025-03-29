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

public unsafe partial class AccelerationStructureGeometrySpheresDataNV : QBDisposableObject
{
    public AccelerationStructureGeometrySpheresDataNV()
    {
    }

    public AccelerationStructureGeometrySpheresDataNV(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometrySpheresDataNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VertexFormat = _internal.vertexFormat;
        VertexData = new DeviceOrHostAddressConstKHR(_internal.vertexData);
        VertexStride = _internal.vertexStride;
        RadiusFormat = _internal.radiusFormat;
        RadiusData = new DeviceOrHostAddressConstKHR(_internal.radiusData);
        RadiusStride = _internal.radiusStride;
        IndexType = _internal.indexType;
        IndexData = new DeviceOrHostAddressConstKHR(_internal.indexData);
        IndexStride = _internal.indexStride;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Format VertexFormat { get; set; }
    public DeviceOrHostAddressConstKHR VertexData { get; set; }
    public VkDeviceSize VertexStride { get; set; }
    public Format RadiusFormat { get; set; }
    public DeviceOrHostAddressConstKHR RadiusData { get; set; }
    public VkDeviceSize RadiusStride { get; set; }
    public IndexType IndexType { get; set; }
    public DeviceOrHostAddressConstKHR IndexData { get; set; }
    public VkDeviceSize IndexStride { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometrySpheresDataNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometrySpheresDataNV();
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
        if (RadiusFormat != default)
        {
            _internal.radiusFormat = RadiusFormat;
        }
        if (RadiusData != default)
        {
            _internal.radiusData = RadiusData.ToNative();
        }
        if (RadiusStride != (ulong)default)
        {
            _internal.radiusStride = RadiusStride;
        }
        if (IndexType != default)
        {
            _internal.indexType = IndexType;
        }
        if (IndexData != default)
        {
            _internal.indexData = IndexData.ToNative();
        }
        if (IndexStride != (ulong)default)
        {
            _internal.indexStride = IndexStride;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        VertexData?.Dispose();
        RadiusData?.Dispose();
        IndexData?.Dispose();
    }


    public static implicit operator AccelerationStructureGeometrySpheresDataNV(AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometrySpheresDataNV a)
    {
        return new AccelerationStructureGeometrySpheresDataNV(a);
    }

}



