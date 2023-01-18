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

public unsafe partial class GraphicsShaderGroupCreateInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo> pStages;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineVertexInputStateCreateInfo> pVertexInputState;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo> pTessellationState;

    public GraphicsShaderGroupCreateInfoNV()
    {
    }

    public GraphicsShaderGroupCreateInfoNV(AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        StageCount = _internal.stageCount;
        PStages = new PipelineShaderStageCreateInfo(*_internal.pStages);
        NativeUtils.Free(_internal.pStages);
        PVertexInputState = new PipelineVertexInputStateCreateInfo(*_internal.pVertexInputState);
        NativeUtils.Free(_internal.pVertexInputState);
        PTessellationState = new PipelineTessellationStateCreateInfo(*_internal.pTessellationState);
        NativeUtils.Free(_internal.pTessellationState);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint StageCount { get; set; }
    public PipelineShaderStageCreateInfo PStages { get; set; }
    public PipelineVertexInputStateCreateInfo PVertexInputState { get; set; }
    public PipelineTessellationStateCreateInfo PTessellationState { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.stageCount = StageCount;
        pStages.Dispose();
        if (PStages != null)
        {
            var struct0 = PStages.ToNative();
            pStages = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo>(struct0);
            _internal.pStages = pStages.Handle;
        }
        pVertexInputState.Dispose();
        if (PVertexInputState != null)
        {
            var struct1 = PVertexInputState.ToNative();
            pVertexInputState = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineVertexInputStateCreateInfo>(struct1);
            _internal.pVertexInputState = pVertexInputState.Handle;
        }
        pTessellationState.Dispose();
        if (PTessellationState != null)
        {
            var struct2 = PTessellationState.ToNative();
            pTessellationState = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo>(struct2);
            _internal.pTessellationState = pTessellationState.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pStages.Dispose();
        pVertexInputState.Dispose();
        pTessellationState.Dispose();
    }


    public static implicit operator GraphicsShaderGroupCreateInfoNV(AdamantiumVulkan.Core.Interop.VkGraphicsShaderGroupCreateInfoNV g)
    {
        return new GraphicsShaderGroupCreateInfoNV(g);
    }

}



