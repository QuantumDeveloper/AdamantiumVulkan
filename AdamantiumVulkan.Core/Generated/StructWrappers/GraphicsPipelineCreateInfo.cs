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

public unsafe partial class GraphicsPipelineCreateInfo : QBDisposableObject
{
    private NativeStructArray<VkPipelineShaderStageCreateInfo> pStages;

    private NativeStruct<VkPipelineVertexInputStateCreateInfo> pVertexInputState;

    private NativeStruct<VkPipelineInputAssemblyStateCreateInfo> pInputAssemblyState;

    private NativeStruct<VkPipelineTessellationStateCreateInfo> pTessellationState;

    private NativeStruct<VkPipelineViewportStateCreateInfo> pViewportState;

    private NativeStruct<VkPipelineRasterizationStateCreateInfo> pRasterizationState;

    private NativeStruct<VkPipelineMultisampleStateCreateInfo> pMultisampleState;

    private NativeStruct<VkPipelineDepthStencilStateCreateInfo> pDepthStencilState;

    private NativeStruct<VkPipelineColorBlendStateCreateInfo> pColorBlendState;

    private NativeStruct<VkPipelineDynamicStateCreateInfo> pDynamicState;

    public GraphicsPipelineCreateInfo()
    {
    }

    public GraphicsPipelineCreateInfo(AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        StageCount = _internal.stageCount;
        PStages = new PipelineShaderStageCreateInfo[_internal.stageCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pStages, _internal.stageCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PStages[i] = new PipelineShaderStageCreateInfo(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pStages);
        PVertexInputState = new PipelineVertexInputStateCreateInfo(*_internal.pVertexInputState);
        NativeUtils.Free(_internal.pVertexInputState);
        PInputAssemblyState = new PipelineInputAssemblyStateCreateInfo(*_internal.pInputAssemblyState);
        NativeUtils.Free(_internal.pInputAssemblyState);
        PTessellationState = new PipelineTessellationStateCreateInfo(*_internal.pTessellationState);
        NativeUtils.Free(_internal.pTessellationState);
        PViewportState = new PipelineViewportStateCreateInfo(*_internal.pViewportState);
        NativeUtils.Free(_internal.pViewportState);
        PRasterizationState = new PipelineRasterizationStateCreateInfo(*_internal.pRasterizationState);
        NativeUtils.Free(_internal.pRasterizationState);
        PMultisampleState = new PipelineMultisampleStateCreateInfo(*_internal.pMultisampleState);
        NativeUtils.Free(_internal.pMultisampleState);
        PDepthStencilState = new PipelineDepthStencilStateCreateInfo(*_internal.pDepthStencilState);
        NativeUtils.Free(_internal.pDepthStencilState);
        PColorBlendState = new PipelineColorBlendStateCreateInfo(*_internal.pColorBlendState);
        NativeUtils.Free(_internal.pColorBlendState);
        PDynamicState = new PipelineDynamicStateCreateInfo(*_internal.pDynamicState);
        NativeUtils.Free(_internal.pDynamicState);
        Layout = new PipelineLayout(_internal.layout);
        RenderPass = new RenderPass(_internal.renderPass);
        Subpass = _internal.subpass;
        BasePipelineHandle = new Pipeline(_internal.basePipelineHandle);
        BasePipelineIndex = _internal.basePipelineIndex;
    }

    public StructureType SType => StructureType.GraphicsPipelineCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineCreateFlags Flags { get; set; }
    public uint StageCount { get; set; }
    public PipelineShaderStageCreateInfo[] PStages { get; set; }
    public PipelineVertexInputStateCreateInfo PVertexInputState { get; set; }
    public PipelineInputAssemblyStateCreateInfo PInputAssemblyState { get; set; }
    public PipelineTessellationStateCreateInfo PTessellationState { get; set; }
    public PipelineViewportStateCreateInfo PViewportState { get; set; }
    public PipelineRasterizationStateCreateInfo PRasterizationState { get; set; }
    public PipelineMultisampleStateCreateInfo PMultisampleState { get; set; }
    public PipelineDepthStencilStateCreateInfo PDepthStencilState { get; set; }
    public PipelineColorBlendStateCreateInfo PColorBlendState { get; set; }
    public PipelineDynamicStateCreateInfo PDynamicState { get; set; }
    public PipelineLayout Layout { get; set; }
    public RenderPass RenderPass { get; set; }
    public uint Subpass { get; set; }
    public Pipeline BasePipelineHandle { get; set; }
    public int BasePipelineIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.stageCount = StageCount;
        pStages.Dispose();
        if (PStages != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkPipelineShaderStageCreateInfo[PStages.Length];
            for (int i = 0; i < PStages.Length; ++i)
            {
                tmpArray0[i] = PStages[i].ToNative();
            }
            pStages = new NativeStructArray<VkPipelineShaderStageCreateInfo>(tmpArray0);
            _internal.pStages = pStages.Handle;
        }
        pVertexInputState.Dispose();
        if (PVertexInputState != null)
        {
            var struct0 = PVertexInputState.ToNative();
            pVertexInputState = new NativeStruct<VkPipelineVertexInputStateCreateInfo>(struct0);
            _internal.pVertexInputState = pVertexInputState.Handle;
        }
        pInputAssemblyState.Dispose();
        if (PInputAssemblyState != null)
        {
            var struct1 = PInputAssemblyState.ToNative();
            pInputAssemblyState = new NativeStruct<VkPipelineInputAssemblyStateCreateInfo>(struct1);
            _internal.pInputAssemblyState = pInputAssemblyState.Handle;
        }
        pTessellationState.Dispose();
        if (PTessellationState != null)
        {
            var struct2 = PTessellationState.ToNative();
            pTessellationState = new NativeStruct<VkPipelineTessellationStateCreateInfo>(struct2);
            _internal.pTessellationState = pTessellationState.Handle;
        }
        pViewportState.Dispose();
        if (PViewportState != null)
        {
            var struct3 = PViewportState.ToNative();
            pViewportState = new NativeStruct<VkPipelineViewportStateCreateInfo>(struct3);
            _internal.pViewportState = pViewportState.Handle;
        }
        pRasterizationState.Dispose();
        if (PRasterizationState != null)
        {
            var struct4 = PRasterizationState.ToNative();
            pRasterizationState = new NativeStruct<VkPipelineRasterizationStateCreateInfo>(struct4);
            _internal.pRasterizationState = pRasterizationState.Handle;
        }
        pMultisampleState.Dispose();
        if (PMultisampleState != null)
        {
            var struct5 = PMultisampleState.ToNative();
            pMultisampleState = new NativeStruct<VkPipelineMultisampleStateCreateInfo>(struct5);
            _internal.pMultisampleState = pMultisampleState.Handle;
        }
        pDepthStencilState.Dispose();
        if (PDepthStencilState != null)
        {
            var struct6 = PDepthStencilState.ToNative();
            pDepthStencilState = new NativeStruct<VkPipelineDepthStencilStateCreateInfo>(struct6);
            _internal.pDepthStencilState = pDepthStencilState.Handle;
        }
        pColorBlendState.Dispose();
        if (PColorBlendState != null)
        {
            var struct7 = PColorBlendState.ToNative();
            pColorBlendState = new NativeStruct<VkPipelineColorBlendStateCreateInfo>(struct7);
            _internal.pColorBlendState = pColorBlendState.Handle;
        }
        pDynamicState.Dispose();
        if (PDynamicState != null)
        {
            var struct8 = PDynamicState.ToNative();
            pDynamicState = new NativeStruct<VkPipelineDynamicStateCreateInfo>(struct8);
            _internal.pDynamicState = pDynamicState.Handle;
        }
        _internal.layout = Layout;
        _internal.renderPass = RenderPass;
        _internal.subpass = Subpass;
        _internal.basePipelineHandle = BasePipelineHandle;
        _internal.basePipelineIndex = BasePipelineIndex;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pStages.Dispose();
        pVertexInputState.Dispose();
        pInputAssemblyState.Dispose();
        pTessellationState.Dispose();
        pViewportState.Dispose();
        pRasterizationState.Dispose();
        pMultisampleState.Dispose();
        pDepthStencilState.Dispose();
        pColorBlendState.Dispose();
        pDynamicState.Dispose();
    }


    public static implicit operator GraphicsPipelineCreateInfo(AdamantiumVulkan.Core.Interop.VkGraphicsPipelineCreateInfo g)
    {
        return new GraphicsPipelineCreateInfo(g);
    }

}


