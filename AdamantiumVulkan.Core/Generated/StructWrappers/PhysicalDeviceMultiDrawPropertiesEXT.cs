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

public unsafe partial class PhysicalDeviceMultiDrawPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceMultiDrawPropertiesEXT()
    {
    }

    public PhysicalDeviceMultiDrawPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxMultiDrawCount = _internal.maxMultiDrawCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxMultiDrawCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxMultiDrawCount != default)
        {
            _internal.maxMultiDrawCount = MaxMultiDrawCount;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMultiDrawPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawPropertiesEXT p)
    {
        return new PhysicalDeviceMultiDrawPropertiesEXT(p);
    }

}



