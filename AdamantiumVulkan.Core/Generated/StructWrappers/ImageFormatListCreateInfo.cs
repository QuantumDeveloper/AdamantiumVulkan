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

public unsafe partial class ImageFormatListCreateInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Format> _pViewFormats;

    public ImageFormatListCreateInfo()
    {
    }

    public ImageFormatListCreateInfo(AdamantiumVulkan.Core.Interop.VkImageFormatListCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ViewFormatCount = _internal.viewFormatCount;
        PViewFormats = NativeUtils.PointerToManagedArray(_internal.pViewFormats, _internal.viewFormatCount);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint ViewFormatCount { get; set; }
    public Format[] PViewFormats { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageFormatListCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageFormatListCreateInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ViewFormatCount != default)
        {
            _internal.viewFormatCount = ViewFormatCount;
        }
        _pViewFormats.Dispose();
        if (PViewFormats != null)
        {
            _pViewFormats = new NativeStructArray<AdamantiumVulkan.Core.Format>(PViewFormats);
            _internal.pViewFormats = _pViewFormats.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pViewFormats.Dispose();
    }


    public static implicit operator ImageFormatListCreateInfo(AdamantiumVulkan.Core.Interop.VkImageFormatListCreateInfo i)
    {
        return new ImageFormatListCreateInfo(i);
    }

}



