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

public unsafe partial class SamplerBorderColorComponentMappingCreateInfoEXT : QBDisposableObject
{
    public SamplerBorderColorComponentMappingCreateInfoEXT()
    {
    }

    public SamplerBorderColorComponentMappingCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkSamplerBorderColorComponentMappingCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Components = new ComponentMapping(_internal.components);
        Srgb = _internal.srgb;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ComponentMapping Components { get; set; }
    public VkBool32 Srgb { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSamplerBorderColorComponentMappingCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSamplerBorderColorComponentMappingCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (Components != null)
        {
            _internal.components = Components.ToNative();
        }
        _internal.srgb = Srgb;
        return _internal;
    }

    public static implicit operator SamplerBorderColorComponentMappingCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkSamplerBorderColorComponentMappingCreateInfoEXT s)
    {
        return new SamplerBorderColorComponentMappingCreateInfoEXT(s);
    }

}



