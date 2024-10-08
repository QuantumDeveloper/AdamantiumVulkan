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

public unsafe partial class DecompressMemoryRegionNV : QBDisposableObject
{
    public DecompressMemoryRegionNV()
    {
    }

    public DecompressMemoryRegionNV(AdamantiumVulkan.Core.Interop.VkDecompressMemoryRegionNV _internal)
    {
        SrcAddress = _internal.srcAddress;
        DstAddress = _internal.dstAddress;
        CompressedSize = _internal.compressedSize;
        DecompressedSize = _internal.decompressedSize;
        DecompressionMethod = _internal.decompressionMethod;
    }

    public VkDeviceAddress SrcAddress { get; set; }
    public VkDeviceAddress DstAddress { get; set; }
    public VkDeviceSize CompressedSize { get; set; }
    public VkDeviceSize DecompressedSize { get; set; }
    public VkMemoryDecompressionMethodFlagsNV DecompressionMethod { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDecompressMemoryRegionNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDecompressMemoryRegionNV();
        if (SrcAddress != (ulong)default)
        {
            _internal.srcAddress = SrcAddress;
        }
        if (DstAddress != (ulong)default)
        {
            _internal.dstAddress = DstAddress;
        }
        if (CompressedSize != (ulong)default)
        {
            _internal.compressedSize = CompressedSize;
        }
        if (DecompressedSize != (ulong)default)
        {
            _internal.decompressedSize = DecompressedSize;
        }
        if (DecompressionMethod != (ulong)default)
        {
            _internal.decompressionMethod = DecompressionMethod;
        }
        return _internal;
    }

    public static implicit operator DecompressMemoryRegionNV(AdamantiumVulkan.Core.Interop.VkDecompressMemoryRegionNV d)
    {
        return new DecompressMemoryRegionNV(d);
    }

}



