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

public unsafe partial class PhysicalDeviceAntiLagFeaturesAMD : QBDisposableObject
{
    public PhysicalDeviceAntiLagFeaturesAMD()
    {
    }

    public PhysicalDeviceAntiLagFeaturesAMD(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAntiLagFeaturesAMD _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AntiLag = _internal.antiLag;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 AntiLag { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAntiLagFeaturesAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAntiLagFeaturesAMD();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (AntiLag != (uint)default)
        {
            _internal.antiLag = AntiLag;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceAntiLagFeaturesAMD(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAntiLagFeaturesAMD p)
    {
        return new PhysicalDeviceAntiLagFeaturesAMD(p);
    }

}



