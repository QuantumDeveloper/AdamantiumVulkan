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

public unsafe partial class ComputePipelineCreateInfo : QBDisposableObject
{
    public ComputePipelineCreateInfo()
    {
    }

    public ComputePipelineCreateInfo(AdamantiumVulkan.Core.Interop.VkComputePipelineCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Stage = new PipelineShaderStageCreateInfo(_internal.stage);
        Layout = new PipelineLayout(_internal.layout);
        BasePipelineHandle = new Pipeline(_internal.basePipelineHandle);
        BasePipelineIndex = _internal.basePipelineIndex;
    }

    public StructureType SType => StructureType.ComputePipelineCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineCreateFlags Flags { get; set; }
    public PipelineShaderStageCreateInfo Stage { get; set; }
    public PipelineLayout Layout { get; set; }
    public Pipeline BasePipelineHandle { get; set; }
    public int BasePipelineIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkComputePipelineCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkComputePipelineCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        if (Stage != null)
        {
            _internal.stage = Stage.ToNative();
        }
        _internal.layout = Layout;
        _internal.basePipelineHandle = BasePipelineHandle;
        _internal.basePipelineIndex = BasePipelineIndex;
        return _internal;
    }

    public static implicit operator ComputePipelineCreateInfo(AdamantiumVulkan.Core.Interop.VkComputePipelineCreateInfo c)
    {
        return new ComputePipelineCreateInfo(c);
    }

}



