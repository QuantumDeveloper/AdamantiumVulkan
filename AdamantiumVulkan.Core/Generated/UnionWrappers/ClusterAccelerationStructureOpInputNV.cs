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

public unsafe partial class ClusterAccelerationStructureOpInputNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureClustersBottomLevelInputNV> _pClustersBottomLevel;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureTriangleClusterInputNV> _pTriangleClusters;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureMoveObjectsInputNV> _pMoveObjects;

    public ClusterAccelerationStructureOpInputNV()
    {
    }

    public ClusterAccelerationStructureOpInputNV(AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureOpInputNV _internal)
    {
        PClustersBottomLevel = new ClusterAccelerationStructureClustersBottomLevelInputNV(*_internal.pClustersBottomLevel);
        NativeUtils.Free(_internal.pClustersBottomLevel);
        PTriangleClusters = new ClusterAccelerationStructureTriangleClusterInputNV(*_internal.pTriangleClusters);
        NativeUtils.Free(_internal.pTriangleClusters);
        PMoveObjects = new ClusterAccelerationStructureMoveObjectsInputNV(*_internal.pMoveObjects);
        NativeUtils.Free(_internal.pMoveObjects);
    }

    public ClusterAccelerationStructureClustersBottomLevelInputNV PClustersBottomLevel { get; set; }
    public ClusterAccelerationStructureTriangleClusterInputNV PTriangleClusters { get; set; }
    public ClusterAccelerationStructureMoveObjectsInputNV PMoveObjects { get; set; }

    public AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureOpInputNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureOpInputNV();
        _pClustersBottomLevel.Dispose();
        if (PClustersBottomLevel != default)
        {
            var struct0 = PClustersBottomLevel.ToNative();
            _pClustersBottomLevel = new NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureClustersBottomLevelInputNV>(struct0);
            _internal.pClustersBottomLevel = _pClustersBottomLevel.Handle;
        }
        _pTriangleClusters.Dispose();
        if (PTriangleClusters != default)
        {
            var struct1 = PTriangleClusters.ToNative();
            _pTriangleClusters = new NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureTriangleClusterInputNV>(struct1);
            _internal.pTriangleClusters = _pTriangleClusters.Handle;
        }
        _pMoveObjects.Dispose();
        if (PMoveObjects != default)
        {
            var struct2 = PMoveObjects.ToNative();
            _pMoveObjects = new NativeStruct<AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureMoveObjectsInputNV>(struct2);
            _internal.pMoveObjects = _pMoveObjects.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pClustersBottomLevel.Dispose();
        _pTriangleClusters.Dispose();
        _pMoveObjects.Dispose();
    }


    public static implicit operator ClusterAccelerationStructureOpInputNV(AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureOpInputNV c)
    {
        return new ClusterAccelerationStructureOpInputNV(c);
    }

}



