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

public unsafe partial class PhysicalDeviceVulkan12Properties : QBDisposableObject
{
    public PhysicalDeviceVulkan12Properties()
    {
    }

    public PhysicalDeviceVulkan12Properties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Properties _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DriverID = _internal.driverID;
        DriverName = new string((sbyte*)_internal.driverName);
        DriverInfo = new string((sbyte*)_internal.driverInfo);
        ConformanceVersion = new ConformanceVersion(_internal.conformanceVersion);
        DenormBehaviorIndependence = _internal.denormBehaviorIndependence;
        RoundingModeIndependence = _internal.roundingModeIndependence;
        ShaderSignedZeroInfNanPreserveFloat16 = _internal.shaderSignedZeroInfNanPreserveFloat16;
        ShaderSignedZeroInfNanPreserveFloat32 = _internal.shaderSignedZeroInfNanPreserveFloat32;
        ShaderSignedZeroInfNanPreserveFloat64 = _internal.shaderSignedZeroInfNanPreserveFloat64;
        ShaderDenormPreserveFloat16 = _internal.shaderDenormPreserveFloat16;
        ShaderDenormPreserveFloat32 = _internal.shaderDenormPreserveFloat32;
        ShaderDenormPreserveFloat64 = _internal.shaderDenormPreserveFloat64;
        ShaderDenormFlushToZeroFloat16 = _internal.shaderDenormFlushToZeroFloat16;
        ShaderDenormFlushToZeroFloat32 = _internal.shaderDenormFlushToZeroFloat32;
        ShaderDenormFlushToZeroFloat64 = _internal.shaderDenormFlushToZeroFloat64;
        ShaderRoundingModeRTEFloat16 = _internal.shaderRoundingModeRTEFloat16;
        ShaderRoundingModeRTEFloat32 = _internal.shaderRoundingModeRTEFloat32;
        ShaderRoundingModeRTEFloat64 = _internal.shaderRoundingModeRTEFloat64;
        ShaderRoundingModeRTZFloat16 = _internal.shaderRoundingModeRTZFloat16;
        ShaderRoundingModeRTZFloat32 = _internal.shaderRoundingModeRTZFloat32;
        ShaderRoundingModeRTZFloat64 = _internal.shaderRoundingModeRTZFloat64;
        MaxUpdateAfterBindDescriptorsInAllPools = _internal.maxUpdateAfterBindDescriptorsInAllPools;
        ShaderUniformBufferArrayNonUniformIndexingNative = _internal.shaderUniformBufferArrayNonUniformIndexingNative;
        ShaderSampledImageArrayNonUniformIndexingNative = _internal.shaderSampledImageArrayNonUniformIndexingNative;
        ShaderStorageBufferArrayNonUniformIndexingNative = _internal.shaderStorageBufferArrayNonUniformIndexingNative;
        ShaderStorageImageArrayNonUniformIndexingNative = _internal.shaderStorageImageArrayNonUniformIndexingNative;
        ShaderInputAttachmentArrayNonUniformIndexingNative = _internal.shaderInputAttachmentArrayNonUniformIndexingNative;
        RobustBufferAccessUpdateAfterBind = _internal.robustBufferAccessUpdateAfterBind;
        QuadDivergentImplicitLod = _internal.quadDivergentImplicitLod;
        MaxPerStageDescriptorUpdateAfterBindSamplers = _internal.maxPerStageDescriptorUpdateAfterBindSamplers;
        MaxPerStageDescriptorUpdateAfterBindUniformBuffers = _internal.maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        MaxPerStageDescriptorUpdateAfterBindStorageBuffers = _internal.maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        MaxPerStageDescriptorUpdateAfterBindSampledImages = _internal.maxPerStageDescriptorUpdateAfterBindSampledImages;
        MaxPerStageDescriptorUpdateAfterBindStorageImages = _internal.maxPerStageDescriptorUpdateAfterBindStorageImages;
        MaxPerStageDescriptorUpdateAfterBindInputAttachments = _internal.maxPerStageDescriptorUpdateAfterBindInputAttachments;
        MaxPerStageUpdateAfterBindResources = _internal.maxPerStageUpdateAfterBindResources;
        MaxDescriptorSetUpdateAfterBindSamplers = _internal.maxDescriptorSetUpdateAfterBindSamplers;
        MaxDescriptorSetUpdateAfterBindUniformBuffers = _internal.maxDescriptorSetUpdateAfterBindUniformBuffers;
        MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = _internal.maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        MaxDescriptorSetUpdateAfterBindStorageBuffers = _internal.maxDescriptorSetUpdateAfterBindStorageBuffers;
        MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = _internal.maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        MaxDescriptorSetUpdateAfterBindSampledImages = _internal.maxDescriptorSetUpdateAfterBindSampledImages;
        MaxDescriptorSetUpdateAfterBindStorageImages = _internal.maxDescriptorSetUpdateAfterBindStorageImages;
        MaxDescriptorSetUpdateAfterBindInputAttachments = _internal.maxDescriptorSetUpdateAfterBindInputAttachments;
        SupportedDepthResolveModes = _internal.supportedDepthResolveModes;
        SupportedStencilResolveModes = _internal.supportedStencilResolveModes;
        IndependentResolveNone = _internal.independentResolveNone;
        IndependentResolve = _internal.independentResolve;
        FilterMinmaxSingleComponentFormats = _internal.filterMinmaxSingleComponentFormats;
        FilterMinmaxImageComponentMapping = _internal.filterMinmaxImageComponentMapping;
        MaxTimelineSemaphoreValueDifference = _internal.maxTimelineSemaphoreValueDifference;
        FramebufferIntegerColorSampleCounts = _internal.framebufferIntegerColorSampleCounts;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public DriverId DriverID { get; set; }
    public string DriverName { get; set; }
    public string DriverInfo { get; set; }
    public ConformanceVersion ConformanceVersion { get; set; }
    public ShaderFloatControlsIndependence DenormBehaviorIndependence { get; set; }
    public ShaderFloatControlsIndependence RoundingModeIndependence { get; set; }
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat16 { get; set; }
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat32 { get; set; }
    public VkBool32 ShaderSignedZeroInfNanPreserveFloat64 { get; set; }
    public VkBool32 ShaderDenormPreserveFloat16 { get; set; }
    public VkBool32 ShaderDenormPreserveFloat32 { get; set; }
    public VkBool32 ShaderDenormPreserveFloat64 { get; set; }
    public VkBool32 ShaderDenormFlushToZeroFloat16 { get; set; }
    public VkBool32 ShaderDenormFlushToZeroFloat32 { get; set; }
    public VkBool32 ShaderDenormFlushToZeroFloat64 { get; set; }
    public VkBool32 ShaderRoundingModeRTEFloat16 { get; set; }
    public VkBool32 ShaderRoundingModeRTEFloat32 { get; set; }
    public VkBool32 ShaderRoundingModeRTEFloat64 { get; set; }
    public VkBool32 ShaderRoundingModeRTZFloat16 { get; set; }
    public VkBool32 ShaderRoundingModeRTZFloat32 { get; set; }
    public VkBool32 ShaderRoundingModeRTZFloat64 { get; set; }
    public uint MaxUpdateAfterBindDescriptorsInAllPools { get; set; }
    public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative { get; set; }
    public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative { get; set; }
    public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative { get; set; }
    public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative { get; set; }
    public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative { get; set; }
    public VkBool32 RobustBufferAccessUpdateAfterBind { get; set; }
    public VkBool32 QuadDivergentImplicitLod { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments { get; set; }
    public uint MaxPerStageUpdateAfterBindResources { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindSamplers { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindSampledImages { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindStorageImages { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments { get; set; }
    public VkResolveModeFlags SupportedDepthResolveModes { get; set; }
    public VkResolveModeFlags SupportedStencilResolveModes { get; set; }
    public VkBool32 IndependentResolveNone { get; set; }
    public VkBool32 IndependentResolve { get; set; }
    public VkBool32 FilterMinmaxSingleComponentFormats { get; set; }
    public VkBool32 FilterMinmaxImageComponentMapping { get; set; }
    public ulong MaxTimelineSemaphoreValueDifference { get; set; }
    public VkSampleCountFlags FramebufferIntegerColorSampleCounts { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Properties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Properties();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.driverID = DriverID;
        if(DriverName != null)
        {
            if (DriverName.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(DriverName), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.driverName, 256, DriverName, false);
        }
        if(DriverInfo != null)
        {
            if (DriverInfo.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(DriverInfo), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.driverInfo, 256, DriverInfo, false);
        }
        if (ConformanceVersion != null)
        {
            _internal.conformanceVersion = ConformanceVersion.ToNative();
        }
        _internal.denormBehaviorIndependence = DenormBehaviorIndependence;
        _internal.roundingModeIndependence = RoundingModeIndependence;
        _internal.shaderSignedZeroInfNanPreserveFloat16 = ShaderSignedZeroInfNanPreserveFloat16;
        _internal.shaderSignedZeroInfNanPreserveFloat32 = ShaderSignedZeroInfNanPreserveFloat32;
        _internal.shaderSignedZeroInfNanPreserveFloat64 = ShaderSignedZeroInfNanPreserveFloat64;
        _internal.shaderDenormPreserveFloat16 = ShaderDenormPreserveFloat16;
        _internal.shaderDenormPreserveFloat32 = ShaderDenormPreserveFloat32;
        _internal.shaderDenormPreserveFloat64 = ShaderDenormPreserveFloat64;
        _internal.shaderDenormFlushToZeroFloat16 = ShaderDenormFlushToZeroFloat16;
        _internal.shaderDenormFlushToZeroFloat32 = ShaderDenormFlushToZeroFloat32;
        _internal.shaderDenormFlushToZeroFloat64 = ShaderDenormFlushToZeroFloat64;
        _internal.shaderRoundingModeRTEFloat16 = ShaderRoundingModeRTEFloat16;
        _internal.shaderRoundingModeRTEFloat32 = ShaderRoundingModeRTEFloat32;
        _internal.shaderRoundingModeRTEFloat64 = ShaderRoundingModeRTEFloat64;
        _internal.shaderRoundingModeRTZFloat16 = ShaderRoundingModeRTZFloat16;
        _internal.shaderRoundingModeRTZFloat32 = ShaderRoundingModeRTZFloat32;
        _internal.shaderRoundingModeRTZFloat64 = ShaderRoundingModeRTZFloat64;
        _internal.maxUpdateAfterBindDescriptorsInAllPools = MaxUpdateAfterBindDescriptorsInAllPools;
        _internal.shaderUniformBufferArrayNonUniformIndexingNative = ShaderUniformBufferArrayNonUniformIndexingNative;
        _internal.shaderSampledImageArrayNonUniformIndexingNative = ShaderSampledImageArrayNonUniformIndexingNative;
        _internal.shaderStorageBufferArrayNonUniformIndexingNative = ShaderStorageBufferArrayNonUniformIndexingNative;
        _internal.shaderStorageImageArrayNonUniformIndexingNative = ShaderStorageImageArrayNonUniformIndexingNative;
        _internal.shaderInputAttachmentArrayNonUniformIndexingNative = ShaderInputAttachmentArrayNonUniformIndexingNative;
        _internal.robustBufferAccessUpdateAfterBind = RobustBufferAccessUpdateAfterBind;
        _internal.quadDivergentImplicitLod = QuadDivergentImplicitLod;
        _internal.maxPerStageDescriptorUpdateAfterBindSamplers = MaxPerStageDescriptorUpdateAfterBindSamplers;
        _internal.maxPerStageDescriptorUpdateAfterBindUniformBuffers = MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
        _internal.maxPerStageDescriptorUpdateAfterBindStorageBuffers = MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
        _internal.maxPerStageDescriptorUpdateAfterBindSampledImages = MaxPerStageDescriptorUpdateAfterBindSampledImages;
        _internal.maxPerStageDescriptorUpdateAfterBindStorageImages = MaxPerStageDescriptorUpdateAfterBindStorageImages;
        _internal.maxPerStageDescriptorUpdateAfterBindInputAttachments = MaxPerStageDescriptorUpdateAfterBindInputAttachments;
        _internal.maxPerStageUpdateAfterBindResources = MaxPerStageUpdateAfterBindResources;
        _internal.maxDescriptorSetUpdateAfterBindSamplers = MaxDescriptorSetUpdateAfterBindSamplers;
        _internal.maxDescriptorSetUpdateAfterBindUniformBuffers = MaxDescriptorSetUpdateAfterBindUniformBuffers;
        _internal.maxDescriptorSetUpdateAfterBindUniformBuffersDynamic = MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        _internal.maxDescriptorSetUpdateAfterBindStorageBuffers = MaxDescriptorSetUpdateAfterBindStorageBuffers;
        _internal.maxDescriptorSetUpdateAfterBindStorageBuffersDynamic = MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        _internal.maxDescriptorSetUpdateAfterBindSampledImages = MaxDescriptorSetUpdateAfterBindSampledImages;
        _internal.maxDescriptorSetUpdateAfterBindStorageImages = MaxDescriptorSetUpdateAfterBindStorageImages;
        _internal.maxDescriptorSetUpdateAfterBindInputAttachments = MaxDescriptorSetUpdateAfterBindInputAttachments;
        _internal.supportedDepthResolveModes = SupportedDepthResolveModes;
        _internal.supportedStencilResolveModes = SupportedStencilResolveModes;
        _internal.independentResolveNone = IndependentResolveNone;
        _internal.independentResolve = IndependentResolve;
        _internal.filterMinmaxSingleComponentFormats = FilterMinmaxSingleComponentFormats;
        _internal.filterMinmaxImageComponentMapping = FilterMinmaxImageComponentMapping;
        _internal.maxTimelineSemaphoreValueDifference = MaxTimelineSemaphoreValueDifference;
        _internal.framebufferIntegerColorSampleCounts = FramebufferIntegerColorSampleCounts;
        return _internal;
    }

    public static implicit operator PhysicalDeviceVulkan12Properties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Properties p)
    {
        return new PhysicalDeviceVulkan12Properties(p);
    }

}


