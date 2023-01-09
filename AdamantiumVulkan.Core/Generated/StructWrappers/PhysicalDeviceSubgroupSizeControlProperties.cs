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

public unsafe partial class PhysicalDeviceSubgroupSizeControlProperties : QBDisposableObject
{
    public PhysicalDeviceSubgroupSizeControlProperties()
    {
    }

    public PhysicalDeviceSubgroupSizeControlProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupSizeControlProperties _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MinSubgroupSize = _internal.minSubgroupSize;
        MaxSubgroupSize = _internal.maxSubgroupSize;
        MaxComputeWorkgroupSubgroups = _internal.maxComputeWorkgroupSubgroups;
        RequiredSubgroupSizeStages = _internal.requiredSubgroupSizeStages;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MinSubgroupSize { get; set; }
    public uint MaxSubgroupSize { get; set; }
    public uint MaxComputeWorkgroupSubgroups { get; set; }
    public VkShaderStageFlags RequiredSubgroupSizeStages { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupSizeControlProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupSizeControlProperties();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.minSubgroupSize = MinSubgroupSize;
        _internal.maxSubgroupSize = MaxSubgroupSize;
        _internal.maxComputeWorkgroupSubgroups = MaxComputeWorkgroupSubgroups;
        _internal.requiredSubgroupSizeStages = RequiredSubgroupSizeStages;
        return _internal;
    }

    public static implicit operator PhysicalDeviceSubgroupSizeControlProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupSizeControlProperties p)
    {
        return new PhysicalDeviceSubgroupSizeControlProperties(p);
    }

}


