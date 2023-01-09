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

public unsafe partial class DescriptorUpdateTemplateEntry
{
    public DescriptorUpdateTemplateEntry()
    {
    }

    public DescriptorUpdateTemplateEntry(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateEntry _internal)
    {
        DstBinding = _internal.dstBinding;
        DstArrayElement = _internal.dstArrayElement;
        DescriptorCount = _internal.descriptorCount;
        DescriptorType = _internal.descriptorType;
        Offset = _internal.offset;
        Stride = _internal.stride;
    }

    public uint DstBinding { get; set; }
    public uint DstArrayElement { get; set; }
    public uint DescriptorCount { get; set; }
    public DescriptorType DescriptorType { get; set; }
    public ulong Offset { get; set; }
    public ulong Stride { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateEntry ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateEntry();
        _internal.dstBinding = DstBinding;
        _internal.dstArrayElement = DstArrayElement;
        _internal.descriptorCount = DescriptorCount;
        _internal.descriptorType = DescriptorType;
        _internal.offset = Offset;
        _internal.stride = Stride;
        return _internal;
    }

    public static implicit operator DescriptorUpdateTemplateEntry(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateEntry d)
    {
        return new DescriptorUpdateTemplateEntry(d);
    }

}


