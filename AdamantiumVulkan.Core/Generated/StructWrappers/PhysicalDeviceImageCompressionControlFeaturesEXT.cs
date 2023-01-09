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

public unsafe partial class PhysicalDeviceImageCompressionControlFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceImageCompressionControlFeaturesEXT()
    {
    }

    public PhysicalDeviceImageCompressionControlFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageCompressionControl = _internal.imageCompressionControl;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ImageCompressionControl { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.imageCompressionControl = ImageCompressionControl;
        return _internal;
    }

    public static implicit operator PhysicalDeviceImageCompressionControlFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageCompressionControlFeaturesEXT p)
    {
        return new PhysicalDeviceImageCompressionControlFeaturesEXT(p);
    }

}


