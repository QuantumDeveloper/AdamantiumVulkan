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

public unsafe partial class CheckpointData2NV : QBDisposableObject
{
    public CheckpointData2NV()
    {
    }

    public CheckpointData2NV(AdamantiumVulkan.Core.Interop.VkCheckpointData2NV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Stage = _internal.stage;
        PCheckpointMarker = _internal.pCheckpointMarker;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPipelineStageFlags2 Stage { get; set; }
    public void* PCheckpointMarker { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCheckpointData2NV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCheckpointData2NV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Stage != (ulong)default)
        {
            _internal.stage = Stage;
        }
        _internal.pCheckpointMarker = PCheckpointMarker;
        return _internal;
    }

    public static implicit operator CheckpointData2NV(AdamantiumVulkan.Core.Interop.VkCheckpointData2NV c)
    {
        return new CheckpointData2NV(c);
    }

}



