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

public unsafe partial class AttachmentDescription
{
    public AttachmentDescription()
    {
    }

    public AttachmentDescription(AdamantiumVulkan.Core.Interop.VkAttachmentDescription _internal)
    {
        Flags = _internal.flags;
        Format = _internal.format;
        Samples = _internal.samples;
        LoadOp = _internal.loadOp;
        StoreOp = _internal.storeOp;
        StencilLoadOp = _internal.stencilLoadOp;
        StencilStoreOp = _internal.stencilStoreOp;
        InitialLayout = _internal.initialLayout;
        FinalLayout = _internal.finalLayout;
    }

    public AttachmentDescriptionFlagBits Flags { get; set; }
    public Format Format { get; set; }
    public SampleCountFlagBits Samples { get; set; }
    public AttachmentLoadOp LoadOp { get; set; }
    public AttachmentStoreOp StoreOp { get; set; }
    public AttachmentLoadOp StencilLoadOp { get; set; }
    public AttachmentStoreOp StencilStoreOp { get; set; }
    public ImageLayout InitialLayout { get; set; }
    public ImageLayout FinalLayout { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAttachmentDescription ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAttachmentDescription();
        _internal.flags = Flags;
        _internal.format = Format;
        _internal.samples = Samples;
        _internal.loadOp = LoadOp;
        _internal.storeOp = StoreOp;
        _internal.stencilLoadOp = StencilLoadOp;
        _internal.stencilStoreOp = StencilStoreOp;
        _internal.initialLayout = InitialLayout;
        _internal.finalLayout = FinalLayout;
        return _internal;
    }

    public static implicit operator AttachmentDescription(AdamantiumVulkan.Core.Interop.VkAttachmentDescription a)
    {
        return new AttachmentDescription(a);
    }

}



