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

public unsafe partial class MemoryBarrier : QBDisposableObject
{
    public MemoryBarrier()
    {
    }

    public MemoryBarrier(AdamantiumVulkan.Core.Interop.VkMemoryBarrier _internal)
    {
        PNext = _internal.pNext;
        SrcAccessMask = _internal.srcAccessMask;
        DstAccessMask = _internal.dstAccessMask;
    }

    public StructureType SType => StructureType.MemoryBarrier;
    public void* PNext { get; set; }
    public VkAccessFlags SrcAccessMask { get; set; }
    public VkAccessFlags DstAccessMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryBarrier ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryBarrier();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SrcAccessMask != (uint)default)
        {
            _internal.srcAccessMask = SrcAccessMask;
        }
        if (DstAccessMask != (uint)default)
        {
            _internal.dstAccessMask = DstAccessMask;
        }
        return _internal;
    }

    public static implicit operator MemoryBarrier(AdamantiumVulkan.Core.Interop.VkMemoryBarrier m)
    {
        return new MemoryBarrier(m);
    }

}



