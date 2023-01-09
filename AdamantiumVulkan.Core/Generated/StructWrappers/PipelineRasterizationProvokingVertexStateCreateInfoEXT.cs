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

public unsafe partial class PipelineRasterizationProvokingVertexStateCreateInfoEXT : QBDisposableObject
{
    public PipelineRasterizationProvokingVertexStateCreateInfoEXT()
    {
    }

    public PipelineRasterizationProvokingVertexStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationProvokingVertexStateCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ProvokingVertexMode = _internal.provokingVertexMode;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ProvokingVertexModeEXT ProvokingVertexMode { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineRasterizationProvokingVertexStateCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineRasterizationProvokingVertexStateCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.provokingVertexMode = ProvokingVertexMode;
        return _internal;
    }

    public static implicit operator PipelineRasterizationProvokingVertexStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationProvokingVertexStateCreateInfoEXT p)
    {
        return new PipelineRasterizationProvokingVertexStateCreateInfoEXT(p);
    }

}


