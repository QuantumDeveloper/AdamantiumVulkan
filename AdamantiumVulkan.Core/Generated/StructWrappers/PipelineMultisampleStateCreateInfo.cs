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

public unsafe partial class PipelineMultisampleStateCreateInfo : QBDisposableObject
{
    private NativeStruct<VkSampleMask> pSampleMask;

    public PipelineMultisampleStateCreateInfo()
    {
    }

    public PipelineMultisampleStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineMultisampleStateCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        RasterizationSamples = _internal.rasterizationSamples;
        SampleShadingEnable = _internal.sampleShadingEnable;
        MinSampleShading = _internal.minSampleShading;
        if (_internal.pSampleMask != null)
        {
            PSampleMask = *_internal.pSampleMask;
            NativeUtils.Free(_internal.pSampleMask);
        }
        AlphaToCoverageEnable = _internal.alphaToCoverageEnable;
        AlphaToOneEnable = _internal.alphaToOneEnable;
    }

    public StructureType SType => StructureType.PipelineMultisampleStateCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineMultisampleStateCreateFlags Flags { get; set; }
    public SampleCountFlagBits RasterizationSamples { get; set; }
    public VkBool32 SampleShadingEnable { get; set; }
    public float MinSampleShading { get; set; }
    public VkSampleMask? PSampleMask { get; set; }
    public VkBool32 AlphaToCoverageEnable { get; set; }
    public VkBool32 AlphaToOneEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineMultisampleStateCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineMultisampleStateCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.rasterizationSamples = RasterizationSamples;
        _internal.sampleShadingEnable = SampleShadingEnable;
        _internal.minSampleShading = MinSampleShading;
        pSampleMask.Dispose();
        if (PSampleMask.HasValue)
        {
            pSampleMask = new NativeStruct<VkSampleMask>(PSampleMask.Value);
            _internal.pSampleMask = pSampleMask.Handle;
        }
        _internal.alphaToCoverageEnable = AlphaToCoverageEnable;
        _internal.alphaToOneEnable = AlphaToOneEnable;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pSampleMask.Dispose();
    }


    public static implicit operator PipelineMultisampleStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineMultisampleStateCreateInfo p)
    {
        return new PipelineMultisampleStateCreateInfo(p);
    }

}



