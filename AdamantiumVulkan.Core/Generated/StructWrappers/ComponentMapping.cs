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

public unsafe partial class ComponentMapping
{
    public ComponentMapping()
    {
    }

    public ComponentMapping(AdamantiumVulkan.Core.Interop.VkComponentMapping _internal)
    {
        R = _internal.r;
        G = _internal.g;
        B = _internal.b;
        A = _internal.a;
    }

    public ComponentSwizzle R { get; set; }
    public ComponentSwizzle G { get; set; }
    public ComponentSwizzle B { get; set; }
    public ComponentSwizzle A { get; set; }

    public AdamantiumVulkan.Core.Interop.VkComponentMapping ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkComponentMapping();
        _internal.r = R;
        _internal.g = G;
        _internal.b = B;
        _internal.a = A;
        return _internal;
    }

    public static implicit operator ComponentMapping(AdamantiumVulkan.Core.Interop.VkComponentMapping c)
    {
        return new ComponentMapping(c);
    }

}



