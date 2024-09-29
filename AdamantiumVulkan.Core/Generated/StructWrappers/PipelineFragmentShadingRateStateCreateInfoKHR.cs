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

public unsafe partial class PipelineFragmentShadingRateStateCreateInfoKHR : QBDisposableObject
{
    public PipelineFragmentShadingRateStateCreateInfoKHR()
    {
    }

    public PipelineFragmentShadingRateStateCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateStateCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FragmentSize = new Extent2D(_internal.fragmentSize);
        CombinerOps = new FragmentShadingRateCombinerOpKHR[2];
        for (int i = 0; i < 2; ++i)
        {
            CombinerOps[i] = (FragmentShadingRateCombinerOpKHR)(_internal.combinerOps[i]);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Extent2D FragmentSize { get; set; }
    public FragmentShadingRateCombinerOpKHR[] CombinerOps { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateStateCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateStateCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FragmentSize != default)
        {
            _internal.fragmentSize = FragmentSize.ToNative();
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

    protected override void UnmanagedDisposeOverride()
    {
        FragmentSize?.Dispose();
    }


    public static implicit operator PipelineFragmentShadingRateStateCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkPipelineFragmentShadingRateStateCreateInfoKHR p)
    {
        return new PipelineFragmentShadingRateStateCreateInfoKHR(p);
    }

}



