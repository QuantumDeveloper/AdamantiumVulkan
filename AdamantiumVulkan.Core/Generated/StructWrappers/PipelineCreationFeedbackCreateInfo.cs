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

public unsafe partial class PipelineCreationFeedbackCreateInfo : QBDisposableObject
{
    private NativeStruct<VkPipelineCreationFeedback> pPipelineCreationFeedback;

    private NativeStruct<VkPipelineCreationFeedback> pPipelineStageCreationFeedbacks;

    public PipelineCreationFeedbackCreateInfo()
    {
    }

    public PipelineCreationFeedbackCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineCreationFeedbackCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineCreationFeedback = new PipelineCreationFeedback(*_internal.pPipelineCreationFeedback);
        NativeUtils.Free(_internal.pPipelineCreationFeedback);
        PipelineStageCreationFeedbackCount = _internal.pipelineStageCreationFeedbackCount;
        PipelineStageCreationFeedbacks = new PipelineCreationFeedback(*_internal.pPipelineStageCreationFeedbacks);
        NativeUtils.Free(_internal.pPipelineStageCreationFeedbacks);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PipelineCreationFeedback PipelineCreationFeedback { get; set; }
    public uint PipelineStageCreationFeedbackCount { get; set; }
    public PipelineCreationFeedback PipelineStageCreationFeedbacks { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineCreationFeedbackCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineCreationFeedbackCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        pPipelineCreationFeedback.Dispose();
        if (PipelineCreationFeedback != null)
        {
            var struct0 = PipelineCreationFeedback.ToNative();
            pPipelineCreationFeedback = new NativeStruct<VkPipelineCreationFeedback>(struct0);
            _internal.pPipelineCreationFeedback = pPipelineCreationFeedback.Handle;
        }
        _internal.pipelineStageCreationFeedbackCount = PipelineStageCreationFeedbackCount;
        pPipelineStageCreationFeedbacks.Dispose();
        if (PipelineStageCreationFeedbacks != null)
        {
            var struct1 = PipelineStageCreationFeedbacks.ToNative();
            pPipelineStageCreationFeedbacks = new NativeStruct<VkPipelineCreationFeedback>(struct1);
            _internal.pPipelineStageCreationFeedbacks = pPipelineStageCreationFeedbacks.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pPipelineCreationFeedback.Dispose();
        pPipelineStageCreationFeedbacks.Dispose();
    }


    public static implicit operator PipelineCreationFeedbackCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineCreationFeedbackCreateInfo p)
    {
        return new PipelineCreationFeedbackCreateInfo(p);
    }

}


