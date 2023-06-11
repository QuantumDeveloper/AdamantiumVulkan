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

public unsafe partial class ImageViewCaptureDescriptorDataInfoEXT : QBDisposableObject
{
    public ImageViewCaptureDescriptorDataInfoEXT()
    {
    }

    public ImageViewCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkImageViewCaptureDescriptorDataInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageView = new ImageView(_internal.imageView);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ImageView ImageView { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageViewCaptureDescriptorDataInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageViewCaptureDescriptorDataInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.imageView = ImageView;
        return _internal;
    }

    public static implicit operator ImageViewCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkImageViewCaptureDescriptorDataInfoEXT i)
    {
        return new ImageViewCaptureDescriptorDataInfoEXT(i);
    }

}


