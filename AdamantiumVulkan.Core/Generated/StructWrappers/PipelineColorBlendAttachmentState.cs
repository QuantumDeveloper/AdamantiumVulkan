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

public unsafe partial class PipelineColorBlendAttachmentState
{
    public PipelineColorBlendAttachmentState()
    {
    }

    public PipelineColorBlendAttachmentState(AdamantiumVulkan.Core.Interop.VkPipelineColorBlendAttachmentState _internal)
    {
        BlendEnable = _internal.blendEnable;
        SrcColorBlendFactor = _internal.srcColorBlendFactor;
        DstColorBlendFactor = _internal.dstColorBlendFactor;
        ColorBlendOp = _internal.colorBlendOp;
        SrcAlphaBlendFactor = _internal.srcAlphaBlendFactor;
        DstAlphaBlendFactor = _internal.dstAlphaBlendFactor;
        AlphaBlendOp = _internal.alphaBlendOp;
        ColorWriteMask = _internal.colorWriteMask;
    }

    public VkBool32 BlendEnable { get; set; }
    public BlendFactor SrcColorBlendFactor { get; set; }
    public BlendFactor DstColorBlendFactor { get; set; }
    public BlendOp ColorBlendOp { get; set; }
    public BlendFactor SrcAlphaBlendFactor { get; set; }
    public BlendFactor DstAlphaBlendFactor { get; set; }
    public BlendOp AlphaBlendOp { get; set; }
    public VkColorComponentFlags ColorWriteMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineColorBlendAttachmentState ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineColorBlendAttachmentState();
        _internal.blendEnable = BlendEnable;
        _internal.srcColorBlendFactor = SrcColorBlendFactor;
        _internal.dstColorBlendFactor = DstColorBlendFactor;
        _internal.colorBlendOp = ColorBlendOp;
        _internal.srcAlphaBlendFactor = SrcAlphaBlendFactor;
        _internal.dstAlphaBlendFactor = DstAlphaBlendFactor;
        _internal.alphaBlendOp = AlphaBlendOp;
        _internal.colorWriteMask = ColorWriteMask;
        return _internal;
    }

    public static implicit operator PipelineColorBlendAttachmentState(AdamantiumVulkan.Core.Interop.VkPipelineColorBlendAttachmentState p)
    {
        return new PipelineColorBlendAttachmentState(p);
    }

}


