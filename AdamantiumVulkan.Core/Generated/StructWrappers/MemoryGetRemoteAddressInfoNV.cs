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

public unsafe partial class MemoryGetRemoteAddressInfoNV : QBDisposableObject
{
    public MemoryGetRemoteAddressInfoNV()
    {
    }

    public MemoryGetRemoteAddressInfoNV(AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Memory = new DeviceMemory(_internal.memory);
        HandleType = _internal.handleType;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public DeviceMemory Memory { get; set; }
    public ExternalMemoryHandleTypeFlagBits HandleType { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.memory = Memory;
        _internal.handleType = HandleType;
        return _internal;
    }

    public static implicit operator MemoryGetRemoteAddressInfoNV(AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV m)
    {
        return new MemoryGetRemoteAddressInfoNV(m);
    }

}


