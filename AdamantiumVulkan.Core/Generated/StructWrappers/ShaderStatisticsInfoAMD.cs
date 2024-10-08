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

public unsafe partial class ShaderStatisticsInfoAMD : QBDisposableObject
{
    public ShaderStatisticsInfoAMD()
    {
    }

    public ShaderStatisticsInfoAMD(AdamantiumVulkan.Core.Interop.VkShaderStatisticsInfoAMD _internal)
    {
        ShaderStageMask = _internal.shaderStageMask;
        ResourceUsage = new ShaderResourceUsageAMD(_internal.resourceUsage);
        NumPhysicalVgprs = _internal.numPhysicalVgprs;
        NumPhysicalSgprs = _internal.numPhysicalSgprs;
        NumAvailableVgprs = _internal.numAvailableVgprs;
        NumAvailableSgprs = _internal.numAvailableSgprs;
        ComputeWorkGroupSize = NativeUtils.PointerToManagedArray(_internal.computeWorkGroupSize, 3);
    }

    public VkShaderStageFlags ShaderStageMask { get; set; }
    public ShaderResourceUsageAMD ResourceUsage { get; set; }
    public uint NumPhysicalVgprs { get; set; }
    public uint NumPhysicalSgprs { get; set; }
    public uint NumAvailableVgprs { get; set; }
    public uint NumAvailableSgprs { get; set; }
    public uint[] ComputeWorkGroupSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkShaderStatisticsInfoAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkShaderStatisticsInfoAMD();
        if (ShaderStageMask != (uint)default)
        {
            _internal.shaderStageMask = ShaderStageMask;
        }
        if (ResourceUsage != default)
        {
            _internal.resourceUsage = ResourceUsage.ToNative();
        }
        if (NumPhysicalVgprs != default)
        {
            _internal.numPhysicalVgprs = NumPhysicalVgprs;
        }
        if (NumPhysicalSgprs != default)
        {
            _internal.numPhysicalSgprs = NumPhysicalSgprs;
        }
        if (NumAvailableVgprs != default)
        {
            _internal.numAvailableVgprs = NumAvailableVgprs;
        }
        if (NumAvailableSgprs != default)
        {
            _internal.numAvailableSgprs = NumAvailableSgprs;
        }
        if (ComputeWorkGroupSize != default)
        {
            if (ComputeWorkGroupSize.Length > 3)
                throw new System.ArgumentOutOfRangeException(nameof(ComputeWorkGroupSize), "Array is out of bounds. Size should not be more than 3");

            NativeUtils.PrimitiveToFixedArray(_internal.computeWorkGroupSize, 3, ComputeWorkGroupSize);
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        ResourceUsage?.Dispose();
    }


    public static implicit operator ShaderStatisticsInfoAMD(AdamantiumVulkan.Core.Interop.VkShaderStatisticsInfoAMD s)
    {
        return new ShaderStatisticsInfoAMD(s);
    }

}



