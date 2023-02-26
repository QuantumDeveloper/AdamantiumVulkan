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

public unsafe partial class PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT()
    {
    }

    public PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageCompressionControlSwapchain = _internal.imageCompressionControlSwapchain;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ImageCompressionControlSwapchain { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.imageCompressionControlSwapchain = ImageCompressionControlSwapchain;
        return _internal;
    }

    public static implicit operator PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT p)
    {
        return new PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT(p);
    }

}



