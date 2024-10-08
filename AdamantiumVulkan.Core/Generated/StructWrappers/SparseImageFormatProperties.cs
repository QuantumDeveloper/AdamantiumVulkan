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

public unsafe partial class SparseImageFormatProperties : QBDisposableObject
{
    public SparseImageFormatProperties()
    {
    }

    public SparseImageFormatProperties(AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties _internal)
    {
        AspectMask = _internal.aspectMask;
        ImageGranularity = new Extent3D(_internal.imageGranularity);
        Flags = _internal.flags;
    }

    public VkImageAspectFlags AspectMask { get; set; }
    public Extent3D ImageGranularity { get; set; }
    public VkSparseImageFormatFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties();
        if (AspectMask != (uint)default)
        {
            _internal.aspectMask = AspectMask;
        }
        if (ImageGranularity != default)
        {
            _internal.imageGranularity = ImageGranularity.ToNative();
        }
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        ImageGranularity?.Dispose();
    }


    public static implicit operator SparseImageFormatProperties(AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties s)
    {
        return new SparseImageFormatProperties(s);
    }

}



