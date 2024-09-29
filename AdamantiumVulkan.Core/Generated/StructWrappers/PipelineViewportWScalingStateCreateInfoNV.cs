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

public unsafe partial class PipelineViewportWScalingStateCreateInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkViewportWScalingNV> _pViewportWScalings;

    public PipelineViewportWScalingStateCreateInfoNV()
    {
    }

    public PipelineViewportWScalingStateCreateInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineViewportWScalingStateCreateInfoNV _internal)
    {
        PNext = _internal.pNext;
        ViewportWScalingEnable = _internal.viewportWScalingEnable;
        ViewportCount = _internal.viewportCount;
        PViewportWScalings = new ViewportWScalingNV(*_internal.pViewportWScalings);
        NativeUtils.Free(_internal.pViewportWScalings);
    }

    public StructureType SType => StructureType.PipelineViewportWScalingStateCreateInfoNv;
    public void* PNext { get; set; }
    public VkBool32 ViewportWScalingEnable { get; set; }
    public uint ViewportCount { get; set; }
    public ViewportWScalingNV PViewportWScalings { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineViewportWScalingStateCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineViewportWScalingStateCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ViewportWScalingEnable != (uint)default)
        {
            _internal.viewportWScalingEnable = ViewportWScalingEnable;
        }
        if (ViewportCount != default)
        {
            _internal.viewportCount = ViewportCount;
        }
        _pViewportWScalings.Dispose();
        if (PViewportWScalings != default)
        {
            var struct0 = PViewportWScalings.ToNative();
            _pViewportWScalings = new NativeStruct<AdamantiumVulkan.Core.Interop.VkViewportWScalingNV>(struct0);
            _internal.pViewportWScalings = _pViewportWScalings.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pViewportWScalings.Dispose();
    }


    public static implicit operator PipelineViewportWScalingStateCreateInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineViewportWScalingStateCreateInfoNV p)
    {
        return new PipelineViewportWScalingStateCreateInfoNV(p);
    }

}



