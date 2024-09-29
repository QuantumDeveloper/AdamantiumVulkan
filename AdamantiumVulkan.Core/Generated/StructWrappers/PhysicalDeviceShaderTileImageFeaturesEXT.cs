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

public unsafe partial class PhysicalDeviceShaderTileImageFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceShaderTileImageFeaturesEXT()
    {
    }

    public PhysicalDeviceShaderTileImageFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderTileImageFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderTileImageColorReadAccess = _internal.shaderTileImageColorReadAccess;
        ShaderTileImageDepthReadAccess = _internal.shaderTileImageDepthReadAccess;
        ShaderTileImageStencilReadAccess = _internal.shaderTileImageStencilReadAccess;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderTileImageColorReadAccess { get; set; }
    public VkBool32 ShaderTileImageDepthReadAccess { get; set; }
    public VkBool32 ShaderTileImageStencilReadAccess { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderTileImageFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderTileImageFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShaderTileImageColorReadAccess != (uint)default)
        {
            _internal.shaderTileImageColorReadAccess = ShaderTileImageColorReadAccess;
        }
        if (ShaderTileImageDepthReadAccess != (uint)default)
        {
            _internal.shaderTileImageDepthReadAccess = ShaderTileImageDepthReadAccess;
        }
        if (ShaderTileImageStencilReadAccess != (uint)default)
        {
            _internal.shaderTileImageStencilReadAccess = ShaderTileImageStencilReadAccess;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderTileImageFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderTileImageFeaturesEXT p)
    {
        return new PhysicalDeviceShaderTileImageFeaturesEXT(p);
    }

}


