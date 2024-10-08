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

public unsafe partial class PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT()
    {
    }

    public PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MultisampledRenderToSingleSampled = _internal.multisampledRenderToSingleSampled;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 MultisampledRenderToSingleSampled { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MultisampledRenderToSingleSampled != (uint)default)
        {
            _internal.multisampledRenderToSingleSampled = MultisampledRenderToSingleSampled;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT p)
    {
        return new PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT(p);
    }

}



