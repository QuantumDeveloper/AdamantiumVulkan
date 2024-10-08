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

public unsafe partial class PhysicalDeviceShaderDrawParametersFeatures : QBDisposableObject
{
    public PhysicalDeviceShaderDrawParametersFeatures()
    {
    }

    public PhysicalDeviceShaderDrawParametersFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderDrawParametersFeatures _internal)
    {
        PNext = _internal.pNext;
        ShaderDrawParameters = _internal.shaderDrawParameters;
    }

    public StructureType SType => StructureType.PhysicalDeviceShaderDrawParametersFeatures;
    public void* PNext { get; set; }
    public VkBool32 ShaderDrawParameters { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderDrawParametersFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderDrawParametersFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderDrawParameters != (uint)default)
        {
            _internal.shaderDrawParameters = ShaderDrawParameters;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderDrawParametersFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderDrawParametersFeatures p)
    {
        return new PhysicalDeviceShaderDrawParametersFeatures(p);
    }

}



