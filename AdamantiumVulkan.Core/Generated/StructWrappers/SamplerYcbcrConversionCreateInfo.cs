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

public unsafe partial class SamplerYcbcrConversionCreateInfo : QBDisposableObject
{
    public SamplerYcbcrConversionCreateInfo()
    {
    }

    public SamplerYcbcrConversionCreateInfo(AdamantiumVulkan.Core.Interop.VkSamplerYcbcrConversionCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Format = _internal.format;
        YcbcrModel = _internal.ycbcrModel;
        YcbcrRange = _internal.ycbcrRange;
        Components = new ComponentMapping(_internal.components);
        XChromaOffset = _internal.xChromaOffset;
        YChromaOffset = _internal.yChromaOffset;
        ChromaFilter = _internal.chromaFilter;
        ForceExplicitReconstruction = _internal.forceExplicitReconstruction;
    }

    public StructureType SType => StructureType.SamplerYcbcrConversionCreateInfo;
    public void* PNext { get; set; }
    public Format Format { get; set; }
    public SamplerYcbcrModelConversion YcbcrModel { get; set; }
    public SamplerYcbcrRange YcbcrRange { get; set; }
    public ComponentMapping Components { get; set; }
    public ChromaLocation XChromaOffset { get; set; }
    public ChromaLocation YChromaOffset { get; set; }
    public Filter ChromaFilter { get; set; }
    public VkBool32 ForceExplicitReconstruction { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSamplerYcbcrConversionCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSamplerYcbcrConversionCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.format = Format;
        _internal.ycbcrModel = YcbcrModel;
        _internal.ycbcrRange = YcbcrRange;
        if (Components != null)
        {
            _internal.components = Components.ToNative();
        }
        _internal.xChromaOffset = XChromaOffset;
        _internal.yChromaOffset = YChromaOffset;
        _internal.chromaFilter = ChromaFilter;
        _internal.forceExplicitReconstruction = ForceExplicitReconstruction;
        return _internal;
    }

    public static implicit operator SamplerYcbcrConversionCreateInfo(AdamantiumVulkan.Core.Interop.VkSamplerYcbcrConversionCreateInfo s)
    {
        return new SamplerYcbcrConversionCreateInfo(s);
    }

}



