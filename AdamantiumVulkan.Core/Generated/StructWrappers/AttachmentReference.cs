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

public unsafe partial class AttachmentReference : QBDisposableObject
{
    public AttachmentReference()
    {
    }

    public AttachmentReference(AdamantiumVulkan.Core.Interop.VkAttachmentReference _internal)
    {
        Attachment = _internal.attachment;
        Layout = _internal.layout;
    }

    public uint Attachment { get; set; }
    public ImageLayout Layout { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAttachmentReference ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAttachmentReference();
        if (Attachment != default)
        {
            _internal.attachment = Attachment;
        }
        if (Layout != default)
        {
            _internal.layout = Layout;
        }
        return _internal;
    }

    public static implicit operator AttachmentReference(AdamantiumVulkan.Core.Interop.VkAttachmentReference a)
    {
        return new AttachmentReference(a);
    }

}



