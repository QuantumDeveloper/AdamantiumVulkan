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

public unsafe partial class SparseImageMemoryBind : QBDisposableObject
{
    public SparseImageMemoryBind()
    {
    }

    public SparseImageMemoryBind(AdamantiumVulkan.Core.Interop.VkSparseImageMemoryBind _internal)
    {
        Subresource = new ImageSubresource(_internal.subresource);
        Offset = new Offset3D(_internal.offset);
        Extent = new Extent3D(_internal.extent);
        Memory = new DeviceMemory(_internal.memory);
        MemoryOffset = _internal.memoryOffset;
        Flags = _internal.flags;
    }

    public ImageSubresource Subresource { get; set; }
    public Offset3D Offset { get; set; }
    public Extent3D Extent { get; set; }
    public DeviceMemory Memory { get; set; }
    public VkDeviceSize MemoryOffset { get; set; }
    public VkSparseMemoryBindFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSparseImageMemoryBind ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSparseImageMemoryBind();
        if (Subresource != default)
        {
            _internal.subresource = Subresource.ToNative();
        }
        if (Offset != default)
        {
            _internal.offset = Offset.ToNative();
        }
        if (Extent != default)
        {
            _internal.extent = Extent.ToNative();
        }
        if (Memory != default)
        {
            _internal.memory = Memory;
        }
        if (MemoryOffset != (ulong)default)
        {
            _internal.memoryOffset = MemoryOffset;
        }
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Subresource?.Dispose();
        Offset?.Dispose();
        Extent?.Dispose();
    }


    public static implicit operator SparseImageMemoryBind(AdamantiumVulkan.Core.Interop.VkSparseImageMemoryBind s)
    {
        return new SparseImageMemoryBind(s);
    }

}



