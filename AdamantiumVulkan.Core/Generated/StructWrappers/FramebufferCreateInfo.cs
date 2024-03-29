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

public unsafe partial class FramebufferCreateInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkImageView_T> _pAttachments;

    public FramebufferCreateInfo()
    {
    }

    public FramebufferCreateInfo(AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        RenderPass = new RenderPass(_internal.renderPass);
        AttachmentCount = _internal.attachmentCount;
        PAttachments = new ImageView[_internal.attachmentCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pAttachments, _internal.attachmentCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PAttachments[i] = new ImageView(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pAttachments);
        Width = _internal.width;
        Height = _internal.height;
        Layers = _internal.layers;
    }

    public StructureType SType => StructureType.FramebufferCreateInfo;
    public void* PNext { get; set; }
    public VkFramebufferCreateFlags Flags { get; set; }
    public RenderPass RenderPass { get; set; }
    public uint AttachmentCount { get; set; }
    public ImageView[] PAttachments { get; set; }
    public uint Width { get; set; }
    public uint Height { get; set; }
    public uint Layers { get; set; }

    public AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.renderPass = RenderPass;
        _internal.attachmentCount = AttachmentCount;
        _pAttachments.Dispose();
        if (PAttachments != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkImageView_T[PAttachments.Length];
            for (int i = 0; i < PAttachments.Length; ++i)
            {
                tmpArray0[i] = PAttachments[i];
            }
            _pAttachments = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkImageView_T>(tmpArray0);
            _internal.pAttachments = _pAttachments.Handle;
        }
        _internal.width = Width;
        _internal.height = Height;
        _internal.layers = Layers;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pAttachments.Dispose();
    }


    public static implicit operator FramebufferCreateInfo(AdamantiumVulkan.Core.Interop.VkFramebufferCreateInfo f)
    {
        return new FramebufferCreateInfo(f);
    }

}



