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

public unsafe partial class CopyDescriptorSet : QBDisposableObject
{
    public CopyDescriptorSet()
    {
    }

    public CopyDescriptorSet(AdamantiumVulkan.Core.Interop.VkCopyDescriptorSet _internal)
    {
        PNext = _internal.pNext;
        SrcSet = new DescriptorSet(_internal.srcSet);
        SrcBinding = _internal.srcBinding;
        SrcArrayElement = _internal.srcArrayElement;
        DstSet = new DescriptorSet(_internal.dstSet);
        DstBinding = _internal.dstBinding;
        DstArrayElement = _internal.dstArrayElement;
        DescriptorCount = _internal.descriptorCount;
    }

    public StructureType SType => StructureType.CopyDescriptorSet;
    public void* PNext { get; set; }
    public DescriptorSet SrcSet { get; set; }
    public uint SrcBinding { get; set; }
    public uint SrcArrayElement { get; set; }
    public DescriptorSet DstSet { get; set; }
    public uint DstBinding { get; set; }
    public uint DstArrayElement { get; set; }
    public uint DescriptorCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyDescriptorSet ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyDescriptorSet();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.srcSet = SrcSet;
        _internal.srcBinding = SrcBinding;
        _internal.srcArrayElement = SrcArrayElement;
        _internal.dstSet = DstSet;
        _internal.dstBinding = DstBinding;
        _internal.dstArrayElement = DstArrayElement;
        _internal.descriptorCount = DescriptorCount;
        return _internal;
    }

    public static implicit operator CopyDescriptorSet(AdamantiumVulkan.Core.Interop.VkCopyDescriptorSet c)
    {
        return new CopyDescriptorSet(c);
    }

}


