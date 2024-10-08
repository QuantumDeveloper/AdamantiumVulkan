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

public unsafe partial class BufferCopy : QBDisposableObject
{
    public BufferCopy()
    {
    }

    public BufferCopy(AdamantiumVulkan.Core.Interop.VkBufferCopy _internal)
    {
        SrcOffset = _internal.srcOffset;
        DstOffset = _internal.dstOffset;
        Size = _internal.size;
    }

    public VkDeviceSize SrcOffset { get; set; }
    public VkDeviceSize DstOffset { get; set; }
    public VkDeviceSize Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBufferCopy ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBufferCopy();
        if (SrcOffset != (ulong)default)
        {
            _internal.srcOffset = SrcOffset;
        }
        if (DstOffset != (ulong)default)
        {
            _internal.dstOffset = DstOffset;
        }
        if (Size != (ulong)default)
        {
            _internal.size = Size;
        }
        return _internal;
    }

    public static implicit operator BufferCopy(AdamantiumVulkan.Core.Interop.VkBufferCopy b)
    {
        return new BufferCopy(b);
    }

}



