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

public unsafe partial class ImageViewHandleInfoNVX : QBDisposableObject
{
    public ImageViewHandleInfoNVX()
    {
    }

    public ImageViewHandleInfoNVX(AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageView = new ImageView(_internal.imageView);
        DescriptorType = _internal.descriptorType;
        Sampler = new Sampler(_internal.sampler);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ImageView ImageView { get; set; }
    public DescriptorType DescriptorType { get; set; }
    public Sampler Sampler { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ImageView != default)
        {
            _internal.imageView = ImageView;
        }
        if (DescriptorType != default)
        {
            _internal.descriptorType = DescriptorType;
        }
        if (Sampler != default)
        {
            _internal.sampler = Sampler;
        }
        return _internal;
    }

    public static implicit operator ImageViewHandleInfoNVX(AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX i)
    {
        return new ImageViewHandleInfoNVX(i);
    }

}



