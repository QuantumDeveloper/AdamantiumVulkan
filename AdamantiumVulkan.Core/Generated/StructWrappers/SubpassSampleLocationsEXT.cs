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

public unsafe partial class SubpassSampleLocationsEXT : QBDisposableObject
{
    public SubpassSampleLocationsEXT()
    {
    }

    public SubpassSampleLocationsEXT(AdamantiumVulkan.Core.Interop.VkSubpassSampleLocationsEXT _internal)
    {
        SubpassIndex = _internal.subpassIndex;
        SampleLocationsInfo = new SampleLocationsInfoEXT(_internal.sampleLocationsInfo);
    }

    public uint SubpassIndex { get; set; }
    public SampleLocationsInfoEXT SampleLocationsInfo { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSubpassSampleLocationsEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSubpassSampleLocationsEXT();
        if (SubpassIndex != default)
        {
            _internal.subpassIndex = SubpassIndex;
        }
        if (SampleLocationsInfo != default)
        {
            _internal.sampleLocationsInfo = SampleLocationsInfo.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        SampleLocationsInfo?.Dispose();
    }


    public static implicit operator SubpassSampleLocationsEXT(AdamantiumVulkan.Core.Interop.VkSubpassSampleLocationsEXT s)
    {
        return new SubpassSampleLocationsEXT(s);
    }

}



