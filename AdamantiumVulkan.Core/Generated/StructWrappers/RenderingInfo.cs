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

public unsafe partial class RenderingInfo : QBDisposableObject
{
    private NativeStructArray<VkRenderingAttachmentInfo> pColorAttachments;

    private NativeStruct<VkRenderingAttachmentInfo> pDepthAttachment;

    private NativeStruct<VkRenderingAttachmentInfo> pStencilAttachment;

    public RenderingInfo()
    {
    }

    public RenderingInfo(AdamantiumVulkan.Core.Interop.VkRenderingInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        RenderArea = new Rect2D(_internal.renderArea);
        LayerCount = _internal.layerCount;
        ViewMask = _internal.viewMask;
        ColorAttachmentCount = _internal.colorAttachmentCount;
        PColorAttachments = new RenderingAttachmentInfo[_internal.colorAttachmentCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pColorAttachments, _internal.colorAttachmentCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PColorAttachments[i] = new RenderingAttachmentInfo(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pColorAttachments);
        PDepthAttachment = new RenderingAttachmentInfo(*_internal.pDepthAttachment);
        NativeUtils.Free(_internal.pDepthAttachment);
        PStencilAttachment = new RenderingAttachmentInfo(*_internal.pStencilAttachment);
        NativeUtils.Free(_internal.pStencilAttachment);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkRenderingFlags Flags { get; set; }
    public Rect2D RenderArea { get; set; }
    public uint LayerCount { get; set; }
    public uint ViewMask { get; set; }
    public uint ColorAttachmentCount { get; set; }
    public RenderingAttachmentInfo[] PColorAttachments { get; set; }
    public RenderingAttachmentInfo PDepthAttachment { get; set; }
    public RenderingAttachmentInfo PStencilAttachment { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderingInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderingInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        if (RenderArea != null)
        {
            _internal.renderArea = RenderArea.ToNative();
        }
        _internal.layerCount = LayerCount;
        _internal.viewMask = ViewMask;
        _internal.colorAttachmentCount = ColorAttachmentCount;
        pColorAttachments.Dispose();
        if (PColorAttachments != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkRenderingAttachmentInfo[PColorAttachments.Length];
            for (int i = 0; i < PColorAttachments.Length; ++i)
            {
                tmpArray0[i] = PColorAttachments[i].ToNative();
            }
            pColorAttachments = new NativeStructArray<VkRenderingAttachmentInfo>(tmpArray0);
            _internal.pColorAttachments = pColorAttachments.Handle;
        }
        pDepthAttachment.Dispose();
        if (PDepthAttachment != null)
        {
            var struct0 = PDepthAttachment.ToNative();
            pDepthAttachment = new NativeStruct<VkRenderingAttachmentInfo>(struct0);
            _internal.pDepthAttachment = pDepthAttachment.Handle;
        }
        pStencilAttachment.Dispose();
        if (PStencilAttachment != null)
        {
            var struct1 = PStencilAttachment.ToNative();
            pStencilAttachment = new NativeStruct<VkRenderingAttachmentInfo>(struct1);
            _internal.pStencilAttachment = pStencilAttachment.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pColorAttachments.Dispose();
        pDepthAttachment.Dispose();
        pStencilAttachment.Dispose();
    }


    public static implicit operator RenderingInfo(AdamantiumVulkan.Core.Interop.VkRenderingInfo r)
    {
        return new RenderingInfo(r);
    }

}



