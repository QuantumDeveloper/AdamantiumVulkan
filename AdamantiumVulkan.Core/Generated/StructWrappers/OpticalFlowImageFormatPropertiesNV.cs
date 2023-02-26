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

public unsafe partial class OpticalFlowImageFormatPropertiesNV : QBDisposableObject
{
    public OpticalFlowImageFormatPropertiesNV()
    {
    }

    public OpticalFlowImageFormatPropertiesNV(AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Format = _internal.format;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Format Format { get; set; }

    public AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.format = Format;
        return _internal;
    }

    public static implicit operator OpticalFlowImageFormatPropertiesNV(AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV o)
    {
        return new OpticalFlowImageFormatPropertiesNV(o);
    }

}



