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

public unsafe partial class DependencyInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkMemoryBarrier2> _pMemoryBarriers;

    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier2> _pBufferMemoryBarriers;

    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier2> _pImageMemoryBarriers;

    public DependencyInfo()
    {
    }

    public DependencyInfo(AdamantiumVulkan.Core.Interop.VkDependencyInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DependencyFlags = _internal.dependencyFlags;
        MemoryBarrierCount = _internal.memoryBarrierCount;
        BufferMemoryBarrierCount = _internal.bufferMemoryBarrierCount;
        ImageMemoryBarrierCount = _internal.imageMemoryBarrierCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public DependencyFlagBits DependencyFlags { get; set; }
    public uint MemoryBarrierCount { get; set; }
    public MemoryBarrier2[] PMemoryBarriers { get; set; }
    public uint BufferMemoryBarrierCount { get; set; }
    public BufferMemoryBarrier2[] PBufferMemoryBarriers { get; set; }
    public uint ImageMemoryBarrierCount { get; set; }
    public ImageMemoryBarrier2[] PImageMemoryBarriers { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDependencyInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDependencyInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DependencyFlags != default)
        {
            _internal.dependencyFlags = DependencyFlags;
        }
        if (MemoryBarrierCount != default)
        {
            _internal.memoryBarrierCount = MemoryBarrierCount;
        }
        _pMemoryBarriers.Dispose();
        if (PMemoryBarriers != default)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkMemoryBarrier2[PMemoryBarriers.Length];
            for (int i = 0; i < PMemoryBarriers.Length; ++i)
            {
                tmpArray0[i] = PMemoryBarriers[i].ToNative();
            }
            _pMemoryBarriers = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkMemoryBarrier2>(tmpArray0);
            _internal.pMemoryBarriers = _pMemoryBarriers.Handle;
        }
        if (BufferMemoryBarrierCount != default)
        {
            _internal.bufferMemoryBarrierCount = BufferMemoryBarrierCount;
        }
        _pBufferMemoryBarriers.Dispose();
        if (PBufferMemoryBarriers != default)
        {
            var tmpArray1 = new AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier2[PBufferMemoryBarriers.Length];
            for (int i = 0; i < PBufferMemoryBarriers.Length; ++i)
            {
                tmpArray1[i] = PBufferMemoryBarriers[i].ToNative();
            }
            _pBufferMemoryBarriers = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier2>(tmpArray1);
            _internal.pBufferMemoryBarriers = _pBufferMemoryBarriers.Handle;
        }
        if (ImageMemoryBarrierCount != default)
        {
            _internal.imageMemoryBarrierCount = ImageMemoryBarrierCount;
        }
        _pImageMemoryBarriers.Dispose();
        if (PImageMemoryBarriers != default)
        {
            var tmpArray2 = new AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier2[PImageMemoryBarriers.Length];
            for (int i = 0; i < PImageMemoryBarriers.Length; ++i)
            {
                tmpArray2[i] = PImageMemoryBarriers[i].ToNative();
            }
            _pImageMemoryBarriers = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier2>(tmpArray2);
            _internal.pImageMemoryBarriers = _pImageMemoryBarriers.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pMemoryBarriers.Dispose();
        _pBufferMemoryBarriers.Dispose();
        _pImageMemoryBarriers.Dispose();
    }


    public static implicit operator DependencyInfo(AdamantiumVulkan.Core.Interop.VkDependencyInfo d)
    {
        return new DependencyInfo(d);
    }

}



