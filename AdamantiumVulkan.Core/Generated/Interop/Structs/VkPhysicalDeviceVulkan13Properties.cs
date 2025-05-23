// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 7038 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceVulkan13Properties
{
    public StructureType sType;
    public void* pNext;
    public uint minSubgroupSize;
    public uint maxSubgroupSize;
    public uint maxComputeWorkgroupSubgroups;
    public VkShaderStageFlags requiredSubgroupSizeStages;
    public uint maxInlineUniformBlockSize;
    public uint maxPerStageDescriptorInlineUniformBlocks;
    public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    public uint maxDescriptorSetInlineUniformBlocks;
    public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    public uint maxInlineUniformTotalSize;
    public VkBool32 integerDotProduct8BitUnsignedAccelerated;
    public VkBool32 integerDotProduct8BitSignedAccelerated;
    public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 integerDotProduct16BitUnsignedAccelerated;
    public VkBool32 integerDotProduct16BitSignedAccelerated;
    public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct32BitUnsignedAccelerated;
    public VkBool32 integerDotProduct32BitSignedAccelerated;
    public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct64BitUnsignedAccelerated;
    public VkBool32 integerDotProduct64BitSignedAccelerated;
    public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
    public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
    public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize maxBufferSize;
}



