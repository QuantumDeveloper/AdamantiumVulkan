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

public unsafe partial class AccelerationStructureCreateInfoKHR : QBDisposableObject
{
    public AccelerationStructureCreateInfoKHR()
    {
    }

    public AccelerationStructureCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CreateFlags = _internal.createFlags;
        Buffer = new Buffer(_internal.buffer);
        Offset = _internal.offset;
        Size = _internal.size;
        Type = _internal.type;
        DeviceAddress = _internal.deviceAddress;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkAccelerationStructureCreateFlagsKHR CreateFlags { get; set; }
    public Buffer Buffer { get; set; }
    public VkDeviceSize Offset { get; set; }
    public VkDeviceSize Size { get; set; }
    public AccelerationStructureTypeKHR Type { get; set; }
    public VkDeviceAddress DeviceAddress { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (CreateFlags != (uint)default)
        {
            _internal.createFlags = CreateFlags;
        }
        if (Buffer != default)
        {
            _internal.buffer = Buffer;
        }
        if (Offset != (ulong)default)
        {
            _internal.offset = Offset;
        }
        if (Size != (ulong)default)
        {
            _internal.size = Size;
        }
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (DeviceAddress != (ulong)default)
        {
            _internal.deviceAddress = DeviceAddress;
        }
        return _internal;
    }

    public static implicit operator AccelerationStructureCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureCreateInfoKHR a)
    {
        return new AccelerationStructureCreateInfoKHR(a);
    }

}



