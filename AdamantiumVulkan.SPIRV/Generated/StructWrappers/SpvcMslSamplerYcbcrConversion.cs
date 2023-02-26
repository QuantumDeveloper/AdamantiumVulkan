// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Spirv.Cross.Interop;

namespace AdamantiumVulkan.Spirv.Cross;

public unsafe partial class SpvcMslSamplerYcbcrConversion
{
    public SpvcMslSamplerYcbcrConversion()
    {
    }

    public SpvcMslSamplerYcbcrConversion(AdamantiumVulkan.Spirv.Cross.Interop.SpvcMslSamplerYcbcrConversion _internal)
    {
        Planes = _internal.planes;
        Resolution = _internal.resolution;
        Chroma_filter = _internal.chroma_filter;
        X_chroma_offset = _internal.x_chroma_offset;
        Y_chroma_offset = _internal.y_chroma_offset;
        Swizzle = new MslComponentSwizzle[4];
        for (int i = 0; i < 4; ++i)
        {
            Swizzle[i] = (MslComponentSwizzle)(_internal.swizzle[i]);
        }
        Ycbcr_model = _internal.ycbcr_model;
        Ycbcr_range = _internal.ycbcr_range;
        Bpc = _internal.bpc;
    }

    public uint Planes { get; set; }
    public MslFormatResolution Resolution { get; set; }
    public MslSamplerFilter Chroma_filter { get; set; }
    public MslChromaLocation X_chroma_offset { get; set; }
    public MslChromaLocation Y_chroma_offset { get; set; }
    public MslComponentSwizzle[] Swizzle { get; set; }
    public MslSamplerYcbcrModelConversion Ycbcr_model { get; set; }
    public MslSamplerYcbcrRange Ycbcr_range { get; set; }
    public uint Bpc { get; set; }
    ///<summary>
    /// Initializes the constexpr sampler struct. The defaults are non-zero.
    ///</summary>
    public void MslSamplerYcbcrConversionInit()
    {
        var arg0 = NativeUtils.StructOrEnumToPointer(ToNative());
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_msl_sampler_ycbcr_conversion_init(arg0);
        NativeUtils.Free(arg0);
    }


    public AdamantiumVulkan.Spirv.Cross.Interop.SpvcMslSamplerYcbcrConversion ToNative()
    {
        var _internal = new AdamantiumVulkan.Spirv.Cross.Interop.SpvcMslSamplerYcbcrConversion();
        _internal.planes = Planes;
        _internal.resolution = Resolution;
        _internal.chroma_filter = Chroma_filter;
        _internal.x_chroma_offset = X_chroma_offset;
        _internal.y_chroma_offset = Y_chroma_offset;
        if(Swizzle != null)
        {
            if (Swizzle.Length > 4)
                throw new System.ArgumentOutOfRangeException(nameof(Swizzle), "Array is out of bounds. Size should not be more than 4");

            for (int i = 0; i < Swizzle.Length; ++i)
            {
                _internal.swizzle[i] = Swizzle[i];
            }
        }
        _internal.ycbcr_model = Ycbcr_model;
        _internal.ycbcr_range = Ycbcr_range;
        _internal.bpc = Bpc;
        return _internal;
    }

    public static implicit operator SpvcMslSamplerYcbcrConversion(AdamantiumVulkan.Spirv.Cross.Interop.SpvcMslSamplerYcbcrConversion s)
    {
        return new SpvcMslSamplerYcbcrConversion(s);
    }

}



