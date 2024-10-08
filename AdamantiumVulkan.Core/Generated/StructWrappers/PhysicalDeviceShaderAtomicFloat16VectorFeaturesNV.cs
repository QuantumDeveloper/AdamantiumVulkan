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

public unsafe partial class PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV()
    {
    }

    public PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderFloat16VectorAtomics = _internal.shaderFloat16VectorAtomics;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderFloat16VectorAtomics { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderFloat16VectorAtomics != (uint)default)
        {
            _internal.shaderFloat16VectorAtomics = ShaderFloat16VectorAtomics;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV p)
    {
        return new PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV(p);
    }

}



