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

public unsafe partial class MemoryHostPointerPropertiesEXT : QBDisposableObject
{
    public MemoryHostPointerPropertiesEXT()
    {
    }

    public MemoryHostPointerPropertiesEXT(AdamantiumVulkan.Core.Interop.VkMemoryHostPointerPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        MemoryTypeBits = _internal.memoryTypeBits;
    }

    public StructureType SType => StructureType.MemoryHostPointerPropertiesExt;
    public void* PNext { get; set; }
    public uint MemoryTypeBits { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryHostPointerPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryHostPointerPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.memoryTypeBits = MemoryTypeBits;
        return _internal;
    }

    public static implicit operator MemoryHostPointerPropertiesEXT(AdamantiumVulkan.Core.Interop.VkMemoryHostPointerPropertiesEXT m)
    {
        return new MemoryHostPointerPropertiesEXT(m);
    }

}



