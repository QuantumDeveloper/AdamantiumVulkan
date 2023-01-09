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

public unsafe partial class PipelineRasterizationDepthClipStateCreateInfoEXT : QBDisposableObject
{
    public PipelineRasterizationDepthClipStateCreateInfoEXT()
    {
    }

    public PipelineRasterizationDepthClipStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationDepthClipStateCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        DepthClipEnable = _internal.depthClipEnable;
    }

    public StructureType SType => StructureType.PipelineRasterizationDepthClipStateCreateInfoExt;
    public void* PNext { get; set; }
    public VkPipelineRasterizationDepthClipStateCreateFlagsEXT Flags { get; set; }
    public VkBool32 DepthClipEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineRasterizationDepthClipStateCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineRasterizationDepthClipStateCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.depthClipEnable = DepthClipEnable;
        return _internal;
    }

    public static implicit operator PipelineRasterizationDepthClipStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationDepthClipStateCreateInfoEXT p)
    {
        return new PipelineRasterizationDepthClipStateCreateInfoEXT(p);
    }

}



