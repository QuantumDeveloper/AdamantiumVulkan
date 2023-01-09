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

public unsafe partial class PhysicalDeviceShaderFloat16Int8Features : QBDisposableObject
{
    public PhysicalDeviceShaderFloat16Int8Features()
    {
    }

    public PhysicalDeviceShaderFloat16Int8Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderFloat16Int8Features _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderFloat16 = _internal.shaderFloat16;
        ShaderInt8 = _internal.shaderInt8;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ShaderFloat16 { get; set; }
    public VkBool32 ShaderInt8 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderFloat16Int8Features ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderFloat16Int8Features();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.shaderFloat16 = ShaderFloat16;
        _internal.shaderInt8 = ShaderInt8;
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderFloat16Int8Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderFloat16Int8Features p)
    {
        return new PhysicalDeviceShaderFloat16Int8Features(p);
    }

}


