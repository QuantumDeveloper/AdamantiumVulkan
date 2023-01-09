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

public unsafe partial class PhysicalDeviceMeshShaderPropertiesNV : QBDisposableObject
{
    public PhysicalDeviceMeshShaderPropertiesNV()
    {
    }

    public PhysicalDeviceMeshShaderPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderPropertiesNV _internal)
    {
        PNext = _internal.pNext;
        MaxDrawMeshTasksCount = _internal.maxDrawMeshTasksCount;
        MaxTaskWorkGroupInvocations = _internal.maxTaskWorkGroupInvocations;
        MaxTaskWorkGroupSize = NativeUtils.PointerToManagedArray(_internal.maxTaskWorkGroupSize, 3);
        MaxTaskTotalMemorySize = _internal.maxTaskTotalMemorySize;
        MaxTaskOutputCount = _internal.maxTaskOutputCount;
        MaxMeshWorkGroupInvocations = _internal.maxMeshWorkGroupInvocations;
        MaxMeshWorkGroupSize = NativeUtils.PointerToManagedArray(_internal.maxMeshWorkGroupSize, 3);
        MaxMeshTotalMemorySize = _internal.maxMeshTotalMemorySize;
        MaxMeshOutputVertices = _internal.maxMeshOutputVertices;
        MaxMeshOutputPrimitives = _internal.maxMeshOutputPrimitives;
        MaxMeshMultiviewViewCount = _internal.maxMeshMultiviewViewCount;
        MeshOutputPerVertexGranularity = _internal.meshOutputPerVertexGranularity;
        MeshOutputPerPrimitiveGranularity = _internal.meshOutputPerPrimitiveGranularity;
    }

    public StructureType SType => StructureType.PhysicalDeviceMeshShaderPropertiesNv;
    public void* PNext { get; set; }
    public uint MaxDrawMeshTasksCount { get; set; }
    public uint MaxTaskWorkGroupInvocations { get; set; }
    public uint[] MaxTaskWorkGroupSize { get; set; }
    public uint MaxTaskTotalMemorySize { get; set; }
    public uint MaxTaskOutputCount { get; set; }
    public uint MaxMeshWorkGroupInvocations { get; set; }
    public uint[] MaxMeshWorkGroupSize { get; set; }
    public uint MaxMeshTotalMemorySize { get; set; }
    public uint MaxMeshOutputVertices { get; set; }
    public uint MaxMeshOutputPrimitives { get; set; }
    public uint MaxMeshMultiviewViewCount { get; set; }
    public uint MeshOutputPerVertexGranularity { get; set; }
    public uint MeshOutputPerPrimitiveGranularity { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderPropertiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.maxDrawMeshTasksCount = MaxDrawMeshTasksCount;
        _internal.maxTaskWorkGroupInvocations = MaxTaskWorkGroupInvocations;
        if(MaxTaskWorkGroupSize != null)
        {
            if (MaxTaskWorkGroupSize.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(MaxTaskWorkGroupSize), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.maxTaskWorkGroupSize, 3, MaxTaskWorkGroupSize);
        }
        _internal.maxTaskTotalMemorySize = MaxTaskTotalMemorySize;
        _internal.maxTaskOutputCount = MaxTaskOutputCount;
        _internal.maxMeshWorkGroupInvocations = MaxMeshWorkGroupInvocations;
        if(MaxMeshWorkGroupSize != null)
        {
            if (MaxMeshWorkGroupSize.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(MaxMeshWorkGroupSize), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.maxMeshWorkGroupSize, 3, MaxMeshWorkGroupSize);
        }
        _internal.maxMeshTotalMemorySize = MaxMeshTotalMemorySize;
        _internal.maxMeshOutputVertices = MaxMeshOutputVertices;
        _internal.maxMeshOutputPrimitives = MaxMeshOutputPrimitives;
        _internal.maxMeshMultiviewViewCount = MaxMeshMultiviewViewCount;
        _internal.meshOutputPerVertexGranularity = MeshOutputPerVertexGranularity;
        _internal.meshOutputPerPrimitiveGranularity = MeshOutputPerPrimitiveGranularity;
        return _internal;
    }

    public static implicit operator PhysicalDeviceMeshShaderPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderPropertiesNV p)
    {
        return new PhysicalDeviceMeshShaderPropertiesNV(p);
    }

}



