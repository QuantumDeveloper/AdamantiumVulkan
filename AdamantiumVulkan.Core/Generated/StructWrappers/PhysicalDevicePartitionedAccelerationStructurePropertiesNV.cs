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

public unsafe partial class PhysicalDevicePartitionedAccelerationStructurePropertiesNV : QBDisposableObject
{
    public PhysicalDevicePartitionedAccelerationStructurePropertiesNV()
    {
    }

    public PhysicalDevicePartitionedAccelerationStructurePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxPartitionCount = _internal.maxPartitionCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxPartitionCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxPartitionCount != default)
        {
            _internal.maxPartitionCount = MaxPartitionCount;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePartitionedAccelerationStructurePropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV p)
    {
        return new PhysicalDevicePartitionedAccelerationStructurePropertiesNV(p);
    }

}



