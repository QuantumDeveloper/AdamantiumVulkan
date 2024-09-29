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

public unsafe partial class PhysicalDeviceSwapchainMaintenance1FeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceSwapchainMaintenance1FeaturesEXT()
    {
    }

    public PhysicalDeviceSwapchainMaintenance1FeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SwapchainMaintenance1 = _internal.swapchainMaintenance1;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 SwapchainMaintenance1 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SwapchainMaintenance1 != (uint)default)
        {
            _internal.swapchainMaintenance1 = SwapchainMaintenance1;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceSwapchainMaintenance1FeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT p)
    {
        return new PhysicalDeviceSwapchainMaintenance1FeaturesEXT(p);
    }

}



