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

public unsafe partial class PhysicalDeviceClusterCullingShaderPropertiesHUAWEI : QBDisposableObject
{
    public PhysicalDeviceClusterCullingShaderPropertiesHUAWEI()
    {
    }

    public PhysicalDeviceClusterCullingShaderPropertiesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxWorkGroupCount = NativeUtils.PointerToManagedArray(_internal.maxWorkGroupCount, 3);
        MaxWorkGroupSize = NativeUtils.PointerToManagedArray(_internal.maxWorkGroupSize, 3);
        MaxOutputClusterCount = _internal.maxOutputClusterCount;
        IndirectBufferOffsetAlignment = _internal.indirectBufferOffsetAlignment;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint[] MaxWorkGroupCount { get; set; }
    public uint[] MaxWorkGroupSize { get; set; }
    public uint MaxOutputClusterCount { get; set; }
    public VkDeviceSize IndirectBufferOffsetAlignment { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxWorkGroupCount != default)
        {
            if (MaxWorkGroupCount.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(MaxWorkGroupCount), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.maxWorkGroupCount, 3, MaxWorkGroupCount);
        }
        if (MaxWorkGroupSize != default)
        {
            if (MaxWorkGroupSize.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(MaxWorkGroupSize), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.maxWorkGroupSize, 3, MaxWorkGroupSize);
        }
        if (MaxOutputClusterCount != default)
        {
            _internal.maxOutputClusterCount = MaxOutputClusterCount;
        }
        if (IndirectBufferOffsetAlignment != (ulong)default)
        {
            _internal.indirectBufferOffsetAlignment = IndirectBufferOffsetAlignment;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceClusterCullingShaderPropertiesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI p)
    {
        return new PhysicalDeviceClusterCullingShaderPropertiesHUAWEI(p);
    }

}


