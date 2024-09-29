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

public unsafe partial class PhysicalDeviceExtendedDynamicState3PropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceExtendedDynamicState3PropertiesEXT()
    {
    }

    public PhysicalDeviceExtendedDynamicState3PropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState3PropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DynamicPrimitiveTopologyUnrestricted = _internal.dynamicPrimitiveTopologyUnrestricted;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DynamicPrimitiveTopologyUnrestricted { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState3PropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState3PropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DynamicPrimitiveTopologyUnrestricted != (uint)default)
        {
            _internal.dynamicPrimitiveTopologyUnrestricted = DynamicPrimitiveTopologyUnrestricted;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceExtendedDynamicState3PropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExtendedDynamicState3PropertiesEXT p)
    {
        return new PhysicalDeviceExtendedDynamicState3PropertiesEXT(p);
    }

}



