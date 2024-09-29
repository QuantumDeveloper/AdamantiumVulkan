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

public unsafe partial class SampleLocationsInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkSampleLocationEXT> _pSampleLocations;

    public SampleLocationsInfoEXT()
    {
    }

    public SampleLocationsInfoEXT(AdamantiumVulkan.Core.Interop.VkSampleLocationsInfoEXT _internal)
    {
        PNext = _internal.pNext;
        SampleLocationsPerPixel = _internal.sampleLocationsPerPixel;
        SampleLocationGridSize = new Extent2D(_internal.sampleLocationGridSize);
        SampleLocationsCount = _internal.sampleLocationsCount;
        PSampleLocations = new SampleLocationEXT(*_internal.pSampleLocations);
        NativeUtils.Free(_internal.pSampleLocations);
    }

    public StructureType SType => StructureType.SampleLocationsInfoExt;
    public void* PNext { get; set; }
    public SampleCountFlagBits SampleLocationsPerPixel { get; set; }
    public Extent2D SampleLocationGridSize { get; set; }
    public uint SampleLocationsCount { get; set; }
    public SampleLocationEXT PSampleLocations { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSampleLocationsInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSampleLocationsInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SampleLocationsPerPixel != default)
        {
            _internal.sampleLocationsPerPixel = SampleLocationsPerPixel;
        }
        if (SampleLocationGridSize != default)
        {
            _internal.sampleLocationGridSize = SampleLocationGridSize.ToNative();
        }
        if (SampleLocationsCount != default)
        {
            _internal.sampleLocationsCount = SampleLocationsCount;
        }
        _pSampleLocations.Dispose();
        if (PSampleLocations != default)
        {
            var struct0 = PSampleLocations.ToNative();
            _pSampleLocations = new NativeStruct<AdamantiumVulkan.Core.Interop.VkSampleLocationEXT>(struct0);
            _internal.pSampleLocations = _pSampleLocations.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pSampleLocations.Dispose();
        SampleLocationGridSize?.Dispose();
    }


    public static implicit operator SampleLocationsInfoEXT(AdamantiumVulkan.Core.Interop.VkSampleLocationsInfoEXT s)
    {
        return new SampleLocationsInfoEXT(s);
    }

}



