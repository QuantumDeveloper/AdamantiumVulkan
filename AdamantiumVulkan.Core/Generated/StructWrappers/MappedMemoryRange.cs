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

public unsafe partial class MappedMemoryRange : QBDisposableObject
{
    public MappedMemoryRange()
    {
    }

    public MappedMemoryRange(AdamantiumVulkan.Core.Interop.VkMappedMemoryRange _internal)
    {
        PNext = _internal.pNext;
        Memory = new DeviceMemory(_internal.memory);
        Offset = _internal.offset;
        Size = _internal.size;
    }

    public StructureType SType => StructureType.MappedMemoryRange;
    public void* PNext { get; set; }
    public DeviceMemory Memory { get; set; }
    public VkDeviceSize Offset { get; set; }
    public VkDeviceSize Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMappedMemoryRange ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMappedMemoryRange();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.memory = Memory;
        _internal.offset = Offset;
        _internal.size = Size;
        return _internal;
    }

    public static implicit operator MappedMemoryRange(AdamantiumVulkan.Core.Interop.VkMappedMemoryRange m)
    {
        return new MappedMemoryRange(m);
    }

}


