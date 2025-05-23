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

public unsafe partial class PhysicalDeviceClusterAccelerationStructurePropertiesNV : QBDisposableObject
{
    public PhysicalDeviceClusterAccelerationStructurePropertiesNV()
    {
    }

    public PhysicalDeviceClusterAccelerationStructurePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterAccelerationStructurePropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxVerticesPerCluster = _internal.maxVerticesPerCluster;
        MaxTrianglesPerCluster = _internal.maxTrianglesPerCluster;
        ClusterScratchByteAlignment = _internal.clusterScratchByteAlignment;
        ClusterByteAlignment = _internal.clusterByteAlignment;
        ClusterTemplateByteAlignment = _internal.clusterTemplateByteAlignment;
        ClusterBottomLevelByteAlignment = _internal.clusterBottomLevelByteAlignment;
        ClusterTemplateBoundsByteAlignment = _internal.clusterTemplateBoundsByteAlignment;
        MaxClusterGeometryIndex = _internal.maxClusterGeometryIndex;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxVerticesPerCluster { get; set; }
    public uint MaxTrianglesPerCluster { get; set; }
    public uint ClusterScratchByteAlignment { get; set; }
    public uint ClusterByteAlignment { get; set; }
    public uint ClusterTemplateByteAlignment { get; set; }
    public uint ClusterBottomLevelByteAlignment { get; set; }
    public uint ClusterTemplateBoundsByteAlignment { get; set; }
    public uint MaxClusterGeometryIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterAccelerationStructurePropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterAccelerationStructurePropertiesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxVerticesPerCluster != default)
        {
            _internal.maxVerticesPerCluster = MaxVerticesPerCluster;
        }
        if (MaxTrianglesPerCluster != default)
        {
            _internal.maxTrianglesPerCluster = MaxTrianglesPerCluster;
        }
        if (ClusterScratchByteAlignment != default)
        {
            _internal.clusterScratchByteAlignment = ClusterScratchByteAlignment;
        }
        if (ClusterByteAlignment != default)
        {
            _internal.clusterByteAlignment = ClusterByteAlignment;
        }
        if (ClusterTemplateByteAlignment != default)
        {
            _internal.clusterTemplateByteAlignment = ClusterTemplateByteAlignment;
        }
        if (ClusterBottomLevelByteAlignment != default)
        {
            _internal.clusterBottomLevelByteAlignment = ClusterBottomLevelByteAlignment;
        }
        if (ClusterTemplateBoundsByteAlignment != default)
        {
            _internal.clusterTemplateBoundsByteAlignment = ClusterTemplateBoundsByteAlignment;
        }
        if (MaxClusterGeometryIndex != default)
        {
            _internal.maxClusterGeometryIndex = MaxClusterGeometryIndex;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceClusterAccelerationStructurePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterAccelerationStructurePropertiesNV p)
    {
        return new PhysicalDeviceClusterAccelerationStructurePropertiesNV(p);
    }

}



