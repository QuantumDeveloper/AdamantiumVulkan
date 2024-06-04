// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3038 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceLimits
{
    public uint maxImageDimension1D;
    public uint maxImageDimension2D;
    public uint maxImageDimension3D;
    public uint maxImageDimensionCube;
    public uint maxImageArrayLayers;
    public uint maxTexelBufferElements;
    public uint maxUniformBufferRange;
    public uint maxStorageBufferRange;
    public uint maxPushConstantsSize;
    public uint maxMemoryAllocationCount;
    public uint maxSamplerAllocationCount;
    public VkDeviceSize bufferImageGranularity;
    public VkDeviceSize sparseAddressSpaceSize;
    public uint maxBoundDescriptorSets;
    public uint maxPerStageDescriptorSamplers;
    public uint maxPerStageDescriptorUniformBuffers;
    public uint maxPerStageDescriptorStorageBuffers;
    public uint maxPerStageDescriptorSampledImages;
    public uint maxPerStageDescriptorStorageImages;
    public uint maxPerStageDescriptorInputAttachments;
    public uint maxPerStageResources;
    public uint maxDescriptorSetSamplers;
    public uint maxDescriptorSetUniformBuffers;
    public uint maxDescriptorSetUniformBuffersDynamic;
    public uint maxDescriptorSetStorageBuffers;
    public uint maxDescriptorSetStorageBuffersDynamic;
    public uint maxDescriptorSetSampledImages;
    public uint maxDescriptorSetStorageImages;
    public uint maxDescriptorSetInputAttachments;
    public uint maxVertexInputAttributes;
    public uint maxVertexInputBindings;
    public uint maxVertexInputAttributeOffset;
    public uint maxVertexInputBindingStride;
    public uint maxVertexOutputComponents;
    public uint maxTessellationGenerationLevel;
    public uint maxTessellationPatchSize;
    public uint maxTessellationControlPerVertexInputComponents;
    public uint maxTessellationControlPerVertexOutputComponents;
    public uint maxTessellationControlPerPatchOutputComponents;
    public uint maxTessellationControlTotalOutputComponents;
    public uint maxTessellationEvaluationInputComponents;
    public uint maxTessellationEvaluationOutputComponents;
    public uint maxGeometryShaderInvocations;
    public uint maxGeometryInputComponents;
    public uint maxGeometryOutputComponents;
    public uint maxGeometryOutputVertices;
    public uint maxGeometryTotalOutputComponents;
    public uint maxFragmentInputComponents;
    public uint maxFragmentOutputAttachments;
    public uint maxFragmentDualSrcAttachments;
    public uint maxFragmentCombinedOutputResources;
    public uint maxComputeSharedMemorySize;
    public unsafe fixed uint maxComputeWorkGroupCount[3];
    public uint maxComputeWorkGroupInvocations;
    public unsafe fixed uint maxComputeWorkGroupSize[3];
    public uint subPixelPrecisionBits;
    public uint subTexelPrecisionBits;
    public uint mipmapPrecisionBits;
    public uint maxDrawIndexedIndexValue;
    public uint maxDrawIndirectCount;
    public float maxSamplerLodBias;
    public float maxSamplerAnisotropy;
    public uint maxViewports;
    public unsafe fixed uint maxViewportDimensions[2];
    public unsafe fixed float viewportBoundsRange[2];
    public uint viewportSubPixelBits;
    public ulong minMemoryMapAlignment;
    public VkDeviceSize minTexelBufferOffsetAlignment;
    public VkDeviceSize minUniformBufferOffsetAlignment;
    public VkDeviceSize minStorageBufferOffsetAlignment;
    public int minTexelOffset;
    public uint maxTexelOffset;
    public int minTexelGatherOffset;
    public uint maxTexelGatherOffset;
    public float minInterpolationOffset;
    public float maxInterpolationOffset;
    public uint subPixelInterpolationOffsetBits;
    public uint maxFramebufferWidth;
    public uint maxFramebufferHeight;
    public uint maxFramebufferLayers;
    public VkSampleCountFlags framebufferColorSampleCounts;
    public VkSampleCountFlags framebufferDepthSampleCounts;
    public VkSampleCountFlags framebufferStencilSampleCounts;
    public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
    public uint maxColorAttachments;
    public VkSampleCountFlags sampledImageColorSampleCounts;
    public VkSampleCountFlags sampledImageIntegerSampleCounts;
    public VkSampleCountFlags sampledImageDepthSampleCounts;
    public VkSampleCountFlags sampledImageStencilSampleCounts;
    public VkSampleCountFlags storageImageSampleCounts;
    public uint maxSampleMaskWords;
    public VkBool32 timestampComputeAndGraphics;
    public float timestampPeriod;
    public uint maxClipDistances;
    public uint maxCullDistances;
    public uint maxCombinedClipAndCullDistances;
    public uint discreteQueuePriorities;
    public unsafe fixed float pointSizeRange[2];
    public unsafe fixed float lineWidthRange[2];
    public float pointSizeGranularity;
    public float lineWidthGranularity;
    public VkBool32 strictLines;
    public VkBool32 standardSampleLocations;
    public VkDeviceSize optimalBufferCopyOffsetAlignment;
    public VkDeviceSize optimalBufferCopyRowPitchAlignment;
    public VkDeviceSize nonCoherentAtomSize;
}



