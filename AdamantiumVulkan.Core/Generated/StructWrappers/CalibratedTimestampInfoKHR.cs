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

public unsafe partial class CalibratedTimestampInfoKHR : QBDisposableObject
{
    public CalibratedTimestampInfoKHR()
    {
    }

    public CalibratedTimestampInfoKHR(AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        TimeDomain = _internal.timeDomain;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public TimeDomainKHR TimeDomain { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (TimeDomain != default)
        {
            _internal.timeDomain = TimeDomain;
        }
        return _internal;
    }

    public static implicit operator CalibratedTimestampInfoKHR(AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoKHR c)
    {
        return new CalibratedTimestampInfoKHR(c);
    }

}



