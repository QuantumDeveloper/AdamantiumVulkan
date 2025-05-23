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

public unsafe partial class PhysicalDeviceShaderExpectAssumeFeatures : QBDisposableObject
{
    public PhysicalDeviceShaderExpectAssumeFeatures()
    {
    }

    public PhysicalDeviceShaderExpectAssumeFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeatures _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderExpectAssume = _internal.shaderExpectAssume;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderExpectAssume { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderExpectAssume != (uint)default)
        {
            _internal.shaderExpectAssume = ShaderExpectAssume;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderExpectAssumeFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeatures p)
    {
        return new PhysicalDeviceShaderExpectAssumeFeatures(p);
    }

}



