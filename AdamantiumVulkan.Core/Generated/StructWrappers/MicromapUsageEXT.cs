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

public unsafe partial class MicromapUsageEXT
{
    public MicromapUsageEXT()
    {
    }

    public MicromapUsageEXT(AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT _internal)
    {
        Count = _internal.count;
        SubdivisionLevel = _internal.subdivisionLevel;
        Format = _internal.format;
    }

    public uint Count { get; set; }
    public uint SubdivisionLevel { get; set; }
    public uint Format { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT();
        _internal.count = Count;
        _internal.subdivisionLevel = SubdivisionLevel;
        _internal.format = Format;
        return _internal;
    }

    public static implicit operator MicromapUsageEXT(AdamantiumVulkan.Core.Interop.VkMicromapUsageEXT m)
    {
        return new MicromapUsageEXT(m);
    }

}


