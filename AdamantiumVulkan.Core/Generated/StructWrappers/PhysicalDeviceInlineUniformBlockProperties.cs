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

public unsafe partial class PhysicalDeviceInlineUniformBlockProperties : QBDisposableObject
{
    public PhysicalDeviceInlineUniformBlockProperties()
    {
    }

    public PhysicalDeviceInlineUniformBlockProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceInlineUniformBlockProperties _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxInlineUniformBlockSize = _internal.maxInlineUniformBlockSize;
        MaxPerStageDescriptorInlineUniformBlocks = _internal.maxPerStageDescriptorInlineUniformBlocks;
        MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = _internal.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        MaxDescriptorSetInlineUniformBlocks = _internal.maxDescriptorSetInlineUniformBlocks;
        MaxDescriptorSetUpdateAfterBindInlineUniformBlocks = _internal.maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxInlineUniformBlockSize { get; set; }
    public uint MaxPerStageDescriptorInlineUniformBlocks { get; set; }
    public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks { get; set; }
    public uint MaxDescriptorSetInlineUniformBlocks { get; set; }
    public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceInlineUniformBlockProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceInlineUniformBlockProperties();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxInlineUniformBlockSize != default)
        {
            _internal.maxInlineUniformBlockSize = MaxInlineUniformBlockSize;
        }
        if (MaxPerStageDescriptorInlineUniformBlocks != default)
        {
            _internal.maxPerStageDescriptorInlineUniformBlocks = MaxPerStageDescriptorInlineUniformBlocks;
        }
        if (MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks != default)
        {
            _internal.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        }
        if (MaxDescriptorSetInlineUniformBlocks != default)
        {
            _internal.maxDescriptorSetInlineUniformBlocks = MaxDescriptorSetInlineUniformBlocks;
        }
        if (MaxDescriptorSetUpdateAfterBindInlineUniformBlocks != default)
        {
            _internal.maxDescriptorSetUpdateAfterBindInlineUniformBlocks = MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceInlineUniformBlockProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceInlineUniformBlockProperties p)
    {
        return new PhysicalDeviceInlineUniformBlockProperties(p);
    }

}



