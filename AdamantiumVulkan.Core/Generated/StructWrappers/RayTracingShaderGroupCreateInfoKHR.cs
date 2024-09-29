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

public unsafe partial class RayTracingShaderGroupCreateInfoKHR : QBDisposableObject
{
    public RayTracingShaderGroupCreateInfoKHR()
    {
    }

    public RayTracingShaderGroupCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        GeneralShader = _internal.generalShader;
        ClosestHitShader = _internal.closestHitShader;
        AnyHitShader = _internal.anyHitShader;
        IntersectionShader = _internal.intersectionShader;
        PShaderGroupCaptureReplayHandle = _internal.pShaderGroupCaptureReplayHandle;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public RayTracingShaderGroupTypeKHR Type { get; set; }
    public uint GeneralShader { get; set; }
    public uint ClosestHitShader { get; set; }
    public uint AnyHitShader { get; set; }
    public uint IntersectionShader { get; set; }
    public void* PShaderGroupCaptureReplayHandle { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (GeneralShader != default)
        {
            _internal.generalShader = GeneralShader;
        }
        if (ClosestHitShader != default)
        {
            _internal.closestHitShader = ClosestHitShader;
        }
        if (AnyHitShader != default)
        {
            _internal.anyHitShader = AnyHitShader;
        }
        if (IntersectionShader != default)
        {
            _internal.intersectionShader = IntersectionShader;
        }
        _internal.pShaderGroupCaptureReplayHandle = PShaderGroupCaptureReplayHandle;
        return _internal;
    }

    public static implicit operator RayTracingShaderGroupCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoKHR r)
    {
        return new RayTracingShaderGroupCreateInfoKHR(r);
    }

}



