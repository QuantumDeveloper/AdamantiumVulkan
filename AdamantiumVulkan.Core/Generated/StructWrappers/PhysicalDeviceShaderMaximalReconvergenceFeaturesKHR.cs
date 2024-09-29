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

public unsafe partial class PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR()
    {
    }

    public PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderMaximalReconvergence = _internal.shaderMaximalReconvergence;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderMaximalReconvergence { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderMaximalReconvergence != (uint)default)
        {
            _internal.shaderMaximalReconvergence = ShaderMaximalReconvergence;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR p)
    {
        return new PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR(p);
    }

}


