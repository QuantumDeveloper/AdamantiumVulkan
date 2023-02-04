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

public unsafe partial class RayTracingPipelineCreateInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo> _pStages;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoNV> _pGroups;

    public RayTracingPipelineCreateInfoNV()
    {
    }

    public RayTracingPipelineCreateInfoNV(AdamantiumVulkan.Core.Interop.VkRayTracingPipelineCreateInfoNV _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        StageCount = _internal.stageCount;
        PStages = new PipelineShaderStageCreateInfo(*_internal.pStages);
        NativeUtils.Free(_internal.pStages);
        GroupCount = _internal.groupCount;
        PGroups = new RayTracingShaderGroupCreateInfoNV(*_internal.pGroups);
        NativeUtils.Free(_internal.pGroups);
        MaxRecursionDepth = _internal.maxRecursionDepth;
        Layout = new PipelineLayout(_internal.layout);
        BasePipelineHandle = new Pipeline(_internal.basePipelineHandle);
        BasePipelineIndex = _internal.basePipelineIndex;
    }

    public StructureType SType => StructureType.RayTracingPipelineCreateInfoNv;
    public void* PNext { get; set; }
    public VkPipelineCreateFlags Flags { get; set; }
    public uint StageCount { get; set; }
    public PipelineShaderStageCreateInfo PStages { get; set; }
    public uint GroupCount { get; set; }
    public RayTracingShaderGroupCreateInfoNV PGroups { get; set; }
    public uint MaxRecursionDepth { get; set; }
    public PipelineLayout Layout { get; set; }
    public Pipeline BasePipelineHandle { get; set; }
    public int BasePipelineIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRayTracingPipelineCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRayTracingPipelineCreateInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.stageCount = StageCount;
        _pStages.Dispose();
        if (PStages != null)
        {
            var struct0 = PStages.ToNative();
            _pStages = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo>(struct0);
            _internal.pStages = _pStages.Handle;
        }
        _internal.groupCount = GroupCount;
        _pGroups.Dispose();
        if (PGroups != null)
        {
            var struct1 = PGroups.ToNative();
            _pGroups = new NativeStruct<AdamantiumVulkan.Core.Interop.VkRayTracingShaderGroupCreateInfoNV>(struct1);
            _internal.pGroups = _pGroups.Handle;
        }
        _internal.maxRecursionDepth = MaxRecursionDepth;
        _internal.layout = Layout;
        _internal.basePipelineHandle = BasePipelineHandle;
        _internal.basePipelineIndex = BasePipelineIndex;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStages.Dispose();
        _pGroups.Dispose();
    }


    public static implicit operator RayTracingPipelineCreateInfoNV(AdamantiumVulkan.Core.Interop.VkRayTracingPipelineCreateInfoNV r)
    {
        return new RayTracingPipelineCreateInfoNV(r);
    }

}



