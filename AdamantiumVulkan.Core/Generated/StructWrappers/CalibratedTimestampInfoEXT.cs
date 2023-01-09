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

public unsafe partial class CalibratedTimestampInfoEXT : QBDisposableObject
{
    public CalibratedTimestampInfoEXT()
    {
    }

    public CalibratedTimestampInfoEXT(AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoEXT _internal)
    {
        PNext = _internal.pNext;
        TimeDomain = _internal.timeDomain;
    }

    public StructureType SType => StructureType.CalibratedTimestampInfoExt;
    public void* PNext { get; set; }
    public TimeDomainEXT TimeDomain { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.timeDomain = TimeDomain;
        return _internal;
    }

    public static implicit operator CalibratedTimestampInfoEXT(AdamantiumVulkan.Core.Interop.VkCalibratedTimestampInfoEXT c)
    {
        return new CalibratedTimestampInfoEXT(c);
    }

}



