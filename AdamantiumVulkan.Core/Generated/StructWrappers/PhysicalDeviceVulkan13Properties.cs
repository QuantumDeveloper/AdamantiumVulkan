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

public unsafe partial class PhysicalDeviceVulkan13Properties : QBDisposableObject
{
    public PhysicalDeviceVulkan13Properties()
    {
    }

    public PhysicalDeviceVulkan13Properties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Properties _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MinSubgroupSize = _internal.minSubgroupSize;
        MaxSubgroupSize = _internal.maxSubgroupSize;
        MaxComputeWorkgroupSubgroups = _internal.maxComputeWorkgroupSubgroups;
        RequiredSubgroupSizeStages = _internal.requiredSubgroupSizeStages;
        MaxInlineUniformBlockSize = _internal.maxInlineUniformBlockSize;
        MaxPerStageDescriptorInlineUniformBlocks = _internal.maxPerStageDescriptorInlineUniformBlocks;
        MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = _internal.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        MaxDescriptorSetInlineUniformBlocks = _internal.maxDescriptorSetInlineUniformBlocks;
        MaxDescriptorSetUpdateAfterBindInlineUniformBlocks = _internal.maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        MaxInlineUniformTotalSize = _internal.maxInlineUniformTotalSize;
        IntegerDotProduct8BitUnsignedAccelerated = _internal.integerDotProduct8BitUnsignedAccelerated;
        IntegerDotProduct8BitSignedAccelerated = _internal.integerDotProduct8BitSignedAccelerated;
        IntegerDotProduct8BitMixedSignednessAccelerated = _internal.integerDotProduct8BitMixedSignednessAccelerated;
        IntegerDotProduct4x8BitPackedUnsignedAccelerated = _internal.integerDotProduct4x8BitPackedUnsignedAccelerated;
        IntegerDotProduct4x8BitPackedSignedAccelerated = _internal.integerDotProduct4x8BitPackedSignedAccelerated;
        IntegerDotProduct4x8BitPackedMixedSignednessAccelerated = _internal.integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        IntegerDotProduct16BitUnsignedAccelerated = _internal.integerDotProduct16BitUnsignedAccelerated;
        IntegerDotProduct16BitSignedAccelerated = _internal.integerDotProduct16BitSignedAccelerated;
        IntegerDotProduct16BitMixedSignednessAccelerated = _internal.integerDotProduct16BitMixedSignednessAccelerated;
        IntegerDotProduct32BitUnsignedAccelerated = _internal.integerDotProduct32BitUnsignedAccelerated;
        IntegerDotProduct32BitSignedAccelerated = _internal.integerDotProduct32BitSignedAccelerated;
        IntegerDotProduct32BitMixedSignednessAccelerated = _internal.integerDotProduct32BitMixedSignednessAccelerated;
        IntegerDotProduct64BitUnsignedAccelerated = _internal.integerDotProduct64BitUnsignedAccelerated;
        IntegerDotProduct64BitSignedAccelerated = _internal.integerDotProduct64BitSignedAccelerated;
        IntegerDotProduct64BitMixedSignednessAccelerated = _internal.integerDotProduct64BitMixedSignednessAccelerated;
        IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated = _internal.integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        IntegerDotProductAccumulatingSaturating8BitSignedAccelerated = _internal.integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = _internal.integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = _internal.integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = _internal.integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = _internal.integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated = _internal.integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        IntegerDotProductAccumulatingSaturating16BitSignedAccelerated = _internal.integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = _internal.integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated = _internal.integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        IntegerDotProductAccumulatingSaturating32BitSignedAccelerated = _internal.integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = _internal.integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated = _internal.integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        IntegerDotProductAccumulatingSaturating64BitSignedAccelerated = _internal.integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = _internal.integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        StorageTexelBufferOffsetAlignmentBytes = _internal.storageTexelBufferOffsetAlignmentBytes;
        StorageTexelBufferOffsetSingleTexelAlignment = _internal.storageTexelBufferOffsetSingleTexelAlignment;
        UniformTexelBufferOffsetAlignmentBytes = _internal.uniformTexelBufferOffsetAlignmentBytes;
        UniformTexelBufferOffsetSingleTexelAlignment = _internal.uniformTexelBufferOffsetSingleTexelAlignment;
        MaxBufferSize = _internal.maxBufferSize;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MinSubgroupSize { get; set; }
    public uint MaxSubgroupSize { get; set; }
    public uint MaxComputeWorkgroupSubgroups { get; set; }
    public VkShaderStageFlags RequiredSubgroupSizeStages { get; set; }
    public uint MaxInlineUniformBlockSize { get; set; }
    public uint MaxPerStageDescriptorInlineUniformBlocks { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks { get; set; }
    public uint MaxDescriptorSetInlineUniformBlocks { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks { get; set; }
    public uint MaxInlineUniformTotalSize { get; set; }
    public VkBool32 IntegerDotProduct8BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct8BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProduct16BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct16BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProduct32BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct32BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProduct64BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct64BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated { get; set; }
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated { get; set; }
    public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes { get; set; }
    public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment { get; set; }
    public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes { get; set; }
    public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment { get; set; }
    public VkDeviceSize MaxBufferSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Properties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Properties();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.minSubgroupSize = MinSubgroupSize;
        _internal.maxSubgroupSize = MaxSubgroupSize;
        _internal.maxComputeWorkgroupSubgroups = MaxComputeWorkgroupSubgroups;
        _internal.requiredSubgroupSizeStages = RequiredSubgroupSizeStages;
        _internal.maxInlineUniformBlockSize = MaxInlineUniformBlockSize;
        _internal.maxPerStageDescriptorInlineUniformBlocks = MaxPerStageDescriptorInlineUniformBlocks;
        _internal.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        _internal.maxDescriptorSetInlineUniformBlocks = MaxDescriptorSetInlineUniformBlocks;
        _internal.maxDescriptorSetUpdateAfterBindInlineUniformBlocks = MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        _internal.maxInlineUniformTotalSize = MaxInlineUniformTotalSize;
        _internal.integerDotProduct8BitUnsignedAccelerated = IntegerDotProduct8BitUnsignedAccelerated;
        _internal.integerDotProduct8BitSignedAccelerated = IntegerDotProduct8BitSignedAccelerated;
        _internal.integerDotProduct8BitMixedSignednessAccelerated = IntegerDotProduct8BitMixedSignednessAccelerated;
        _internal.integerDotProduct4x8BitPackedUnsignedAccelerated = IntegerDotProduct4x8BitPackedUnsignedAccelerated;
        _internal.integerDotProduct4x8BitPackedSignedAccelerated = IntegerDotProduct4x8BitPackedSignedAccelerated;
        _internal.integerDotProduct4x8BitPackedMixedSignednessAccelerated = IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
        _internal.integerDotProduct16BitUnsignedAccelerated = IntegerDotProduct16BitUnsignedAccelerated;
        _internal.integerDotProduct16BitSignedAccelerated = IntegerDotProduct16BitSignedAccelerated;
        _internal.integerDotProduct16BitMixedSignednessAccelerated = IntegerDotProduct16BitMixedSignednessAccelerated;
        _internal.integerDotProduct32BitUnsignedAccelerated = IntegerDotProduct32BitUnsignedAccelerated;
        _internal.integerDotProduct32BitSignedAccelerated = IntegerDotProduct32BitSignedAccelerated;
        _internal.integerDotProduct32BitMixedSignednessAccelerated = IntegerDotProduct32BitMixedSignednessAccelerated;
        _internal.integerDotProduct64BitUnsignedAccelerated = IntegerDotProduct64BitUnsignedAccelerated;
        _internal.integerDotProduct64BitSignedAccelerated = IntegerDotProduct64BitSignedAccelerated;
        _internal.integerDotProduct64BitMixedSignednessAccelerated = IntegerDotProduct64BitMixedSignednessAccelerated;
        _internal.integerDotProductAccumulatingSaturating8BitUnsignedAccelerated = IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating8BitSignedAccelerated = IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        _internal.integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        _internal.integerDotProductAccumulatingSaturating16BitUnsignedAccelerated = IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating16BitSignedAccelerated = IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        _internal.integerDotProductAccumulatingSaturating32BitUnsignedAccelerated = IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating32BitSignedAccelerated = IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        _internal.integerDotProductAccumulatingSaturating64BitUnsignedAccelerated = IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating64BitSignedAccelerated = IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
        _internal.integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        _internal.storageTexelBufferOffsetAlignmentBytes = StorageTexelBufferOffsetAlignmentBytes;
        _internal.storageTexelBufferOffsetSingleTexelAlignment = StorageTexelBufferOffsetSingleTexelAlignment;
        _internal.uniformTexelBufferOffsetAlignmentBytes = UniformTexelBufferOffsetAlignmentBytes;
        _internal.uniformTexelBufferOffsetSingleTexelAlignment = UniformTexelBufferOffsetSingleTexelAlignment;
        _internal.maxBufferSize = MaxBufferSize;
        return _internal;
    }

    public static implicit operator PhysicalDeviceVulkan13Properties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Properties p)
    {
        return new PhysicalDeviceVulkan13Properties(p);
    }

}



