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

public unsafe partial class QueueFamilyCheckpointPropertiesNV : QBDisposableObject
{
    public QueueFamilyCheckpointPropertiesNV()
    {
    }

    public QueueFamilyCheckpointPropertiesNV(AdamantiumVulkan.Core.Interop.VkQueueFamilyCheckpointPropertiesNV _internal)
    {
        PNext = _internal.pNext;
        CheckpointExecutionStageMask = _internal.checkpointExecutionStageMask;
    }

    public StructureType SType => StructureType.QueueFamilyCheckpointPropertiesNv;
    public void* PNext { get; set; }
    public VkPipelineStageFlags CheckpointExecutionStageMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkQueueFamilyCheckpointPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkQueueFamilyCheckpointPropertiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.checkpointExecutionStageMask = CheckpointExecutionStageMask;
        return _internal;
    }

    public static implicit operator QueueFamilyCheckpointPropertiesNV(AdamantiumVulkan.Core.Interop.VkQueueFamilyCheckpointPropertiesNV q)
    {
        return new QueueFamilyCheckpointPropertiesNV(q);
    }

}



