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

public unsafe partial class WriteDescriptorSetInlineUniformBlock : QBDisposableObject
{
    public WriteDescriptorSetInlineUniformBlock()
    {
    }

    public WriteDescriptorSetInlineUniformBlock(AdamantiumVulkan.Core.Interop.VkWriteDescriptorSetInlineUniformBlock _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DataSize = _internal.dataSize;
        PData = _internal.pData;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint DataSize { get; set; }
    public void* PData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkWriteDescriptorSetInlineUniformBlock ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkWriteDescriptorSetInlineUniformBlock();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.dataSize = DataSize;
        _internal.pData = PData;
        return _internal;
    }

    public static implicit operator WriteDescriptorSetInlineUniformBlock(AdamantiumVulkan.Core.Interop.VkWriteDescriptorSetInlineUniformBlock w)
    {
        return new WriteDescriptorSetInlineUniformBlock(w);
    }

}


