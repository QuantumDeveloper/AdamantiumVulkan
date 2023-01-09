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

public unsafe partial class PipelineSampleLocationsStateCreateInfoEXT : QBDisposableObject
{
    public PipelineSampleLocationsStateCreateInfoEXT()
    {
    }

    public PipelineSampleLocationsStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineSampleLocationsStateCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        SampleLocationsEnable = _internal.sampleLocationsEnable;
        SampleLocationsInfo = new SampleLocationsInfoEXT(_internal.sampleLocationsInfo);
    }

    public StructureType SType => StructureType.PipelineSampleLocationsStateCreateInfoExt;
    public void* PNext { get; set; }
    public VkBool32 SampleLocationsEnable { get; set; }
    public SampleLocationsInfoEXT SampleLocationsInfo { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineSampleLocationsStateCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineSampleLocationsStateCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.sampleLocationsEnable = SampleLocationsEnable;
        if (SampleLocationsInfo != null)
        {
            _internal.sampleLocationsInfo = SampleLocationsInfo.ToNative();
        }
        return _internal;
    }

    public static implicit operator PipelineSampleLocationsStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineSampleLocationsStateCreateInfoEXT p)
    {
        return new PipelineSampleLocationsStateCreateInfoEXT(p);
    }

}


