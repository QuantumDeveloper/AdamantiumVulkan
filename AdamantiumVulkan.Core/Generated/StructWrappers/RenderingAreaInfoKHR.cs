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

public unsafe partial class RenderingAreaInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Format> _pColorAttachmentFormats;

    public RenderingAreaInfoKHR()
    {
    }

    public RenderingAreaInfoKHR(AdamantiumVulkan.Core.Interop.VkRenderingAreaInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ViewMask = _internal.viewMask;
        ColorAttachmentCount = _internal.colorAttachmentCount;
        PColorAttachmentFormats = *_internal.pColorAttachmentFormats;
        DepthAttachmentFormat = _internal.depthAttachmentFormat;
        StencilAttachmentFormat = _internal.stencilAttachmentFormat;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint ViewMask { get; set; }
    public uint ColorAttachmentCount { get; set; }
    public Format? PColorAttachmentFormats { get; set; }
    public Format DepthAttachmentFormat { get; set; }
    public Format StencilAttachmentFormat { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderingAreaInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderingAreaInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ViewMask != default)
        {
            _internal.viewMask = ViewMask;
        }
        if (ColorAttachmentCount != default)
        {
            _internal.colorAttachmentCount = ColorAttachmentCount;
        }
        _pColorAttachmentFormats.Dispose();
        if (PColorAttachmentFormats.HasValue)
        {
            _pColorAttachmentFormats = new NativeStruct<AdamantiumVulkan.Core.Format>(PColorAttachmentFormats.Value);
            _internal.pColorAttachmentFormats = _pColorAttachmentFormats.Handle;
        }
        if (DepthAttachmentFormat != default)
        {
            _internal.depthAttachmentFormat = DepthAttachmentFormat;
        }
        if (StencilAttachmentFormat != default)
        {
            _internal.stencilAttachmentFormat = StencilAttachmentFormat;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pColorAttachmentFormats.Dispose();
    }


    public static implicit operator RenderingAreaInfoKHR(AdamantiumVulkan.Core.Interop.VkRenderingAreaInfoKHR r)
    {
        return new RenderingAreaInfoKHR(r);
    }

}


