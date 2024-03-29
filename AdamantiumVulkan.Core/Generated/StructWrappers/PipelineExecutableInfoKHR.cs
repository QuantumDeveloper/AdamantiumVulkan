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

public unsafe partial class PipelineExecutableInfoKHR : QBDisposableObject
{
    public PipelineExecutableInfoKHR()
    {
    }

    public PipelineExecutableInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Pipeline = new Pipeline(_internal.pipeline);
        ExecutableIndex = _internal.executableIndex;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Pipeline Pipeline { get; set; }
    public uint ExecutableIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineExecutableInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineExecutableInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.pipeline = Pipeline;
        _internal.executableIndex = ExecutableIndex;
        return _internal;
    }

    public static implicit operator PipelineExecutableInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableInfoKHR p)
    {
        return new PipelineExecutableInfoKHR(p);
    }

}



