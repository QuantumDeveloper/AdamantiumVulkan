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

public unsafe partial class PhysicalDevicePerformanceQueryFeaturesKHR : QBDisposableObject
{
    public PhysicalDevicePerformanceQueryFeaturesKHR()
    {
    }

    public PhysicalDevicePerformanceQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePerformanceQueryFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PerformanceCounterQueryPools = _internal.performanceCounterQueryPools;
        PerformanceCounterMultipleQueryPools = _internal.performanceCounterMultipleQueryPools;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PerformanceCounterQueryPools { get; set; }
    public VkBool32 PerformanceCounterMultipleQueryPools { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePerformanceQueryFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePerformanceQueryFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PerformanceCounterQueryPools != (uint)default)
        {
            _internal.performanceCounterQueryPools = PerformanceCounterQueryPools;
        }
        if (PerformanceCounterMultipleQueryPools != (uint)default)
        {
            _internal.performanceCounterMultipleQueryPools = PerformanceCounterMultipleQueryPools;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePerformanceQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePerformanceQueryFeaturesKHR p)
    {
        return new PhysicalDevicePerformanceQueryFeaturesKHR(p);
    }

}



