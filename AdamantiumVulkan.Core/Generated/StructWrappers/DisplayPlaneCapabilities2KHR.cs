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

public unsafe partial class DisplayPlaneCapabilities2KHR : QBDisposableObject
{
    public DisplayPlaneCapabilities2KHR()
    {
    }

    public DisplayPlaneCapabilities2KHR(AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR _internal)
    {
        PNext = _internal.pNext;
        Capabilities = new DisplayPlaneCapabilitiesKHR(_internal.capabilities);
    }

    public StructureType SType => StructureType.DisplayPlaneCapabilities2Khr;
    public void* PNext { get; set; }
    public DisplayPlaneCapabilitiesKHR Capabilities { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (Capabilities != null)
        {
            _internal.capabilities = Capabilities.ToNative();
        }
        return _internal;
    }

    public static implicit operator DisplayPlaneCapabilities2KHR(AdamantiumVulkan.Core.Interop.VkDisplayPlaneCapabilities2KHR d)
    {
        return new DisplayPlaneCapabilities2KHR(d);
    }

}



