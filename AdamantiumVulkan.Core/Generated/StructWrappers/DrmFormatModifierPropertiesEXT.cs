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

public unsafe partial class DrmFormatModifierPropertiesEXT : QBDisposableObject
{
    public DrmFormatModifierPropertiesEXT()
    {
    }

    public DrmFormatModifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesEXT _internal)
    {
        DrmFormatModifier = _internal.drmFormatModifier;
        DrmFormatModifierPlaneCount = _internal.drmFormatModifierPlaneCount;
        DrmFormatModifierTilingFeatures = _internal.drmFormatModifierTilingFeatures;
    }

    public ulong DrmFormatModifier { get; set; }
    public uint DrmFormatModifierPlaneCount { get; set; }
    public VkFormatFeatureFlags DrmFormatModifierTilingFeatures { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesEXT();
        if (DrmFormatModifier != default)
        {
            _internal.drmFormatModifier = DrmFormatModifier;
        }
        if (DrmFormatModifierPlaneCount != default)
        {
            _internal.drmFormatModifierPlaneCount = DrmFormatModifierPlaneCount;
        }
        if (DrmFormatModifierTilingFeatures != (uint)default)
        {
            _internal.drmFormatModifierTilingFeatures = DrmFormatModifierTilingFeatures;
        }
        return _internal;
    }

    public static implicit operator DrmFormatModifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesEXT d)
    {
        return new DrmFormatModifierPropertiesEXT(d);
    }

}



