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

public unsafe partial class ImageDrmFormatModifierPropertiesEXT : QBDisposableObject
{
    public ImageDrmFormatModifierPropertiesEXT()
    {
    }

    public ImageDrmFormatModifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        DrmFormatModifier = _internal.drmFormatModifier;
    }

    public StructureType SType => StructureType.ImageDrmFormatModifierPropertiesExt;
    public void* PNext { get; set; }
    public ulong DrmFormatModifier { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DrmFormatModifier != default)
        {
            _internal.drmFormatModifier = DrmFormatModifier;
        }
        return _internal;
    }

    public static implicit operator ImageDrmFormatModifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkImageDrmFormatModifierPropertiesEXT i)
    {
        return new ImageDrmFormatModifierPropertiesEXT(i);
    }

}



