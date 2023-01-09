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

public unsafe partial class Offset3D
{
    public Offset3D()
    {
    }

    public Offset3D(AdamantiumVulkan.Core.Interop.VkOffset3D _internal)
    {
        X = _internal.x;
        Y = _internal.y;
        Z = _internal.z;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public AdamantiumVulkan.Core.Interop.VkOffset3D ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkOffset3D();
        _internal.x = X;
        _internal.y = Y;
        _internal.z = Z;
        return _internal;
    }

    public static implicit operator Offset3D(AdamantiumVulkan.Core.Interop.VkOffset3D o)
    {
        return new Offset3D(o);
    }

}


