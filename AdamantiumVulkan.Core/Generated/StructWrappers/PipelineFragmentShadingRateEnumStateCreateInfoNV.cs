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

public unsafe partial class PipelineFragmentShadingRateEnumStateCreateInfoNV : QBDisposableObject
{
    public PipelineFragmentShadingRateEnumStateCreateInfoNV()
    {
    }

    public PipelineFragmentShadingRateEnumStateCreateInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateEnumStateCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShadingRateType = _internal.shadingRateType;
        ShadingRate = _internal.shadingRate;
        CombinerOps = new FragmentShadingRateCombinerOpKHR[2];
        for (int i = 0; i < 2; ++i)
        {
            CombinerOps[i] = (FragmentShadingRateCombinerOpKHR)(_internal.combinerOps[i]);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public FragmentShadingRateTypeNV ShadingRateType { get; set; }
    public FragmentShadingRateNV ShadingRate { get; set; }
    public FragmentShadingRateCombinerOpKHR[] CombinerOps { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateEnumStateCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateEnumStateCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ShadingRateType != default)
        {
            _internal.shadingRateType = ShadingRateType;
        }
        if (ShadingRate != default)
        {
            _internal.shadingRate = ShadingRate;
        }
        if (CombinerOps != default)
        {
            if (CombinerOps.Length > 2)
                throw new System.ArgumentOutOfRangeException(nameof(CombinerOps), "Array is out of bounds. Size should not be more than 2");

            for (int i = 0; i < CombinerOps.Length; ++i)
            {
                _internal.combinerOps[i] = CombinerOps[i];
            }
        }
        return _internal;
    }

    public static implicit operator PipelineFragmentShadingRateEnumStateCreateInfoNV(AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateEnumStateCreateInfoNV p)
    {
        return new PipelineFragmentShadingRateEnumStateCreateInfoNV(p);
    }

}



