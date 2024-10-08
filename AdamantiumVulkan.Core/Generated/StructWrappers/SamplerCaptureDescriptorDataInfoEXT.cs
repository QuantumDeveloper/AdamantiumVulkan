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

public unsafe partial class SamplerCaptureDescriptorDataInfoEXT : QBDisposableObject
{
    public SamplerCaptureDescriptorDataInfoEXT()
    {
    }

    public SamplerCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkSamplerCaptureDescriptorDataInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Sampler = new Sampler(_internal.sampler);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Sampler Sampler { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSamplerCaptureDescriptorDataInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSamplerCaptureDescriptorDataInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Sampler != default)
        {
            _internal.sampler = Sampler;
        }
        return _internal;
    }

    public static implicit operator SamplerCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkSamplerCaptureDescriptorDataInfoEXT s)
    {
        return new SamplerCaptureDescriptorDataInfoEXT(s);
    }

}



