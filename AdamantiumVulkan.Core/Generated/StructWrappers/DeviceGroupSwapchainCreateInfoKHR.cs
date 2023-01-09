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

public unsafe partial class DeviceGroupSwapchainCreateInfoKHR : QBDisposableObject
{
    public DeviceGroupSwapchainCreateInfoKHR()
    {
    }

    public DeviceGroupSwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkDeviceGroupSwapchainCreateInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Modes = _internal.modes;
    }

    public StructureType SType => StructureType.DeviceGroupSwapchainCreateInfoKhr;
    public void* PNext { get; set; }
    public VkDeviceGroupPresentModeFlagsKHR Modes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceGroupSwapchainCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceGroupSwapchainCreateInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.modes = Modes;
        return _internal;
    }

    public static implicit operator DeviceGroupSwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkDeviceGroupSwapchainCreateInfoKHR d)
    {
        return new DeviceGroupSwapchainCreateInfoKHR(d);
    }

}



