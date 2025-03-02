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

public unsafe partial class HostImageLayoutTransitionInfo : QBDisposableObject
{
    public HostImageLayoutTransitionInfo()
    {
    }

    public HostImageLayoutTransitionInfo(AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Image = new Image(_internal.image);
        OldLayout = _internal.oldLayout;
        NewLayout = _internal.newLayout;
        SubresourceRange = new ImageSubresourceRange(_internal.subresourceRange);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Image Image { get; set; }
    public ImageLayout OldLayout { get; set; }
    public ImageLayout NewLayout { get; set; }
    public ImageSubresourceRange SubresourceRange { get; set; }

    public AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Image != default)
        {
            _internal.image = Image;
        }
        if (OldLayout != default)
        {
            _internal.oldLayout = OldLayout;
        }
        if (NewLayout != default)
        {
            _internal.newLayout = NewLayout;
        }
        if (SubresourceRange != default)
        {
            _internal.subresourceRange = SubresourceRange.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        SubresourceRange?.Dispose();
    }


    public static implicit operator HostImageLayoutTransitionInfo(AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo h)
    {
        return new HostImageLayoutTransitionInfo(h);
    }

}



