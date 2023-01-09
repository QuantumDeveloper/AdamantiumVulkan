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

public unsafe partial class CoarseSampleOrderCustomNV : QBDisposableObject
{
    private NativeStruct<VkCoarseSampleLocationNV> pSampleLocations;

    public CoarseSampleOrderCustomNV()
    {
    }

    public CoarseSampleOrderCustomNV(AdamantiumVulkan.Core.Interop.VkCoarseSampleOrderCustomNV _internal)
    {
        ShadingRate = _internal.shadingRate;
        SampleCount = _internal.sampleCount;
        SampleLocationCount = _internal.sampleLocationCount;
        PSampleLocations = new CoarseSampleLocationNV(*_internal.pSampleLocations);
        NativeUtils.Free(_internal.pSampleLocations);
    }

    public ShadingRatePaletteEntryNV ShadingRate { get; set; }
    public uint SampleCount { get; set; }
    public uint SampleLocationCount { get; set; }
    public CoarseSampleLocationNV PSampleLocations { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCoarseSampleOrderCustomNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCoarseSampleOrderCustomNV();
        _internal.shadingRate = ShadingRate;
        _internal.sampleCount = SampleCount;
        _internal.sampleLocationCount = SampleLocationCount;
        pSampleLocations.Dispose();
        if (PSampleLocations != null)
        {
            var struct0 = PSampleLocations.ToNative();
            pSampleLocations = new NativeStruct<VkCoarseSampleLocationNV>(struct0);
            _internal.pSampleLocations = pSampleLocations.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pSampleLocations.Dispose();
    }


    public static implicit operator CoarseSampleOrderCustomNV(AdamantiumVulkan.Core.Interop.VkCoarseSampleOrderCustomNV c)
    {
        return new CoarseSampleOrderCustomNV(c);
    }

}



