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

public unsafe partial class PipelineIndirectDeviceAddressInfoNV : QBDisposableObject
{
    public PipelineIndirectDeviceAddressInfoNV()
    {
    }

    public PipelineIndirectDeviceAddressInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineIndirectDeviceAddressInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineBindPoint = _internal.pipelineBindPoint;
        Pipeline = new Pipeline(_internal.pipeline);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PipelineBindPoint PipelineBindPoint { get; set; }
    public Pipeline Pipeline { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineIndirectDeviceAddressInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineIndirectDeviceAddressInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PipelineBindPoint != default)
        {
            _internal.pipelineBindPoint = PipelineBindPoint;
        }
        if (Pipeline != default)
        {
            _internal.pipeline = Pipeline;
        }
        return _internal;
    }

    public static implicit operator PipelineIndirectDeviceAddressInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineIndirectDeviceAddressInfoNV p)
    {
        return new PipelineIndirectDeviceAddressInfoNV(p);
    }

}


