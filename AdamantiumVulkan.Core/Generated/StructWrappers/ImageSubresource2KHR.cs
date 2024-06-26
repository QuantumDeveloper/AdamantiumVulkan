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

public unsafe partial class ImageSubresource2KHR : QBDisposableObject
{
    public ImageSubresource2KHR()
    {
    }

    public ImageSubresource2KHR(AdamantiumVulkan.Core.Interop.VkImageSubresource2KHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ImageSubresource = new ImageSubresource(_internal.imageSubresource);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ImageSubresource ImageSubresource { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageSubresource2KHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageSubresource2KHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (ImageSubresource != null)
        {
            _internal.imageSubresource = ImageSubresource.ToNative();
        }
        return _internal;
    }

    public static implicit operator ImageSubresource2KHR(AdamantiumVulkan.Core.Interop.VkImageSubresource2KHR i)
    {
        return new ImageSubresource2KHR(i);
    }

}



