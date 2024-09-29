// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Windows.Interop;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Windows;

public unsafe partial class SurfaceFullScreenExclusiveInfoEXT : QBDisposableObject
{
    public SurfaceFullScreenExclusiveInfoEXT()
    {
    }

    public SurfaceFullScreenExclusiveInfoEXT(AdamantiumVulkan.Windows.Interop.VkSurfaceFullScreenExclusiveInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FullScreenExclusive = _internal.fullScreenExclusive;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public FullScreenExclusiveEXT FullScreenExclusive { get; set; }

    public AdamantiumVulkan.Windows.Interop.VkSurfaceFullScreenExclusiveInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Windows.Interop.VkSurfaceFullScreenExclusiveInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FullScreenExclusive != default)
        {
            _internal.fullScreenExclusive = FullScreenExclusive;
        }
        return _internal;
    }

    public static implicit operator SurfaceFullScreenExclusiveInfoEXT(AdamantiumVulkan.Windows.Interop.VkSurfaceFullScreenExclusiveInfoEXT s)
    {
        return new SurfaceFullScreenExclusiveInfoEXT(s);
    }

}



