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

public unsafe partial class PhysicalDeviceShaderExpectAssumeFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceShaderExpectAssumeFeaturesKHR()
    {
    }

    public PhysicalDeviceShaderExpectAssumeFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderExpectAssume = _internal.shaderExpectAssume;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderExpectAssume { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeaturesKHR();
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

    public static implicit operator PhysicalDeviceShaderExpectAssumeFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderExpectAssumeFeaturesKHR p)
    {
        return new PhysicalDeviceShaderExpectAssumeFeaturesKHR(p);
    }

}


