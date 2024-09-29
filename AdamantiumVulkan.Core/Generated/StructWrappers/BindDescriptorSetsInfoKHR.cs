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

public unsafe partial class BindDescriptorSetsInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkDescriptorSet_T> _pDescriptorSets;

    private NativeStruct<uint> _pDynamicOffsets;

    public BindDescriptorSetsInfoKHR()
    {
    }

    public BindDescriptorSetsInfoKHR(AdamantiumVulkan.Core.Interop.VkBindDescriptorSetsInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        StageFlags = _internal.stageFlags;
        Layout = new PipelineLayout(_internal.layout);
        FirstSet = _internal.firstSet;
        DescriptorSetCount = _internal.descriptorSetCount;
        PDescriptorSets = new DescriptorSet(*_internal.pDescriptorSets);
        NativeUtils.Free(_internal.pDescriptorSets);
        DynamicOffsetCount = _internal.dynamicOffsetCount;
        if (_internal.pDynamicOffsets != null)
        {
            PDynamicOffsets = *_internal.pDynamicOffsets;
            NativeUtils.Free(_internal.pDynamicOffsets);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkShaderStageFlags StageFlags { get; set; }
    public PipelineLayout Layout { get; set; }
    public uint FirstSet { get; set; }
    public uint DescriptorSetCount { get; set; }
    public DescriptorSet PDescriptorSets { get; set; }
    public uint DynamicOffsetCount { get; set; }
    public uint? PDynamicOffsets { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBindDescriptorSetsInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBindDescriptorSetsInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (StageFlags != (uint)default)
        {
            _internal.stageFlags = StageFlags;
        }
        if (Layout != default)
        {
            _internal.layout = Layout;
        }
        if (FirstSet != default)
        {
            _internal.firstSet = FirstSet;
        }
        if (DescriptorSetCount != default)
        {
            _internal.descriptorSetCount = DescriptorSetCount;
        }
        _pDescriptorSets.Dispose();
        if (PDescriptorSets != default)
        {
            AdamantiumVulkan.Core.Interop.VkDescriptorSet_T struct0 = PDescriptorSets;
            _pDescriptorSets = new NativeStruct<AdamantiumVulkan.Core.Interop.VkDescriptorSet_T>(struct0);
            _internal.pDescriptorSets = _pDescriptorSets.Handle;
        }
        if (DynamicOffsetCount != default)
        {
            _internal.dynamicOffsetCount = DynamicOffsetCount;
        }
        _pDynamicOffsets.Dispose();
        if (PDynamicOffsets.HasValue)
        {
            _pDynamicOffsets = new NativeStruct<uint>(PDynamicOffsets.Value);
            _internal.pDynamicOffsets = _pDynamicOffsets.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pDescriptorSets.Dispose();
        _pDynamicOffsets.Dispose();
    }


    public static implicit operator BindDescriptorSetsInfoKHR(AdamantiumVulkan.Core.Interop.VkBindDescriptorSetsInfoKHR b)
    {
        return new BindDescriptorSetsInfoKHR(b);
    }

}



