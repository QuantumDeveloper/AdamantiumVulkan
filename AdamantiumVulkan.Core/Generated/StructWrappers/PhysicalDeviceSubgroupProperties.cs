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

public unsafe partial class PhysicalDeviceSubgroupProperties : QBDisposableObject
{
    public PhysicalDeviceSubgroupProperties()
    {
    }

    public PhysicalDeviceSubgroupProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupProperties _internal)
    {
        PNext = _internal.pNext;
        SubgroupSize = _internal.subgroupSize;
        SupportedStages = _internal.supportedStages;
        SupportedOperations = _internal.supportedOperations;
        QuadOperationsInAllStages = _internal.quadOperationsInAllStages;
    }

    public StructureType SType => StructureType.PhysicalDeviceSubgroupProperties;
    public void* PNext { get; set; }
    public uint SubgroupSize { get; set; }
    public VkShaderStageFlags SupportedStages { get; set; }
    public VkSubgroupFeatureFlags SupportedOperations { get; set; }
    public VkBool32 QuadOperationsInAllStages { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupProperties();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SubgroupSize != default)
        {
            _internal.subgroupSize = SubgroupSize;
        }
        if (SupportedStages != (uint)default)
        {
            _internal.supportedStages = SupportedStages;
        }
        if (SupportedOperations != (uint)default)
        {
            _internal.supportedOperations = SupportedOperations;
        }
        if (QuadOperationsInAllStages != (uint)default)
        {
            _internal.quadOperationsInAllStages = QuadOperationsInAllStages;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceSubgroupProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSubgroupProperties p)
    {
        return new PhysicalDeviceSubgroupProperties(p);
    }

}



