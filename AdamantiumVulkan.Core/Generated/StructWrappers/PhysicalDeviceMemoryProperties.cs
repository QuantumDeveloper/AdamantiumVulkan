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

public unsafe partial class PhysicalDeviceMemoryProperties
{
    public PhysicalDeviceMemoryProperties()
    {
    }

    public PhysicalDeviceMemoryProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryProperties _internal)
    {
        MemoryTypeCount = _internal.memoryTypeCount;
        MemoryTypes = new MemoryType[32];
        for (int i = 0; i < 32; ++i)
        {
            MemoryTypes[i] = new MemoryType(_internal.memoryTypes[i]);
        }
        MemoryHeapCount = _internal.memoryHeapCount;
        MemoryHeaps = new MemoryHeap[16];
        for (int i = 0; i < 16; ++i)
        {
            MemoryHeaps[i] = new MemoryHeap(_internal.memoryHeaps[i]);
        }
    }

    public uint MemoryTypeCount { get; set; }
    public MemoryType[] MemoryTypes { get; set; }
    public uint MemoryHeapCount { get; set; }
    public MemoryHeap[] MemoryHeaps { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryProperties();
        _internal.memoryTypeCount = MemoryTypeCount;
        if(MemoryTypes != null)
        {
            if (MemoryTypes.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(MemoryTypes), "Array is out of bounds. Size should not be more than 32");

            for (int i = 0; i < MemoryTypes.Length; ++i)
            {
                _internal.memoryTypes[i] = MemoryTypes[i].ToNative();
            }
        }
        _internal.memoryHeapCount = MemoryHeapCount;
        if(MemoryHeaps != null)
        {
            if (MemoryHeaps.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(MemoryHeaps), "Array is out of bounds. Size should not be more than 16");

            for (int i = 0; i < MemoryHeaps.Length; ++i)
            {
                _internal.memoryHeaps[i] = MemoryHeaps[i].ToNative();
            }
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMemoryProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryProperties p)
    {
        return new PhysicalDeviceMemoryProperties(p);
    }

}



