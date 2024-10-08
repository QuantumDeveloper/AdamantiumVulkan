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

public unsafe partial class ImageDrmFormatModifierExplicitCreateInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkSubresourceLayout> _pPlaneLayouts;

    public ImageDrmFormatModifierExplicitCreateInfoEXT()
    {
    }

    public ImageDrmFormatModifierExplicitCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierExplicitCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        DrmFormatModifier = _internal.drmFormatModifier;
        DrmFormatModifierPlaneCount = _internal.drmFormatModifierPlaneCount;
        PlaneLayouts = new SubresourceLayout(*_internal.pPlaneLayouts);
        NativeUtils.Free(_internal.pPlaneLayouts);
    }

    public StructureType SType => StructureType.ImageDrmFormatModifierExplicitCreateInfoExt;
    public void* PNext { get; set; }
    public ulong DrmFormatModifier { get; set; }
    public uint DrmFormatModifierPlaneCount { get; set; }
    public SubresourceLayout PlaneLayouts { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierExplicitCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierExplicitCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DrmFormatModifier != default)
        {
            _internal.drmFormatModifier = DrmFormatModifier;
        }
        if (DrmFormatModifierPlaneCount != default)
        {
            _internal.drmFormatModifierPlaneCount = DrmFormatModifierPlaneCount;
        }
        _pPlaneLayouts.Dispose();
        if (PlaneLayouts != default)
        {
            var struct0 = PlaneLayouts.ToNative();
            _pPlaneLayouts = new NativeStruct<AdamantiumVulkan.Core.Interop.VkSubresourceLayout>(struct0);
            _internal.pPlaneLayouts = _pPlaneLayouts.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pPlaneLayouts.Dispose();
    }


    public static implicit operator ImageDrmFormatModifierExplicitCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierExplicitCreateInfoEXT i)
    {
        return new ImageDrmFormatModifierExplicitCreateInfoEXT(i);
    }

}



