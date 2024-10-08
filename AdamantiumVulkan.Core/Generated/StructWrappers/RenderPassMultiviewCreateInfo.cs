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

public unsafe partial class RenderPassMultiviewCreateInfo : QBDisposableObject
{
    private NativeStruct<uint> _pViewMasks;

    private NativeStruct<int> _pViewOffsets;

    private NativeStruct<uint> _pCorrelationMasks;

    public RenderPassMultiviewCreateInfo()
    {
    }

    public RenderPassMultiviewCreateInfo(AdamantiumVulkan.Core.Interop.VkRenderPassMultiviewCreateInfo _internal)
    {
        PNext = _internal.pNext;
        SubpassCount = _internal.subpassCount;
        if (_internal.pViewMasks != null)
        {
            PViewMasks = *_internal.pViewMasks;
            NativeUtils.Free(_internal.pViewMasks);
        }
        DependencyCount = _internal.dependencyCount;
        if (_internal.pViewOffsets != null)
        {
            PViewOffsets = *_internal.pViewOffsets;
            NativeUtils.Free(_internal.pViewOffsets);
        }
        CorrelationMaskCount = _internal.correlationMaskCount;
        if (_internal.pCorrelationMasks != null)
        {
            PCorrelationMasks = *_internal.pCorrelationMasks;
            NativeUtils.Free(_internal.pCorrelationMasks);
        }
    }

    public StructureType SType => StructureType.RenderPassMultiviewCreateInfo;
    public void* PNext { get; set; }
    public uint SubpassCount { get; set; }
    public uint? PViewMasks { get; set; }
    public uint DependencyCount { get; set; }
    public int? PViewOffsets { get; set; }
    public uint CorrelationMaskCount { get; set; }
    public uint? PCorrelationMasks { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassMultiviewCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassMultiviewCreateInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SubpassCount != default)
        {
            _internal.subpassCount = SubpassCount;
        }
        _pViewMasks.Dispose();
        if (PViewMasks.HasValue)
        {
            _pViewMasks = new NativeStruct<uint>(PViewMasks.Value);
            _internal.pViewMasks = _pViewMasks.Handle;
        }
        if (DependencyCount != default)
        {
            _internal.dependencyCount = DependencyCount;
        }
        _pViewOffsets.Dispose();
        if (PViewOffsets.HasValue)
        {
            _pViewOffsets = new NativeStruct<int>(PViewOffsets.Value);
            _internal.pViewOffsets = _pViewOffsets.Handle;
        }
        if (CorrelationMaskCount != default)
        {
            _internal.correlationMaskCount = CorrelationMaskCount;
        }
        _pCorrelationMasks.Dispose();
        if (PCorrelationMasks.HasValue)
        {
            _pCorrelationMasks = new NativeStruct<uint>(PCorrelationMasks.Value);
            _internal.pCorrelationMasks = _pCorrelationMasks.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pViewMasks.Dispose();
        _pViewOffsets.Dispose();
        _pCorrelationMasks.Dispose();
    }


    public static implicit operator RenderPassMultiviewCreateInfo(AdamantiumVulkan.Core.Interop.VkRenderPassMultiviewCreateInfo r)
    {
        return new RenderPassMultiviewCreateInfo(r);
    }

}



