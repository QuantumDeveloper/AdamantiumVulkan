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

public unsafe partial class PhysicalDeviceDepthClipControlFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceDepthClipControlFeaturesEXT()
    {
    }

    public PhysicalDeviceDepthClipControlFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDepthClipControlFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DepthClipControl = _internal.depthClipControl;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DepthClipControl { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDepthClipControlFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDepthClipControlFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.depthClipControl = DepthClipControl;
        return _internal;
    }

    public static implicit operator PhysicalDeviceDepthClipControlFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDepthClipControlFeaturesEXT p)
    {
        return new PhysicalDeviceDepthClipControlFeaturesEXT(p);
    }

}



