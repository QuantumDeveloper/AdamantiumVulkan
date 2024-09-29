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

public unsafe partial class ViewportWScalingNV : QBDisposableObject
{
    public ViewportWScalingNV()
    {
    }

    public ViewportWScalingNV(AdamantiumVulkan.Core.Interop.VkViewportWScalingNV _internal)
    {
        Xcoeff = _internal.xcoeff;
        Ycoeff = _internal.ycoeff;
    }

    public float Xcoeff { get; set; }
    public float Ycoeff { get; set; }

    public AdamantiumVulkan.Core.Interop.VkViewportWScalingNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkViewportWScalingNV();
        if (Xcoeff != default)
        {
            _internal.xcoeff = Xcoeff;
        }
        if (Ycoeff != default)
        {
            _internal.ycoeff = Ycoeff;
        }
        return _internal;
    }

    public static implicit operator ViewportWScalingNV(AdamantiumVulkan.Core.Interop.VkViewportWScalingNV v)
    {
        return new ViewportWScalingNV(v);
    }

}



