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
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.maxInlineUniformBlockSize = MaxInlineUniformBlockSize;
        _internal.maxPerStageDescriptorInlineUniformBlocks = MaxPerStageDescriptorInlineUniformBlocks;
        _internal.maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks = MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        _internal.maxDescriptorSetInlineUniformBlocks = MaxDescriptorSetInlineUniformBlocks;
        _internal.maxDescriptorSetUpdateAfterBindInlineUniformBlocks = MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        return _internal;
    }

    public static implicit operator PhysicalDeviceInlineUniformBlockProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceInlineUniformBlockProperties p)
    {
        return new PhysicalDeviceInlineUniformBlockProperties(p);
    }

}



