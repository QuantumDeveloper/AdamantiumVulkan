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

public unsafe partial class GraphicsPipelineShaderGroupsCreateInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV> pGroups;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPipeline_T> pPipelines;

    public GraphicsPipelineShaderGroupsCreateInfoNV()
    {
    }

    public GraphicsPipelineShaderGroupsCreateInfoNV(AdamantiumVulkan.Core.Interop.VkGraphicsPipelineShaderGroupsCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        GroupCount = _internal.groupCount;
        PGroups = new GraphicsShaderGroupCreateInfoNV(*_internal.pGroups);
        NativeUtils.Free(_internal.pGroups);
        PipelineCount = _internal.pipelineCount;
        Pipelines = new Pipeline(*_internal.pPipelines);
        NativeUtils.Free(_internal.pPipelines);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint GroupCount { get; set; }
    public GraphicsShaderGroupCreateInfoNV PGroups { get; set; }
    public uint PipelineCount { get; set; }
    public Pipeline Pipelines { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGraphicsPipelineShaderGroupsCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGraphicsPipelineShaderGroupsCreateInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.groupCount = GroupCount;
        pGroups.Dispose();
        if (PGroups != null)
        {
            var struct0 = PGroups.ToNative();
            pGroups = new NativeStruct<AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV>(struct0);
            _internal.pGroups = pGroups.Handle;
        }
        _internal.pipelineCount = PipelineCount;
        pPipelines.Dispose();
        if (Pipelines != null)
        {
            AdamantiumVulkan.Core.Interop.VkPipeline_T struct1 = Pipelines;
            pPipelines = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPipeline_T>(struct1);
            _internal.pPipelines = pPipelines.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pGroups.Dispose();
        pPipelines.Dispose();
    }


    public static implicit operator GraphicsPipelineShaderGroupsCreateInfoNV(AdamantiumVulkan.Core.Interop.VkGraphicsPipelineShaderGroupsCreateInfoNV g)
    {
        return new GraphicsPipelineShaderGroupsCreateInfoNV(g);
    }

}



