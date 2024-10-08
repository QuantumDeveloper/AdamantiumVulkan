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

public unsafe partial class PhysicalDeviceFragmentShadingRateEnumsPropertiesNV : QBDisposableObject
{
    public PhysicalDeviceFragmentShadingRateEnumsPropertiesNV()
    {
    }

    public PhysicalDeviceFragmentShadingRateEnumsPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxFragmentShadingRateInvocationCount = _internal.maxFragmentShadingRateInvocationCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public SampleCountFlagBits MaxFragmentShadingRateInvocationCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxFragmentShadingRateInvocationCount != default)
        {
            _internal.maxFragmentShadingRateInvocationCount = MaxFragmentShadingRateInvocationCount;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentShadingRateEnumsPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV p)
    {
        return new PhysicalDeviceFragmentShadingRateEnumsPropertiesNV(p);
    }

}



