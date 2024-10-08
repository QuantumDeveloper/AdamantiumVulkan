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

public unsafe partial class DescriptorPoolInlineUniformBlockCreateInfo : QBDisposableObject
{
    public DescriptorPoolInlineUniformBlockCreateInfo()
    {
    }

    public DescriptorPoolInlineUniformBlockCreateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorPoolInlineUniformBlockCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxInlineUniformBlockBindings = _internal.maxInlineUniformBlockBindings;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxInlineUniformBlockBindings { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorPoolInlineUniformBlockCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorPoolInlineUniformBlockCreateInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxInlineUniformBlockBindings != default)
        {
            _internal.maxInlineUniformBlockBindings = MaxInlineUniformBlockBindings;
        }
        return _internal;
    }

    public static implicit operator DescriptorPoolInlineUniformBlockCreateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorPoolInlineUniformBlockCreateInfo d)
    {
        return new DescriptorPoolInlineUniformBlockCreateInfo(d);
    }

}



