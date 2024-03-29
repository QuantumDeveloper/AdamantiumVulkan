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

public unsafe partial class ClearRect
{
    public ClearRect()
    {
    }

    public ClearRect(AdamantiumVulkan.Core.Interop.VkClearRect _internal)
    {
        Rect = new Rect2D(_internal.rect);
        BaseArrayLayer = _internal.baseArrayLayer;
        LayerCount = _internal.layerCount;
    }

    public Rect2D Rect { get; set; }
    public uint BaseArrayLayer { get; set; }
    public uint LayerCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkClearRect ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkClearRect();
        if (Rect != null)
        {
            _internal.rect = Rect.ToNative();
        }
        _internal.baseArrayLayer = BaseArrayLayer;
        _internal.layerCount = LayerCount;
        return _internal;
    }

    public static implicit operator ClearRect(AdamantiumVulkan.Core.Interop.VkClearRect c)
    {
        return new ClearRect(c);
    }

}



