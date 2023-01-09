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

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceVulkan12Properties
{
    public StructureType sType;
    public void* pNext;
    public DriverId driverID;
    public unsafe fixed sbyte driverName[256];
    public unsafe fixed sbyte driverInfo[256];
    public VkConformanceVersion conformanceVersion;
    public ShaderFloatControlsIndependence denormBehaviorIndependence;
    public ShaderFloatControlsIndependence roundingModeIndependence;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
    public VkBool32 shaderDenormPreserveFloat16;
    public VkBool32 shaderDenormPreserveFloat32;
    public VkBool32 shaderDenormPreserveFloat64;
    public VkBool32 shaderDenormFlushToZeroFloat16;
    public VkBool32 shaderDenormFlushToZeroFloat32;
    public VkBool32 shaderDenormFlushToZeroFloat64;
    public VkBool32 shaderRoundingModeRTEFloat16;
    public VkBool32 shaderRoundingModeRTEFloat32;
    public VkBool32 shaderRoundingModeRTEFloat64;
    public VkBool32 shaderRoundingModeRTZFloat16;
    public VkBool32 shaderRoundingModeRTZFloat32;
    public VkBool32 shaderRoundingModeRTZFloat64;
    public uint maxUpdateAfterBindDescriptorsInAllPools;
    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
    public VkBool32 robustBufferAccessUpdateAfterBind;
    public VkBool32 quadDivergentImplicitLod;
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
    public uint maxPerStageUpdateAfterBindResources;
    public uint maxDescriptorSetUpdateAfterBindSamplers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindSampledImages;
    public uint maxDescriptorSetUpdateAfterBindStorageImages;
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;
    public VkResolveModeFlags supportedDepthResolveModes;
    public VkResolveModeFlags supportedStencilResolveModes;
    public VkBool32 independentResolveNone;
    public VkBool32 independentResolve;
    public VkBool32 filterMinmaxSingleComponentFormats;
    public VkBool32 filterMinmaxImageComponentMapping;
    public ulong maxTimelineSemaphoreValueDifference;
    public VkSampleCountFlags framebufferIntegerColorSampleCounts;
}


