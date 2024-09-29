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

public unsafe partial class DeviceDiagnosticsConfigCreateInfoNV : QBDisposableObject
{
    public DeviceDiagnosticsConfigCreateInfoNV()
    {
    }

    public DeviceDiagnosticsConfigCreateInfoNV(AdamantiumVulkan.Core.Interop.VkDeviceDiagnosticsConfigCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkDeviceDiagnosticsConfigFlagsNV Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceDiagnosticsConfigCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceDiagnosticsConfigCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        return _internal;
    }

    public static implicit operator DeviceDiagnosticsConfigCreateInfoNV(AdamantiumVulkan.Core.Interop.VkDeviceDiagnosticsConfigCreateInfoNV d)
    {
        return new DeviceDiagnosticsConfigCreateInfoNV(d);
    }

}



