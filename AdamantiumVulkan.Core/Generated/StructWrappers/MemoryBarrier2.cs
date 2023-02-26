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

public unsafe partial class MemoryBarrier2 : QBDisposableObject
{
    public MemoryBarrier2()
    {
    }

    public MemoryBarrier2(AdamantiumVulkan.Core.Interop.VkMemoryBarrier2 _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SrcStageMask = _internal.srcStageMask;
        SrcAccessMask = _internal.srcAccessMask;
        DstStageMask = _internal.dstStageMask;
        DstAccessMask = _internal.dstAccessMask;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPipelineStageFlags2 SrcStageMask { get; set; }
    public VkAccessFlags2 SrcAccessMask { get; set; }
    public VkPipelineStageFlags2 DstStageMask { get; set; }
    public VkAccessFlags2 DstAccessMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMemoryBarrier2 ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMemoryBarrier2();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.srcStageMask = SrcStageMask;
        _internal.srcAccessMask = SrcAccessMask;
        _internal.dstStageMask = DstStageMask;
        _internal.dstAccessMask = DstAccessMask;
        return _internal;
    }

    public static implicit operator MemoryBarrier2(AdamantiumVulkan.Core.Interop.VkMemoryBarrier2 m)
    {
        return new MemoryBarrier2(m);
    }

}



