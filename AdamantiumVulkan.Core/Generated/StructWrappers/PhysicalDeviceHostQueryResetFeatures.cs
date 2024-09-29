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

public unsafe partial class PhysicalDeviceHostQueryResetFeatures : QBDisposableObject
{
    public PhysicalDeviceHostQueryResetFeatures()
    {
    }

    public PhysicalDeviceHostQueryResetFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceHostQueryResetFeatures _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        HostQueryReset = _internal.hostQueryReset;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 HostQueryReset { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceHostQueryResetFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceHostQueryResetFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (HostQueryReset != (uint)default)
        {
            _internal.hostQueryReset = HostQueryReset;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceHostQueryResetFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceHostQueryResetFeatures p)
    {
        return new PhysicalDeviceHostQueryResetFeatures(p);
    }

}



