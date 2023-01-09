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

public unsafe partial class PhysicalDeviceSubpassShadingPropertiesHUAWEI : QBDisposableObject
{
    public PhysicalDeviceSubpassShadingPropertiesHUAWEI()
    {
    }

    public PhysicalDeviceSubpassShadingPropertiesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubpassShadingPropertiesHUAWEI _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxSubpassShadingWorkgroupSizeAspectRatio = _internal.maxSubpassShadingWorkgroupSizeAspectRatio;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxSubpassShadingWorkgroupSizeAspectRatio { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubpassShadingPropertiesHUAWEI ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubpassShadingPropertiesHUAWEI();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.maxSubpassShadingWorkgroupSizeAspectRatio = MaxSubpassShadingWorkgroupSizeAspectRatio;
        return _internal;
    }

    public static implicit operator PhysicalDeviceSubpassShadingPropertiesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubpassShadingPropertiesHUAWEI p)
    {
        return new PhysicalDeviceSubpassShadingPropertiesHUAWEI(p);
    }

}


