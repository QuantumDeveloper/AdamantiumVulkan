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

public unsafe partial class RenderPassInputAttachmentAspectCreateInfo : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference> _pAspectReferences;

    public RenderPassInputAttachmentAspectCreateInfo()
    {
    }

    public RenderPassInputAttachmentAspectCreateInfo(AdamantiumVulkan.Core.Interop.VkRenderPassInputAttachmentAspectCreateInfo _internal)
    {
        PNext = _internal.pNext;
        AspectReferenceCount = _internal.aspectReferenceCount;
        PAspectReferences = new InputAttachmentAspectReference(*_internal.pAspectReferences);
        NativeUtils.Free(_internal.pAspectReferences);
    }

    public StructureType SType => StructureType.RenderPassInputAttachmentAspectCreateInfo;
    public void* PNext { get; set; }
    public uint AspectReferenceCount { get; set; }
    public InputAttachmentAspectReference PAspectReferences { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassInputAttachmentAspectCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassInputAttachmentAspectCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.aspectReferenceCount = AspectReferenceCount;
        _pAspectReferences.Dispose();
        if (PAspectReferences != null)
        {
            var struct0 = PAspectReferences.ToNative();
            _pAspectReferences = new NativeStruct<AdamantiumVulkan.Core.Interop.VkInputAttachmentAspectReference>(struct0);
            _internal.pAspectReferences = _pAspectReferences.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pAspectReferences.Dispose();
    }


    public static implicit operator RenderPassInputAttachmentAspectCreateInfo(AdamantiumVulkan.Core.Interop.VkRenderPassInputAttachmentAspectCreateInfo r)
    {
        return new RenderPassInputAttachmentAspectCreateInfo(r);
    }

}



