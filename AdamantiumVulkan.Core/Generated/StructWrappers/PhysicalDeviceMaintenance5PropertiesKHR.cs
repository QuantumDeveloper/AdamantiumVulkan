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

public unsafe partial class PhysicalDeviceMaintenance5PropertiesKHR : QBDisposableObject
{
    public PhysicalDeviceMaintenance5PropertiesKHR()
    {
    }

    public PhysicalDeviceMaintenance5PropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMaintenance5PropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        EarlyFragmentMultisampleCoverageAfterSampleCounting = _internal.earlyFragmentMultisampleCoverageAfterSampleCounting;
        EarlyFragmentSampleMaskTestBeforeSampleCounting = _internal.earlyFragmentSampleMaskTestBeforeSampleCounting;
        DepthStencilSwizzleOneSupport = _internal.depthStencilSwizzleOneSupport;
        PolygonModePointSize = _internal.polygonModePointSize;
        NonStrictSinglePixelWideLinesUseParallelogram = _internal.nonStrictSinglePixelWideLinesUseParallelogram;
        NonStrictWideLinesUseParallelogram = _internal.nonStrictWideLinesUseParallelogram;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 EarlyFragmentMultisampleCoverageAfterSampleCounting { get; set; }
    public VkBool32 EarlyFragmentSampleMaskTestBeforeSampleCounting { get; set; }
    public VkBool32 DepthStencilSwizzleOneSupport { get; set; }
    public VkBool32 PolygonModePointSize { get; set; }
    public VkBool32 NonStrictSinglePixelWideLinesUseParallelogram { get; set; }
    public VkBool32 NonStrictWideLinesUseParallelogram { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMaintenance5PropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMaintenance5PropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (EarlyFragmentMultisampleCoverageAfterSampleCounting != (uint)default)
        {
            _internal.earlyFragmentMultisampleCoverageAfterSampleCounting = EarlyFragmentMultisampleCoverageAfterSampleCounting;
        }
        if (EarlyFragmentSampleMaskTestBeforeSampleCounting != (uint)default)
        {
            _internal.earlyFragmentSampleMaskTestBeforeSampleCounting = EarlyFragmentSampleMaskTestBeforeSampleCounting;
        }
        if (DepthStencilSwizzleOneSupport != (uint)default)
        {
            _internal.depthStencilSwizzleOneSupport = DepthStencilSwizzleOneSupport;
        }
        if (PolygonModePointSize != (uint)default)
        {
            _internal.polygonModePointSize = PolygonModePointSize;
        }
        if (NonStrictSinglePixelWideLinesUseParallelogram != (uint)default)
        {
            _internal.nonStrictSinglePixelWideLinesUseParallelogram = NonStrictSinglePixelWideLinesUseParallelogram;
        }
        if (NonStrictWideLinesUseParallelogram != (uint)default)
        {
            _internal.nonStrictWideLinesUseParallelogram = NonStrictWideLinesUseParallelogram;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMaintenance5PropertiesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMaintenance5PropertiesKHR p)
    {
        return new PhysicalDeviceMaintenance5PropertiesKHR(p);
    }

}


