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

public unsafe partial class RenderingInputAttachmentIndexInfoKHR : QBDisposableObject
{
    private NativeStruct<uint> _pColorAttachmentInputIndices;

    private NativeStruct<uint> _pDepthInputAttachmentIndex;

    private NativeStruct<uint> _pStencilInputAttachmentIndex;

    public RenderingInputAttachmentIndexInfoKHR()
    {
    }

    public RenderingInputAttachmentIndexInfoKHR(AdamantiumVulkan.Core.Interop.VkRenderingInputAttachmentIndexInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ColorAttachmentCount = _internal.colorAttachmentCount;
        if (_internal.pColorAttachmentInputIndices != null)
        {
            PColorAttachmentInputIndices = *_internal.pColorAttachmentInputIndices;
            NativeUtils.Free(_internal.pColorAttachmentInputIndices);
        }
        if (_internal.pDepthInputAttachmentIndex != null)
        {
            PDepthInputAttachmentIndex = *_internal.pDepthInputAttachmentIndex;
            NativeUtils.Free(_internal.pDepthInputAttachmentIndex);
        }
        if (_internal.pStencilInputAttachmentIndex != null)
        {
            PStencilInputAttachmentIndex = *_internal.pStencilInputAttachmentIndex;
            NativeUtils.Free(_internal.pStencilInputAttachmentIndex);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint ColorAttachmentCount { get; set; }
    public uint? PColorAttachmentInputIndices { get; set; }
    public uint? PDepthInputAttachmentIndex { get; set; }
    public uint? PStencilInputAttachmentIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderingInputAttachmentIndexInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderingInputAttachmentIndexInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ColorAttachmentCount != default)
        {
            _internal.colorAttachmentCount = ColorAttachmentCount;
        }
        _pColorAttachmentInputIndices.Dispose();
        if (PColorAttachmentInputIndices.HasValue)
        {
            _pColorAttachmentInputIndices = new NativeStruct<uint>(PColorAttachmentInputIndices.Value);
            _internal.pColorAttachmentInputIndices = _pColorAttachmentInputIndices.Handle;
        }
        _pDepthInputAttachmentIndex.Dispose();
        if (PDepthInputAttachmentIndex.HasValue)
        {
            _pDepthInputAttachmentIndex = new NativeStruct<uint>(PDepthInputAttachmentIndex.Value);
            _internal.pDepthInputAttachmentIndex = _pDepthInputAttachmentIndex.Handle;
        }
        _pStencilInputAttachmentIndex.Dispose();
        if (PStencilInputAttachmentIndex.HasValue)
        {
            _pStencilInputAttachmentIndex = new NativeStruct<uint>(PStencilInputAttachmentIndex.Value);
            _internal.pStencilInputAttachmentIndex = _pStencilInputAttachmentIndex.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pColorAttachmentInputIndices.Dispose();
        _pDepthInputAttachmentIndex.Dispose();
        _pStencilInputAttachmentIndex.Dispose();
    }


    public static implicit operator RenderingInputAttachmentIndexInfoKHR(AdamantiumVulkan.Core.Interop.VkRenderingInputAttachmentIndexInfoKHR r)
    {
        return new RenderingInputAttachmentIndexInfoKHR(r);
    }

}



