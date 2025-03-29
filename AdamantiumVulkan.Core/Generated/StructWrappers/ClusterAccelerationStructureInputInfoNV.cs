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

public unsafe partial class ClusterAccelerationStructureInputInfoNV : QBDisposableObject
{
    public ClusterAccelerationStructureInputInfoNV()
    {
    }

    public ClusterAccelerationStructureInputInfoNV(AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxAccelerationStructureCount = _internal.maxAccelerationStructureCount;
        Flags = _internal.flags;
        OpType = _internal.opType;
        OpMode = _internal.opMode;
        OpInput = new ClusterAccelerationStructureOpInputNV(_internal.opInput);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxAccelerationStructureCount { get; set; }
    public VkBuildAccelerationStructureFlagsKHR Flags { get; set; }
    public ClusterAccelerationStructureOpTypeNV OpType { get; set; }
    public ClusterAccelerationStructureOpModeNV OpMode { get; set; }
    public ClusterAccelerationStructureOpInputNV OpInput { get; set; }

    public AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxAccelerationStructureCount != default)
        {
            _internal.maxAccelerationStructureCount = MaxAccelerationStructureCount;
        }
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (OpType != default)
        {
            _internal.opType = OpType;
        }
        if (OpMode != default)
        {
            _internal.opMode = OpMode;
        }
        if (OpInput != default)
        {
            _internal.opInput = OpInput.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        OpInput?.Dispose();
    }


    public static implicit operator ClusterAccelerationStructureInputInfoNV(AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV c)
    {
        return new ClusterAccelerationStructureInputInfoNV(c);
    }

}



