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

public unsafe partial class ViewportSwizzleNV : QBDisposableObject
{
    public ViewportSwizzleNV()
    {
    }

    public ViewportSwizzleNV(AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV _internal)
    {
        X = _internal.x;
        Y = _internal.y;
        Z = _internal.z;
        W = _internal.w;
    }

    public ViewportCoordinateSwizzleNV X { get; set; }
    public ViewportCoordinateSwizzleNV Y { get; set; }
    public ViewportCoordinateSwizzleNV Z { get; set; }
    public ViewportCoordinateSwizzleNV W { get; set; }

    public AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV();
        if (X != default)
        {
            _internal.x = X;
        }
        if (Y != default)
        {
            _internal.y = Y;
        }
        if (Z != default)
        {
            _internal.z = Z;
        }
        if (W != default)
        {
            _internal.w = W;
        }
        return _internal;
    }

    public static implicit operator ViewportSwizzleNV(AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV v)
    {
        return new ViewportSwizzleNV(v);
    }

}



