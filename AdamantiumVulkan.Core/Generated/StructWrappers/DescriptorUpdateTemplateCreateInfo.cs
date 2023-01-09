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

public unsafe partial class DescriptorUpdateTemplateCreateInfo : QBDisposableObject
{
    private NativeStruct<VkDescriptorUpdateTemplateEntry> pDescriptorUpdateEntries;

    public DescriptorUpdateTemplateCreateInfo()
    {
    }

    public DescriptorUpdateTemplateCreateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        DescriptorUpdateEntryCount = _internal.descriptorUpdateEntryCount;
        PDescriptorUpdateEntries = new DescriptorUpdateTemplateEntry(*_internal.pDescriptorUpdateEntries);
        NativeUtils.Free(_internal.pDescriptorUpdateEntries);
        TemplateType = _internal.templateType;
        DescriptorSetLayout = new DescriptorSetLayout(_internal.descriptorSetLayout);
        PipelineBindPoint = _internal.pipelineBindPoint;
        PipelineLayout = new PipelineLayout(_internal.pipelineLayout);
        Set = _internal.set;
    }

    public StructureType SType => StructureType.DescriptorUpdateTemplateCreateInfo;
    public void* PNext { get; set; }
    public VkDescriptorUpdateTemplateCreateFlags Flags { get; set; }
    public uint DescriptorUpdateEntryCount { get; set; }
    public DescriptorUpdateTemplateEntry PDescriptorUpdateEntries { get; set; }
    public DescriptorUpdateTemplateType TemplateType { get; set; }
    public DescriptorSetLayout DescriptorSetLayout { get; set; }
    public PipelineBindPoint PipelineBindPoint { get; set; }
    public PipelineLayout PipelineLayout { get; set; }
    public uint Set { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.descriptorUpdateEntryCount = DescriptorUpdateEntryCount;
        pDescriptorUpdateEntries.Dispose();
        if (PDescriptorUpdateEntries != null)
        {
            var struct0 = PDescriptorUpdateEntries.ToNative();
            pDescriptorUpdateEntries = new NativeStruct<VkDescriptorUpdateTemplateEntry>(struct0);
            _internal.pDescriptorUpdateEntries = pDescriptorUpdateEntries.Handle;
        }
        _internal.templateType = TemplateType;
        _internal.descriptorSetLayout = DescriptorSetLayout;
        _internal.pipelineBindPoint = PipelineBindPoint;
        _internal.pipelineLayout = PipelineLayout;
        _internal.set = Set;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pDescriptorUpdateEntries.Dispose();
    }


    public static implicit operator DescriptorUpdateTemplateCreateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorUpdateTemplateCreateInfo d)
    {
        return new DescriptorUpdateTemplateCreateInfo(d);
    }

}


