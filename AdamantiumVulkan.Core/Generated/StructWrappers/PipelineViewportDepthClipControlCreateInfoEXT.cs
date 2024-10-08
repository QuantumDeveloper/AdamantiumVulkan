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

public unsafe partial class PipelineViewportDepthClipControlCreateInfoEXT : QBDisposableObject
{
    public PipelineViewportDepthClipControlCreateInfoEXT()
    {
    }

    public PipelineViewportDepthClipControlCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineViewportDepthClipControlCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        NegativeOneToOne = _internal.negativeOneToOne;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 NegativeOneToOne { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineViewportDepthClipControlCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineViewportDepthClipControlCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (NegativeOneToOne != (uint)default)
        {
            _internal.negativeOneToOne = NegativeOneToOne;
        }
        return _internal;
    }

    public static implicit operator PipelineViewportDepthClipControlCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineViewportDepthClipControlCreateInfoEXT p)
    {
        return new PipelineViewportDepthClipControlCreateInfoEXT(p);
    }

}



