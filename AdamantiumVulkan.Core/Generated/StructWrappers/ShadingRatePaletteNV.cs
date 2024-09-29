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

public unsafe partial class ShadingRatePaletteNV : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.ShadingRatePaletteEntryNV> _pShadingRatePaletteEntries;

    public ShadingRatePaletteNV()
    {
    }

    public ShadingRatePaletteNV(AdamantiumVulkan.Core.Interop.VkShadingRatePaletteNV _internal)
    {
        ShadingRatePaletteEntryCount = _internal.shadingRatePaletteEntryCount;
        PShadingRatePaletteEntries = NativeUtils.PointerToManagedArray(_internal.pShadingRatePaletteEntries, _internal.shadingRatePaletteEntryCount);
    }

    public uint ShadingRatePaletteEntryCount { get; set; }
    public ShadingRatePaletteEntryNV[] PShadingRatePaletteEntries { get; set; }

    public AdamantiumVulkan.Core.Interop.VkShadingRatePaletteNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkShadingRatePaletteNV();
        if (ShadingRatePaletteEntryCount != default)
        {
            _internal.shadingRatePaletteEntryCount = ShadingRatePaletteEntryCount;
        }
        _pShadingRatePaletteEntries.Dispose();
        if (PShadingRatePaletteEntries != null)
        {
            _pShadingRatePaletteEntries = new NativeStructArray<AdamantiumVulkan.Core.ShadingRatePaletteEntryNV>(PShadingRatePaletteEntries);
            _internal.pShadingRatePaletteEntries = _pShadingRatePaletteEntries.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pShadingRatePaletteEntries.Dispose();
    }


    public static implicit operator ShadingRatePaletteNV(AdamantiumVulkan.Core.Interop.VkShadingRatePaletteNV s)
    {
        return new ShadingRatePaletteNV(s);
    }

}



