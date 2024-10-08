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

public unsafe partial class PhysicalDeviceRGBA10X6FormatsFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceRGBA10X6FormatsFeaturesEXT()
    {
    }

    public PhysicalDeviceRGBA10X6FormatsFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FormatRgba10x6WithoutYCbCrSampler = _internal.formatRgba10x6WithoutYCbCrSampler;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 FormatRgba10x6WithoutYCbCrSampler { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FormatRgba10x6WithoutYCbCrSampler != (uint)default)
        {
            _internal.formatRgba10x6WithoutYCbCrSampler = FormatRgba10x6WithoutYCbCrSampler;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceRGBA10X6FormatsFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT p)
    {
        return new PhysicalDeviceRGBA10X6FormatsFeaturesEXT(p);
    }

}



