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
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DriverID != default)
        {
            _internal.driverID = DriverID;
        }
        if (DriverName != default)
        {
            if (DriverName.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(DriverName), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.driverName, 256, DriverName, false);
        }
        if (DriverInfo != default)
        {
            if (DriverInfo.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(DriverInfo), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.driverInfo, 256, DriverInfo, false);
        }
        if (ConformanceVersion != default)
        {
            _internal.conformanceVersion = ConformanceVersion.ToNative();
        }
        if (DenormBehaviorIndependence != default)
        {
            _internal.denormBehaviorIndependence = DenormBehaviorIndependence;
        }
        if (RoundingModeIndependence != default)
        {
            _internal.roundingModeIndependence = RoundingModeIndependence;
        }
        if (ShaderSignedZeroInfNanPreserveFloat16 != (uint)default)
        {
            _internal.shaderSignedZeroInfNanPreserveFloat16 = ShaderSignedZeroInfNanPreserveFloat16;
        }
        if (ShaderSignedZeroInfNanPreserveFloat32 != (uint)default)
        {
            _internal.shaderSignedZeroInfNanPreserveFloat32 = ShaderSignedZeroInfNanPreserveFloat32;
        }
        if (ShaderSignedZeroInfNanPreserveFloat64 != (uint)default)
        {
            _internal.shaderSignedZeroInfNanPreserveFloat64 = ShaderSignedZeroInfNanPreserveFloat64;
        }
        if (ShaderDenormPreserveFloat16 != (uint)default)
        {
            _internal.shaderDenormPreserveFloat16 = ShaderDenormPreserveFloat16;
        }
        if (ShaderDenormPreserveFloat32 != (uint)default)
        {
            _internal.shaderDenormPreserveFloat32 = ShaderDenormPreserveFloat32;
        }
        if (ShaderDenormPreserveFloat64 != (uint)default)
        {
            _internal.shaderDenormPreserveFloat64 = ShaderDenormPreserveFloat64;
        }
        if (ShaderDenormFlushToZeroFloat16 != (uint)default)
        {
            _internal.shaderDenormFlushToZeroFloat16 = ShaderDenormFlushToZeroFloat16;
        }
        if (ShaderDenormFlushToZeroFloat32 != (uint)default)
        {
            _internal.shaderDenormFlushToZeroFloat32 = ShaderDenormFlushToZeroFloat32;
        }
        if (ShaderDenormFlushToZeroFloat64 != (uint)default)
        {
            _internal.shaderDenormFlushToZeroFloat64 = ShaderDenormFlushToZeroFloat64;
        }
        if (ShaderRoundingModeRTEFloat16 != (uint)default)
        {
            _internal.shaderRoundingModeRTEFloat16 = ShaderRoundingModeRTEFloat16;
        }
        if (ShaderRoundingModeRTEFloat32 != (uint)default)
        {
            _internal.shaderRoundingModeRTEFloat32 = ShaderRoundingModeRTEFloat32;
        }
        if (ShaderRoundingModeRTEFloat64 != (uint)default)
        {
            _internal.shaderRoundingModeRTEFloat64 = ShaderRoundingModeRTEFloat64;
        }
        if (ShaderRoundingModeRTZFloat16 != (uint)default)
        {
            _internal.shaderRoundingModeRTZFloat16 = ShaderRoundingModeRTZFloat16;
        }
        if (ShaderRoundingModeRTZFloat32 != (uint)default)
        {
            _internal.shaderRoundingModeRTZFloat32 = ShaderRoundingModeRTZFloat32;
        }
        if (ShaderRoundingModeRTZFloat64 != (uint)default)
        {
            _internal.shaderRoundingModeRTZFloat64 = ShaderRoundingModeRTZFloat64;
        }
        if (MaxUpdateAfterBindDescriptorsInAllPools != default)
        {
            _internal.maxUpdateAfterBindDescriptorsInAllPools = MaxUpdateAfterBindDescriptorsInAllPools;
        }
        if (ShaderUniformBufferArrayNonUniformIndexingNative != (uint)default)
        {
            _internal.shaderUniformBufferArrayNonUniformIndexingNative = ShaderUniformBufferArrayNonUniformIndexingNative;
        }
        if (ShaderSampledImageArrayNonUniformIndexingNative != (uint)default)
        {
            _internal.shaderSampledImageArrayNonUniformIndexingNative = ShaderSampledImageArrayNonUniformIndexingNative;
        }
        if (ShaderStorageBufferArrayNonUniformIndexingNative != (uint)default)
        {
            _internal.shaderStorageBufferArrayNonUniformIndexingNative = ShaderStorageBufferArrayNonUniformIndexingNative;
        }
        if (ShaderStorageImageArrayNonUniformIndexingNative != (uint)default)
        {
            _internal.shaderStorageImageArrayNonUniformIndexingNative = ShaderStorageImageArrayNonUniformIndexingNative;
        }
        if (ShaderInputAttachmentArrayNonUniformIndexingNative != (uint)default)
        {
            _internal.shaderInputAttachmentArrayNonUniformIndexingNative = ShaderInputAttachmentArrayNonUniformIndexingNative;
        }
        if (RobustBufferAccessUpdateAfterBind != (uint)default)
        {
            _internal.robustBufferAccessUpdateAfterBind = RobustBufferAccessUpdateAfterBind;
        }
        if (QuadDivergentImplicitLod != (uint)default)
        {
            _internal.quadDivergentImplicitLod = QuadDivergentImplicitLod;
        }
        if (MaxPerStageDescriptorUpdateAfterBindSamplers != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindSamplers = MaxPerStageDescriptorUpdateAfterBindSamplers;
        }
        if (MaxPerStageDescriptorUpdateAfterBindUniformBuffers != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindUniformBuffers = MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
        }
        if (MaxPerStageDescriptorUpdateAfterBindStorageBuffers != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindStorageBuffers = MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
        }
        if (MaxPerStageDescriptorUpdateAfterBindSampledImages != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindSampledImages = MaxPerStageDescriptorUpdateAfterBindSampledImages;
        }
        if (MaxPerStageDescriptorUpdateAfterBindStorageImages != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindStorageImages = MaxPerStageDescriptorUpdateAfterBindStorageImages;
        }
        if (MaxPerStageDescriptorUpdateAfterBindInputAttachments != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindInputAttachments = MaxPerStageDescriptorUpdateAfterBindInputAttachments;
        }
        if (MaxPerStageUpdateAfterBindResources != default)
        {
            _internal.maxPerStageUpdateAfterBindResources = MaxPerStageUpdateAfterBindResources;
        }
        if (MaxDescriptorSetUpdateAfterBindSamplers != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindSamplers = MaxDescriptorSetUpdateAfterBindSamplers;
        }
        if (MaxDescriptorSetUpdateAfterBindUniformBuffers != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindUniformBuffers = MaxDescriptorSetUpdateAfterBindUniformBuffers;
        }
        if (MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindUniformBuffersDynamic = MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        }
        if (MaxDescriptorSetUpdateAfterBindStorageBuffers != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindStorageBuffers = MaxDescriptorSetUpdateAfterBindStorageBuffers;
        }
        if (MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindStorageBuffersDynamic = MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        }
        if (MaxDescriptorSetUpdateAfterBindSampledImages != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindSampledImages = MaxDescriptorSetUpdateAfterBindSampledImages;
        }
        if (MaxDescriptorSetUpdateAfterBindStorageImages != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindStorageImages = MaxDescriptorSetUpdateAfterBindStorageImages;
        }
        if (MaxDescriptorSetUpdateAfterBindInputAttachments != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindInputAttachments = MaxDescriptorSetUpdateAfterBindInputAttachments;
        }
        if (SupportedDepthResolveModes != (uint)default)
        {
            _internal.supportedDepthResolveModes = SupportedDepthResolveModes;
        }
        if (SupportedStencilResolveModes != (uint)default)
        {
            _internal.supportedStencilResolveModes = SupportedStencilResolveModes;
        }
        if (IndependentResolveNone != (uint)default)
        {
            _internal.independentResolveNone = IndependentResolveNone;
        }
        if (IndependentResolve != (uint)default)
        {
            _internal.independentResolve = IndependentResolve;
        }
        if (FilterMinmaxSingleComponentFormats != (uint)default)
        {
            _internal.filterMinmaxSingleComponentFormats = FilterMinmaxSingleComponentFormats;
        }
        if (FilterMinmaxImageComponentMapping != (uint)default)
        {
            _internal.filterMinmaxImageComponentMapping = FilterMinmaxImageComponentMapping;
        }
        if (MaxTimelineSemaphoreValueDifference != default)
        {
            _internal.maxTimelineSemaphoreValueDifference = MaxTimelineSemaphoreValueDifference;
        }
        if (FramebufferIntegerColorSampleCounts != (uint)default)
        {
            _internal.framebufferIntegerColorSampleCounts = FramebufferIntegerColorSampleCounts;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        ConformanceVersion?.Dispose();
    }


    public static implicit operator PhysicalDeviceVulkan12Properties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Properties p)
    {
        return new PhysicalDeviceVulkan12Properties(p);
    }

}



