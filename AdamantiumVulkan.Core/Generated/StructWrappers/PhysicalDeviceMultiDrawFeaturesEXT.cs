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

public unsafe partial class PhysicalDeviceMultiDrawFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceMultiDrawFeaturesEXT()
    {
    }

    public PhysicalDeviceMultiDrawFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MultiDraw = _internal.multiDraw;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 MultiDraw { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.multiDraw = MultiDraw;
        return _internal;
    }

    public static implicit operator PhysicalDeviceMultiDrawFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiDrawFeaturesEXT p)
    {
        return new PhysicalDeviceMultiDrawFeaturesEXT(p);
    }

}



