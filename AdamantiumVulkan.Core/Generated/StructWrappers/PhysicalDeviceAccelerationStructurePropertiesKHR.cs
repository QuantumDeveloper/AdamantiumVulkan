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

public unsafe partial class PhysicalDeviceAccelerationStructurePropertiesKHR : QBDisposableObject
{
    public PhysicalDeviceAccelerationStructurePropertiesKHR()
    {
    }

    public PhysicalDeviceAccelerationStructurePropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructurePropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxGeometryCount = _internal.maxGeometryCount;
        MaxInstanceCount = _internal.maxInstanceCount;
        MaxPrimitiveCount = _internal.maxPrimitiveCount;
        MaxPerStageDescriptorAccelerationStructures = _internal.maxPerStageDescriptorAccelerationStructures;
        MaxPerStageDescriptorUpdateAfterBindAccelerationStructures = _internal.maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        MaxDescriptorSetAccelerationStructures = _internal.maxDescriptorSetAccelerationStructures;
        MaxDescriptorSetUpdateAfterBindAccelerationStructures = _internal.maxDescriptorSetUpdateAfterBindAccelerationStructures;
        MinAccelerationStructureScratchOffsetAlignment = _internal.minAccelerationStructureScratchOffsetAlignment;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ulong MaxGeometryCount { get; set; }
    public ulong MaxInstanceCount { get; set; }
    public ulong MaxPrimitiveCount { get; set; }
    public uint MaxPerStageDescriptorAccelerationStructures { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures { get; set; }
    public uint MaxDescriptorSetAccelerationStructures { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures { get; set; }
    public uint MinAccelerationStructureScratchOffsetAlignment { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructurePropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructurePropertiesKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.maxGeometryCount = MaxGeometryCount;
        _internal.maxInstanceCount = MaxInstanceCount;
        _internal.maxPrimitiveCount = MaxPrimitiveCount;
        _internal.maxPerStageDescriptorAccelerationStructures = MaxPerStageDescriptorAccelerationStructures;
        _internal.maxPerStageDescriptorUpdateAfterBindAccelerationStructures = MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        _internal.maxDescriptorSetAccelerationStructures = MaxDescriptorSetAccelerationStructures;
        _internal.maxDescriptorSetUpdateAfterBindAccelerationStructures = MaxDescriptorSetUpdateAfterBindAccelerationStructures;
        _internal.minAccelerationStructureScratchOffsetAlignment = MinAccelerationStructureScratchOffsetAlignment;
        return _internal;
    }

    public static implicit operator PhysicalDeviceAccelerationStructurePropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructurePropertiesKHR p)
    {
        return new PhysicalDeviceAccelerationStructurePropertiesKHR(p);
    }

}


