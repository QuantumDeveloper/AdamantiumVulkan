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

public unsafe partial class PhysicalDeviceRayTracingPipelinePropertiesKHR : QBDisposableObject
{
    public PhysicalDeviceRayTracingPipelinePropertiesKHR()
    {
    }

    public PhysicalDeviceRayTracingPipelinePropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingPipelinePropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderGroupHandleSize = _internal.shaderGroupHandleSize;
        MaxRayRecursionDepth = _internal.maxRayRecursionDepth;
        MaxShaderGroupStride = _internal.maxShaderGroupStride;
        ShaderGroupBaseAlignment = _internal.shaderGroupBaseAlignment;
        ShaderGroupHandleCaptureReplaySize = _internal.shaderGroupHandleCaptureReplaySize;
        MaxRayDispatchInvocationCount = _internal.maxRayDispatchInvocationCount;
        ShaderGroupHandleAlignment = _internal.shaderGroupHandleAlignment;
        MaxRayHitAttributeSize = _internal.maxRayHitAttributeSize;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint ShaderGroupHandleSize { get; set; }
    public uint MaxRayRecursionDepth { get; set; }
    public uint MaxShaderGroupStride { get; set; }
    public uint ShaderGroupBaseAlignment { get; set; }
    public uint ShaderGroupHandleCaptureReplaySize { get; set; }
    public uint MaxRayDispatchInvocationCount { get; set; }
    public uint ShaderGroupHandleAlignment { get; set; }
    public uint MaxRayHitAttributeSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingPipelinePropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingPipelinePropertiesKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.shaderGroupHandleSize = ShaderGroupHandleSize;
        _internal.maxRayRecursionDepth = MaxRayRecursionDepth;
        _internal.maxShaderGroupStride = MaxShaderGroupStride;
        _internal.shaderGroupBaseAlignment = ShaderGroupBaseAlignment;
        _internal.shaderGroupHandleCaptureReplaySize = ShaderGroupHandleCaptureReplaySize;
        _internal.maxRayDispatchInvocationCount = MaxRayDispatchInvocationCount;
        _internal.shaderGroupHandleAlignment = ShaderGroupHandleAlignment;
        _internal.maxRayHitAttributeSize = MaxRayHitAttributeSize;
        return _internal;
    }

    public static implicit operator PhysicalDeviceRayTracingPipelinePropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingPipelinePropertiesKHR p)
    {
        return new PhysicalDeviceRayTracingPipelinePropertiesKHR(p);
    }

}



