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

public unsafe partial class InputAttachmentAspectReference : QBDisposableObject
{
    public InputAttachmentAspectReference()
    {
    }

    public InputAttachmentAspectReference(AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference _internal)
    {
        Subpass = _internal.subpass;
        InputAttachmentIndex = _internal.inputAttachmentIndex;
        AspectMask = _internal.aspectMask;
    }

    public uint Subpass { get; set; }
    public uint InputAttachmentIndex { get; set; }
    public VkImageAspectFlags AspectMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference();
        if (Subpass != default)
        {
            _internal.subpass = Subpass;
        }
        if (InputAttachmentIndex != default)
        {
            _internal.inputAttachmentIndex = InputAttachmentIndex;
        }
        if (AspectMask != (uint)default)
        {
            _internal.aspectMask = AspectMask;
        }
        return _internal;
    }

    public static implicit operator InputAttachmentAspectReference(AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference i)
    {
        return new InputAttachmentAspectReference(i);
    }

}



