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

public unsafe partial class PhysicalDeviceRayTracingMotionBlurFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceRayTracingMotionBlurFeaturesNV()
    {
    }

    public PhysicalDeviceRayTracingMotionBlurFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingMotionBlurFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        RayTracingMotionBlur = _internal.rayTracingMotionBlur;
        RayTracingMotionBlurPipelineTraceRaysIndirect = _internal.rayTracingMotionBlurPipelineTraceRaysIndirect;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 RayTracingMotionBlur { get; set; }
    public VkBool32 RayTracingMotionBlurPipelineTraceRaysIndirect { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingMotionBlurFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingMotionBlurFeaturesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.rayTracingMotionBlur = RayTracingMotionBlur;
        _internal.rayTracingMotionBlurPipelineTraceRaysIndirect = RayTracingMotionBlurPipelineTraceRaysIndirect;
        return _internal;
    }

    public static implicit operator PhysicalDeviceRayTracingMotionBlurFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayTracingMotionBlurFeaturesNV p)
    {
        return new PhysicalDeviceRayTracingMotionBlurFeaturesNV(p);
    }

}



