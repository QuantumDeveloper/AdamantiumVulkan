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

public unsafe partial class PhysicalDeviceASTCDecodeFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceASTCDecodeFeaturesEXT()
    {
    }

    public PhysicalDeviceASTCDecodeFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceASTCDecodeFeaturesEXT _internal)
    {
        PNext = _internal.pNext;
        DecodeModeSharedExponent = _internal.decodeModeSharedExponent;
    }

    public StructureType SType => StructureType.PhysicalDeviceAstcDecodeFeaturesExt;
    public void* PNext { get; set; }
    public VkBool32 DecodeModeSharedExponent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceASTCDecodeFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceASTCDecodeFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.decodeModeSharedExponent = DecodeModeSharedExponent;
        return _internal;
    }

    public static implicit operator PhysicalDeviceASTCDecodeFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceASTCDecodeFeaturesEXT p)
    {
        return new PhysicalDeviceASTCDecodeFeaturesEXT(p);
    }

}



