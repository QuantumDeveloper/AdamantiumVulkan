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

public unsafe partial class PhysicalDeviceFrameBoundaryFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceFrameBoundaryFeaturesEXT()
    {
    }

    public PhysicalDeviceFrameBoundaryFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFrameBoundaryFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FrameBoundary = _internal.frameBoundary;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 FrameBoundary { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFrameBoundaryFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFrameBoundaryFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FrameBoundary != (uint)default)
        {
            _internal.frameBoundary = FrameBoundary;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFrameBoundaryFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFrameBoundaryFeaturesEXT p)
    {
        return new PhysicalDeviceFrameBoundaryFeaturesEXT(p);
    }

}



