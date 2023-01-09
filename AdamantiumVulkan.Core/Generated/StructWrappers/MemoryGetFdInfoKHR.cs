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

public unsafe partial class MemoryGetFdInfoKHR : QBDisposableObject
{
    public MemoryGetFdInfoKHR()
    {
    }

    public MemoryGetFdInfoKHR(AdamantiumVulkan.Core.Interop.VkMemoryGetFdInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Memory = new DeviceMemory(_internal.memory);
        HandleType = _internal.handleType;
    }

    public StructureType SType => StructureType.MemoryGetFdInfoKhr;
    public void* PNext { get; set; }
    public DeviceMemory Memory { get; set; }
    public ExternalMemoryHandleTypeFlagBits HandleType { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryGetFdInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryGetFdInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.memory = Memory;
        _internal.handleType = HandleType;
        return _internal;
    }

    public static implicit operator MemoryGetFdInfoKHR(AdamantiumVulkan.Core.Interop.VkMemoryGetFdInfoKHR m)
    {
        return new MemoryGetFdInfoKHR(m);
    }

}



