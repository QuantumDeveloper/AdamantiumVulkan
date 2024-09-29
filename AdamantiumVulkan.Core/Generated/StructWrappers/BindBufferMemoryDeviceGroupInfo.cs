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

public unsafe partial class BindBufferMemoryDeviceGroupInfo : QBDisposableObject
{
    private NativeStruct<uint> _pDeviceIndices;

    public BindBufferMemoryDeviceGroupInfo()
    {
    }

    public BindBufferMemoryDeviceGroupInfo(AdamantiumVulkan.Core.Interop.VkBindBufferMemoryDeviceGroupInfo _internal)
    {
        PNext = _internal.pNext;
        DeviceIndexCount = _internal.deviceIndexCount;
        if (_internal.pDeviceIndices != null)
        {
            PDeviceIndices = *_internal.pDeviceIndices;
            NativeUtils.Free(_internal.pDeviceIndices);
        }
    }

    public StructureType SType => StructureType.BindBufferMemoryDeviceGroupInfo;
    public void* PNext { get; set; }
    public uint DeviceIndexCount { get; set; }
    public uint? PDeviceIndices { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBindBufferMemoryDeviceGroupInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBindBufferMemoryDeviceGroupInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DeviceIndexCount != default)
        {
            _internal.deviceIndexCount = DeviceIndexCount;
        }
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


    public static implicit operator BindBufferMemoryDeviceGroupInfo(AdamantiumVulkan.Core.Interop.VkBindBufferMemoryDeviceGroupInfo b)
    {
        return new BindBufferMemoryDeviceGroupInfo(b);
    }

}



