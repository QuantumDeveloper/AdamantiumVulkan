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

public unsafe partial class BufferMemoryBarrier : QBDisposableObject
{
    public BufferMemoryBarrier()
    {
    }

    public BufferMemoryBarrier(AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier _internal)
    {
        PNext = _internal.pNext;
        SrcAccessMask = _internal.srcAccessMask;
        DstAccessMask = _internal.dstAccessMask;
        SrcQueueFamilyIndex = _internal.srcQueueFamilyIndex;
        DstQueueFamilyIndex = _internal.dstQueueFamilyIndex;
        Buffer = new Buffer(_internal.buffer);
        Offset = _internal.offset;
        Size = _internal.size;
    }

    public StructureType SType => StructureType.BufferMemoryBarrier;
    public void* PNext { get; set; }
    public VkAccessFlags SrcAccessMask { get; set; }
    public VkAccessFlags DstAccessMask { get; set; }
    public uint SrcQueueFamilyIndex { get; set; }
    public uint DstQueueFamilyIndex { get; set; }
    public Buffer Buffer { get; set; }
    public VkDeviceSize Offset { get; set; }
    public VkDeviceSize Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.srcAccessMask = SrcAccessMask;
        _internal.dstAccessMask = DstAccessMask;
        _internal.srcQueueFamilyIndex = SrcQueueFamilyIndex;
        _internal.dstQueueFamilyIndex = DstQueueFamilyIndex;
        _internal.buffer = Buffer;
        _internal.offset = Offset;
        _internal.size = Size;
        return _internal;
    }

    public static implicit operator BufferMemoryBarrier(AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier b)
    {
        return new BufferMemoryBarrier(b);
    }

}



