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

public unsafe partial class Extent2D : QBDisposableObject
{
    public Extent2D()
    {
    }

    public Extent2D(AdamantiumVulkan.Core.Interop.VkExtent2D _internal)
    {
        Width = _internal.width;
        Height = _internal.height;
    }

    public uint Width { get; set; }
    public uint Height { get; set; }

    public AdamantiumVulkan.Core.Interop.VkExtent2D ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkExtent2D();
        if (Width != default)
        {
            _internal.width = Width;
        }
        if (Height != default)
        {
            _internal.height = Height;
        }
        return _internal;
    }

    public static implicit operator Extent2D(AdamantiumVulkan.Core.Interop.VkExtent2D e)
    {
        return new Extent2D(e);
    }

}



