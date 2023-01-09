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

public unsafe partial class PhysicalDeviceColorWriteEnableFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceColorWriteEnableFeaturesEXT()
    {
    }

    public PhysicalDeviceColorWriteEnableFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceColorWriteEnableFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ColorWriteEnable = _internal.colorWriteEnable;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ColorWriteEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceColorWriteEnableFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceColorWriteEnableFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.colorWriteEnable = ColorWriteEnable;
        return _internal;
    }

    public static implicit operator PhysicalDeviceColorWriteEnableFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceColorWriteEnableFeaturesEXT p)
    {
        return new PhysicalDeviceColorWriteEnableFeaturesEXT(p);
    }

}



