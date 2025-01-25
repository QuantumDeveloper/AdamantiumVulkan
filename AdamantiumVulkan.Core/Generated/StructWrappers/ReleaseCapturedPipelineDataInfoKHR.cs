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

public unsafe partial class ReleaseCapturedPipelineDataInfoKHR : QBDisposableObject
{
    public ReleaseCapturedPipelineDataInfoKHR()
    {
    }

    public ReleaseCapturedPipelineDataInfoKHR(AdamantiumVulkan.Core.Interop.VkReleaseCapturedPipelineDataInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Pipeline = new Pipeline(_internal.pipeline);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Pipeline Pipeline { get; set; }

    public AdamantiumVulkan.Core.Interop.VkReleaseCapturedPipelineDataInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkReleaseCapturedPipelineDataInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Pipeline != default)
        {
            _internal.pipeline = Pipeline;
        }
        return _internal;
    }

    public static implicit operator ReleaseCapturedPipelineDataInfoKHR(AdamantiumVulkan.Core.Interop.VkReleaseCapturedPipelineDataInfoKHR r)
    {
        return new ReleaseCapturedPipelineDataInfoKHR(r);
    }

}



