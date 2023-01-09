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

public unsafe partial class AccelerationStructureInfoNV : QBDisposableObject
{
    private NativeStruct<VkGeometryNV> pGeometries;

    public AccelerationStructureInfoNV()
    {
    }

    public AccelerationStructureInfoNV(AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV _internal)
    {
        PNext = _internal.pNext;
        Type = _internal.type;
        Flags = _internal.flags;
        InstanceCount = _internal.instanceCount;
        GeometryCount = _internal.geometryCount;
        PGeometries = new GeometryNV(*_internal.pGeometries);
        NativeUtils.Free(_internal.pGeometries);
    }

    public StructureType SType => StructureType.AccelerationStructureInfoNv;
    public void* PNext { get; set; }
    public AccelerationStructureTypeKHR Type { get; set; }
    public BuildAccelerationStructureFlagBitsKHR Flags { get; set; }
    public uint InstanceCount { get; set; }
    public uint GeometryCount { get; set; }
    public GeometryNV PGeometries { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.type = Type;
        _internal.flags = Flags;
        _internal.instanceCount = InstanceCount;
        _internal.geometryCount = GeometryCount;
        pGeometries.Dispose();
        if (PGeometries != null)
        {
            var struct0 = PGeometries.ToNative();
            pGeometries = new NativeStruct<VkGeometryNV>(struct0);
            _internal.pGeometries = pGeometries.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pGeometries.Dispose();
    }


    public static implicit operator AccelerationStructureInfoNV(AdamantiumVulkan.Core.Interop.VkAccelerationStructureInfoNV a)
    {
        return new AccelerationStructureInfoNV(a);
    }

}


