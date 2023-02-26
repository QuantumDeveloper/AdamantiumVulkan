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

public unsafe partial class AccelerationStructureBuildGeometryInfoKHR : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR> _pGeometries;

    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR> _ppGeometries;

    public AccelerationStructureBuildGeometryInfoKHR()
    {
    }

    public AccelerationStructureBuildGeometryInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        Flags = _internal.flags;
        Mode = _internal.mode;
        SrcAccelerationStructure = new AccelerationStructureKHR(_internal.srcAccelerationStructure);
        DstAccelerationStructure = new AccelerationStructureKHR(_internal.dstAccelerationStructure);
        GeometryCount = _internal.geometryCount;
        PGeometries = new AccelerationStructureGeometryKHR[_internal.geometryCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pGeometries, _internal.geometryCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PGeometries[i] = new AccelerationStructureGeometryKHR(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pGeometries);
        ScratchData = new DeviceOrHostAddressKHR(_internal.scratchData);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public AccelerationStructureTypeKHR Type { get; set; }
    public BuildAccelerationStructureFlagBitsKHR Flags { get; set; }
    public BuildAccelerationStructureModeKHR Mode { get; set; }
    public AccelerationStructureKHR SrcAccelerationStructure { get; set; }
    public AccelerationStructureKHR DstAccelerationStructure { get; set; }
    public uint GeometryCount { get; set; }
    public AccelerationStructureGeometryKHR[] PGeometries { get; set; }
    public DeviceOrHostAddressKHR ScratchData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.type = Type;
        _internal.flags = Flags;
        _internal.mode = Mode;
        _internal.srcAccelerationStructure = SrcAccelerationStructure;
        _internal.dstAccelerationStructure = DstAccelerationStructure;
        _internal.geometryCount = GeometryCount;
        _pGeometries.Dispose();
        if (PGeometries != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR[PGeometries.Length];
            for (int i = 0; i < PGeometries.Length; ++i)
            {
                tmpArray0[i] = PGeometries[i].ToNative();
            }
            _pGeometries = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR>(tmpArray0);
            _internal.pGeometries = _pGeometries.Handle;
        }
        if (ScratchData != null)
        {
            _internal.scratchData = ScratchData.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pGeometries.Dispose();
        _ppGeometries.Dispose();
    }


    public static implicit operator AccelerationStructureBuildGeometryInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR a)
    {
        return new AccelerationStructureBuildGeometryInfoKHR(a);
    }

}



