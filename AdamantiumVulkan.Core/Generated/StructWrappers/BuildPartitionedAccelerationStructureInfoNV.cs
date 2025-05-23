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

public unsafe partial class BuildPartitionedAccelerationStructureInfoNV : QBDisposableObject
{
    public BuildPartitionedAccelerationStructureInfoNV()
    {
    }

    public BuildPartitionedAccelerationStructureInfoNV(AdamantiumVulkan.Core.Interop.VkBuildPartitionedAccelerationStructureInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Input = new PartitionedAccelerationStructureInstancesInputNV(_internal.input);
        SrcAccelerationStructureData = _internal.srcAccelerationStructureData;
        DstAccelerationStructureData = _internal.dstAccelerationStructureData;
        ScratchData = _internal.scratchData;
        SrcInfos = _internal.srcInfos;
        SrcInfosCount = _internal.srcInfosCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PartitionedAccelerationStructureInstancesInputNV Input { get; set; }
    public VkDeviceAddress SrcAccelerationStructureData { get; set; }
    public VkDeviceAddress DstAccelerationStructureData { get; set; }
    public VkDeviceAddress ScratchData { get; set; }
    public VkDeviceAddress SrcInfos { get; set; }
    public VkDeviceAddress SrcInfosCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBuildPartitionedAccelerationStructureInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBuildPartitionedAccelerationStructureInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Input != default)
        {
            _internal.input = Input.ToNative();
        }
        if (SrcAccelerationStructureData != (ulong)default)
        {
            _internal.srcAccelerationStructureData = SrcAccelerationStructureData;
        }
        if (DstAccelerationStructureData != (ulong)default)
        {
            _internal.dstAccelerationStructureData = DstAccelerationStructureData;
        }
        if (ScratchData != (ulong)default)
        {
            _internal.scratchData = ScratchData;
        }
        if (SrcInfos != (ulong)default)
        {
            _internal.srcInfos = SrcInfos;
        }
        if (SrcInfosCount != (ulong)default)
        {
            _internal.srcInfosCount = SrcInfosCount;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Input?.Dispose();
    }


    public static implicit operator BuildPartitionedAccelerationStructureInfoNV(AdamantiumVulkan.Core.Interop.VkBuildPartitionedAccelerationStructureInfoNV b)
    {
        return new BuildPartitionedAccelerationStructureInfoNV(b);
    }

}



