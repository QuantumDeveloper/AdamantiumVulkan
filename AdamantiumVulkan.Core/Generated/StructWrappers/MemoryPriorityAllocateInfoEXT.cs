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

public unsafe partial class MemoryPriorityAllocateInfoEXT : QBDisposableObject
{
    public MemoryPriorityAllocateInfoEXT()
    {
    }

    public MemoryPriorityAllocateInfoEXT(AdamantiumVulkan.Core.Interop.VkMemoryPriorityAllocateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        Priority = _internal.priority;
    }

    public StructureType SType => StructureType.MemoryPriorityAllocateInfoExt;
    public void* PNext { get; set; }
    public float Priority { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryPriorityAllocateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryPriorityAllocateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.priority = Priority;
        return _internal;
    }

    public static implicit operator MemoryPriorityAllocateInfoEXT(AdamantiumVulkan.Core.Interop.VkMemoryPriorityAllocateInfoEXT m)
    {
        return new MemoryPriorityAllocateInfoEXT(m);
    }

}



