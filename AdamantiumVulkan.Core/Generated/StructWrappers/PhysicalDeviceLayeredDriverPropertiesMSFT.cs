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

public unsafe partial class PhysicalDeviceLayeredDriverPropertiesMSFT : QBDisposableObject
{
    public PhysicalDeviceLayeredDriverPropertiesMSFT()
    {
    }

    public PhysicalDeviceLayeredDriverPropertiesMSFT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLayeredDriverPropertiesMSFT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        UnderlyingAPI = _internal.underlyingAPI;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public LayeredDriverUnderlyingApiMSFT UnderlyingAPI { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLayeredDriverPropertiesMSFT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLayeredDriverPropertiesMSFT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (UnderlyingAPI != default)
        {
            _internal.underlyingAPI = UnderlyingAPI;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceLayeredDriverPropertiesMSFT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLayeredDriverPropertiesMSFT p)
    {
        return new PhysicalDeviceLayeredDriverPropertiesMSFT(p);
    }

}



