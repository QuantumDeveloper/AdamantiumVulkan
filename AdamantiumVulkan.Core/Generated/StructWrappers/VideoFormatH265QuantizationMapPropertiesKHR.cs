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

public unsafe partial class VideoFormatH265QuantizationMapPropertiesKHR : QBDisposableObject
{
    public VideoFormatH265QuantizationMapPropertiesKHR()
    {
    }

    public VideoFormatH265QuantizationMapPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoFormatH265QuantizationMapPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CompatibleCtbSizes = _internal.compatibleCtbSizes;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeH265CtbSizeFlagsKHR CompatibleCtbSizes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoFormatH265QuantizationMapPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoFormatH265QuantizationMapPropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (CompatibleCtbSizes != (uint)default)
        {
            _internal.compatibleCtbSizes = CompatibleCtbSizes;
        }
        return _internal;
    }

    public static implicit operator VideoFormatH265QuantizationMapPropertiesKHR(AdamantiumVulkan.Core.Interop.VkVideoFormatH265QuantizationMapPropertiesKHR v)
    {
        return new VideoFormatH265QuantizationMapPropertiesKHR(v);
    }

}



