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

public unsafe partial class PartitionedAccelerationStructureWritePartitionTranslationDataNV : QBDisposableObject
{
    public PartitionedAccelerationStructureWritePartitionTranslationDataNV()
    {
    }

    public PartitionedAccelerationStructureWritePartitionTranslationDataNV(AdamantiumVulkan.Core.Interop.VkPartitionedAccelerationStructureWritePartitionTranslationDataNV _internal)
    {
        PartitionIndex = _internal.partitionIndex;
        PartitionTranslation = NativeUtils.PointerToManagedArray(_internal.partitionTranslation, 3);
    }

    public uint PartitionIndex { get; set; }
    public float[] PartitionTranslation { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPartitionedAccelerationStructureWritePartitionTranslationDataNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPartitionedAccelerationStructureWritePartitionTranslationDataNV();
        if (PartitionIndex != default)
        {
            _internal.partitionIndex = PartitionIndex;
        }
        if (PartitionTranslation != default)
        {
            if (PartitionTranslation.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(PartitionTranslation), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.partitionTranslation, 3, PartitionTranslation);
        }
        return _internal;
    }

    public static implicit operator PartitionedAccelerationStructureWritePartitionTranslationDataNV(AdamantiumVulkan.Core.Interop.VkPartitionedAccelerationStructureWritePartitionTranslationDataNV p)
    {
        return new PartitionedAccelerationStructureWritePartitionTranslationDataNV(p);
    }

}



