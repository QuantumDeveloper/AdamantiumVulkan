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

public unsafe partial class GeneratedCommandsInfoNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV> pStreams;

    public GeneratedCommandsInfoNV()
    {
    }

    public GeneratedCommandsInfoNV(AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineBindPoint = _internal.pipelineBindPoint;
        Pipeline = new Pipeline(_internal.pipeline);
        IndirectCommandsLayout = new IndirectCommandsLayoutNV(_internal.indirectCommandsLayout);
        StreamCount = _internal.streamCount;
        PStreams = new IndirectCommandsStreamNV(*_internal.pStreams);
        NativeUtils.Free(_internal.pStreams);
        SequencesCount = _internal.sequencesCount;
        PreprocessBuffer = new Buffer(_internal.preprocessBuffer);
        PreprocessOffset = _internal.preprocessOffset;
        PreprocessSize = _internal.preprocessSize;
        SequencesCountBuffer = new Buffer(_internal.sequencesCountBuffer);
        SequencesCountOffset = _internal.sequencesCountOffset;
        SequencesIndexBuffer = new Buffer(_internal.sequencesIndexBuffer);
        SequencesIndexOffset = _internal.sequencesIndexOffset;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PipelineBindPoint PipelineBindPoint { get; set; }
    public Pipeline Pipeline { get; set; }
    public IndirectCommandsLayoutNV IndirectCommandsLayout { get; set; }
    public uint StreamCount { get; set; }
    public IndirectCommandsStreamNV PStreams { get; set; }
    public uint SequencesCount { get; set; }
    public Buffer PreprocessBuffer { get; set; }
    public VkDeviceSize PreprocessOffset { get; set; }
    public VkDeviceSize PreprocessSize { get; set; }
    public Buffer SequencesCountBuffer { get; set; }
    public VkDeviceSize SequencesCountOffset { get; set; }
    public Buffer SequencesIndexBuffer { get; set; }
    public VkDeviceSize SequencesIndexOffset { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.pipelineBindPoint = PipelineBindPoint;
        _internal.pipeline = Pipeline;
        _internal.indirectCommandsLayout = IndirectCommandsLayout;
        _internal.streamCount = StreamCount;
        pStreams.Dispose();
        if (PStreams != null)
        {
            var struct0 = PStreams.ToNative();
            pStreams = new NativeStruct<AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV>(struct0);
            _internal.pStreams = pStreams.Handle;
        }
        _internal.sequencesCount = SequencesCount;
        _internal.preprocessBuffer = PreprocessBuffer;
        _internal.preprocessOffset = PreprocessOffset;
        _internal.preprocessSize = PreprocessSize;
        _internal.sequencesCountBuffer = SequencesCountBuffer;
        _internal.sequencesCountOffset = SequencesCountOffset;
        _internal.sequencesIndexBuffer = SequencesIndexBuffer;
        _internal.sequencesIndexOffset = SequencesIndexOffset;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pStreams.Dispose();
    }


    public static implicit operator GeneratedCommandsInfoNV(AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoNV g)
    {
        return new GeneratedCommandsInfoNV(g);
    }

}



