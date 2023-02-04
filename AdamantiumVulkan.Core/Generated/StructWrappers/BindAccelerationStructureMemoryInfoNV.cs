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

public unsafe partial class BindAccelerationStructureMemoryInfoNV : QBDisposableObject
{
    private NativeStruct<uint> _pDeviceIndices;

    public BindAccelerationStructureMemoryInfoNV()
    {
    }

    public BindAccelerationStructureMemoryInfoNV(AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV _internal)
    {
        PNext = _internal.pNext;
        AccelerationStructure = new AccelerationStructureNV(_internal.accelerationStructure);
        Memory = new DeviceMemory(_internal.memory);
        MemoryOffset = _internal.memoryOffset;
        DeviceIndexCount = _internal.deviceIndexCount;
        if (_internal.pDeviceIndices != null)
        {
            PDeviceIndices = *_internal.pDeviceIndices;
            NativeUtils.Free(_internal.pDeviceIndices);
        }
    }

    public StructureType SType => StructureType.BindAccelerationStructureMemoryInfoNv;
    public void* PNext { get; set; }
    public AccelerationStructureNV AccelerationStructure { get; set; }
    public DeviceMemory Memory { get; set; }
    public VkDeviceSize MemoryOffset { get; set; }
    public uint DeviceIndexCount { get; set; }
    public uint? PDeviceIndices { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.accelerationStructure = AccelerationStructure;
        _internal.memory = Memory;
        _internal.memoryOffset = MemoryOffset;
        _internal.deviceIndexCount = DeviceIndexCount;
        _pDeviceIndices.Dispose();
        if (PDeviceIndices.HasValue)
        {
            _pDeviceIndices = new NativeStruct<uint>(PDeviceIndices.Value);
            _internal.pDeviceIndices = _pDeviceIndices.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pDeviceIndices.Dispose();
    }


    public static implicit operator BindAccelerationStructureMemoryInfoNV(AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV b)
    {
        return new BindAccelerationStructureMemoryInfoNV(b);
    }

}



