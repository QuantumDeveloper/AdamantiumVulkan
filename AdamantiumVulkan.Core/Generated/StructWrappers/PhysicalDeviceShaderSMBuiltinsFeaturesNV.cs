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

public unsafe partial class PhysicalDeviceShaderSMBuiltinsFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceShaderSMBuiltinsFeaturesNV()
    {
    }

    public PhysicalDeviceShaderSMBuiltinsFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderSMBuiltinsFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderSMBuiltins = _internal.shaderSMBuiltins;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderSMBuiltins { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderSMBuiltinsFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderSMBuiltinsFeaturesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderSMBuiltins != (uint)default)
        {
            _internal.shaderSMBuiltins = ShaderSMBuiltins;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderSMBuiltinsFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderSMBuiltinsFeaturesNV p)
    {
        return new PhysicalDeviceShaderSMBuiltinsFeaturesNV(p);
    }

}



