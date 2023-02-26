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

public unsafe partial class Rect2D
{
    public Rect2D()
    {
    }

    public Rect2D(AdamantiumVulkan.Core.Interop.VkRect2D _internal)
    {
        Offset = new Offset2D(_internal.offset);
        Extent = new Extent2D(_internal.extent);
    }

    public Offset2D Offset { get; set; }
    public Extent2D Extent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRect2D ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRect2D();
        if (Offset != null)
        {
            _internal.offset = Offset.ToNative();
        }
        if (Extent != null)
        {
            _internal.extent = Extent.ToNative();
        }
        return _internal;
    }

    public static implicit operator Rect2D(AdamantiumVulkan.Core.Interop.VkRect2D r)
    {
        return new Rect2D(r);
    }

}



