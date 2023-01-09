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

public unsafe partial class DrmFormatModifierPropertiesList2EXT : QBDisposableObject
{
    private NativeStruct<VkDrmFormatModifierProperties2EXT> pDrmFormatModifierProperties;

    public DrmFormatModifierPropertiesList2EXT()
    {
    }

    public DrmFormatModifierPropertiesList2EXT(AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesList2EXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DrmFormatModifierCount = _internal.drmFormatModifierCount;
        PDrmFormatModifierProperties = new DrmFormatModifierProperties2EXT(*_internal.pDrmFormatModifierProperties);
        NativeUtils.Free(_internal.pDrmFormatModifierProperties);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint DrmFormatModifierCount { get; set; }
    public DrmFormatModifierProperties2EXT PDrmFormatModifierProperties { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesList2EXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesList2EXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.drmFormatModifierCount = DrmFormatModifierCount;
        pDrmFormatModifierProperties.Dispose();
        if (PDrmFormatModifierProperties != null)
        {
            var struct0 = PDrmFormatModifierProperties.ToNative();
            pDrmFormatModifierProperties = new NativeStruct<VkDrmFormatModifierProperties2EXT>(struct0);
            _internal.pDrmFormatModifierProperties = pDrmFormatModifierProperties.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pDrmFormatModifierProperties.Dispose();
    }


    public static implicit operator DrmFormatModifierPropertiesList2EXT(AdamantiumVulkan.Core.Interop.VkDrmFormatModifierPropertiesList2EXT d)
    {
        return new DrmFormatModifierPropertiesList2EXT(d);
    }

}


