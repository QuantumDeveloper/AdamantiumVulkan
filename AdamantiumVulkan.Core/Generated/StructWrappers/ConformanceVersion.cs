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

public unsafe partial class ConformanceVersion
{
    public ConformanceVersion()
    {
    }

    public ConformanceVersion(AdamantiumVulkan.Core.Interop.VkConformanceVersion _internal)
    {
        Major = _internal.major;
        Minor = _internal.minor;
        Subminor = _internal.subminor;
        Patch = _internal.patch;
    }

    public byte Major { get; set; }
    public byte Minor { get; set; }
    public byte Subminor { get; set; }
    public byte Patch { get; set; }

    public AdamantiumVulkan.Core.Interop.VkConformanceVersion ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkConformanceVersion();
        _internal.major = Major;
        _internal.minor = Minor;
        _internal.subminor = Subminor;
        _internal.patch = Patch;
        return _internal;
    }

    public static implicit operator ConformanceVersion(AdamantiumVulkan.Core.Interop.VkConformanceVersion c)
    {
        return new ConformanceVersion(c);
    }

}



