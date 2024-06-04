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

public unsafe partial class PipelineCreateFlags2CreateInfoKHR : QBDisposableObject
{
    public PipelineCreateFlags2CreateInfoKHR()
    {
    }

    public PipelineCreateFlags2CreateInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineCreateFlags2CreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPipelineCreateFlags2KHR Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineCreateFlags2CreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineCreateFlags2CreateInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        return _internal;
    }

    public static implicit operator PipelineCreateFlags2CreateInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineCreateFlags2CreateInfoKHR p)
    {
        return new PipelineCreateFlags2CreateInfoKHR(p);
    }

}



