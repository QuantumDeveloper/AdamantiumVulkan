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

public unsafe partial class PhysicalDeviceExtendedDynamicState2FeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceExtendedDynamicState2FeaturesEXT()
    {
    }

    public PhysicalDeviceExtendedDynamicState2FeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState2FeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ExtendedDynamicState2 = _internal.extendedDynamicState2;
        ExtendedDynamicState2LogicOp = _internal.extendedDynamicState2LogicOp;
        ExtendedDynamicState2PatchControlPoints = _internal.extendedDynamicState2PatchControlPoints;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ExtendedDynamicState2 { get; set; }
    public VkBool32 ExtendedDynamicState2LogicOp { get; set; }
    public VkBool32 ExtendedDynamicState2PatchControlPoints { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState2FeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState2FeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ExtendedDynamicState2 != (uint)default)
        {
            _internal.extendedDynamicState2 = ExtendedDynamicState2;
        }
        if (ExtendedDynamicState2LogicOp != (uint)default)
        {
            _internal.extendedDynamicState2LogicOp = ExtendedDynamicState2LogicOp;
        }
        if (ExtendedDynamicState2PatchControlPoints != (uint)default)
        {
            _internal.extendedDynamicState2PatchControlPoints = ExtendedDynamicState2PatchControlPoints;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceExtendedDynamicState2FeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState2FeaturesEXT p)
    {
        return new PhysicalDeviceExtendedDynamicState2FeaturesEXT(p);
    }

}



