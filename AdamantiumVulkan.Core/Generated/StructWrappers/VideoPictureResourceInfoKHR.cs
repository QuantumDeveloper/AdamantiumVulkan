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

public unsafe partial class VideoPictureResourceInfoKHR : QBDisposableObject
{
    public VideoPictureResourceInfoKHR()
    {
    }

    public VideoPictureResourceInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoPictureResourceInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CodedOffset = new Offset2D(_internal.codedOffset);
        CodedExtent = new Extent2D(_internal.codedExtent);
        BaseArrayLayer = _internal.baseArrayLayer;
        ImageViewBinding = new ImageView(_internal.imageViewBinding);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Offset2D CodedOffset { get; set; }
    public Extent2D CodedExtent { get; set; }
    public uint BaseArrayLayer { get; set; }
    public ImageView ImageViewBinding { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoPictureResourceInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoPictureResourceInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (CodedOffset != null)
        {
            _internal.codedOffset = CodedOffset.ToNative();
        }
        if (CodedExtent != null)
        {
            _internal.codedExtent = CodedExtent.ToNative();
        }
        _internal.baseArrayLayer = BaseArrayLayer;
        _internal.imageViewBinding = ImageViewBinding;
        return _internal;
    }

    public static implicit operator VideoPictureResourceInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoPictureResourceInfoKHR v)
    {
        return new VideoPictureResourceInfoKHR(v);
    }

}



