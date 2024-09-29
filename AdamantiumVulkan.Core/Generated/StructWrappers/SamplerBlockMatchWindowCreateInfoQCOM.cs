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

public unsafe partial class SamplerBlockMatchWindowCreateInfoQCOM : QBDisposableObject
{
    public SamplerBlockMatchWindowCreateInfoQCOM()
    {
    }

    public SamplerBlockMatchWindowCreateInfoQCOM(AdamantiumVulkan.Core.Interop.VkSamplerBlockMatchWindowCreateInfoQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        WindowExtent = new Extent2D(_internal.windowExtent);
        WindowCompareMode = _internal.windowCompareMode;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Extent2D WindowExtent { get; set; }
    public BlockMatchWindowCompareModeQCOM WindowCompareMode { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSamplerBlockMatchWindowCreateInfoQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSamplerBlockMatchWindowCreateInfoQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (WindowExtent != default)
        {
            _internal.windowExtent = WindowExtent.ToNative();
        }
        if (WindowCompareMode != default)
        {
            _internal.windowCompareMode = WindowCompareMode;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        WindowExtent?.Dispose();
    }


    public static implicit operator SamplerBlockMatchWindowCreateInfoQCOM(AdamantiumVulkan.Core.Interop.VkSamplerBlockMatchWindowCreateInfoQCOM s)
    {
        return new SamplerBlockMatchWindowCreateInfoQCOM(s);
    }

}


