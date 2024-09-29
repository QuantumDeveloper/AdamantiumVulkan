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

public unsafe partial class PhysicalDeviceNestedCommandBufferPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceNestedCommandBufferPropertiesEXT()
    {
    }

    public PhysicalDeviceNestedCommandBufferPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceNestedCommandBufferPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxCommandBufferNestingLevel = _internal.maxCommandBufferNestingLevel;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxCommandBufferNestingLevel { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceNestedCommandBufferPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceNestedCommandBufferPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxCommandBufferNestingLevel != default)
        {
            _internal.maxCommandBufferNestingLevel = MaxCommandBufferNestingLevel;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceNestedCommandBufferPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceNestedCommandBufferPropertiesEXT p)
    {
        return new PhysicalDeviceNestedCommandBufferPropertiesEXT(p);
    }

}



