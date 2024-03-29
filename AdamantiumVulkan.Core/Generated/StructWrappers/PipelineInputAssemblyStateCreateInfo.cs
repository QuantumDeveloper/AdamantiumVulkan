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

public unsafe partial class PipelineInputAssemblyStateCreateInfo : QBDisposableObject
{
    public PipelineInputAssemblyStateCreateInfo()
    {
    }

    public PipelineInputAssemblyStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineInputAssemblyStateCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Topology = _internal.topology;
        PrimitiveRestartEnable = _internal.primitiveRestartEnable;
    }

    public StructureType SType => StructureType.PipelineInputAssemblyStateCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineInputAssemblyStateCreateFlags Flags { get; set; }
    public PrimitiveTopology Topology { get; set; }
    public VkBool32 PrimitiveRestartEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineInputAssemblyStateCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineInputAssemblyStateCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.topology = Topology;
        _internal.primitiveRestartEnable = PrimitiveRestartEnable;
        return _internal;
    }

    public static implicit operator PipelineInputAssemblyStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineInputAssemblyStateCreateInfo p)
    {
        return new PipelineInputAssemblyStateCreateInfo(p);
    }

}



