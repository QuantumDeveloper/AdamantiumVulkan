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

public unsafe partial class DescriptorImageInfo
{
    public DescriptorImageInfo()
    {
    }

    public DescriptorImageInfo(AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo _internal)
    {
        Sampler = new Sampler(_internal.sampler);
        ImageView = new ImageView(_internal.imageView);
        ImageLayout = _internal.imageLayout;
    }

    public Sampler Sampler { get; set; }
    public ImageView ImageView { get; set; }
    public ImageLayout ImageLayout { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo();
        _internal.sampler = Sampler;
        _internal.imageView = ImageView;
        _internal.imageLayout = ImageLayout;
        return _internal;
    }

    public static implicit operator DescriptorImageInfo(AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo d)
    {
        return new DescriptorImageInfo(d);
    }

}


