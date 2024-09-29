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

public unsafe partial class PhysicalDeviceClusterCullingShaderFeaturesHUAWEI : QBDisposableObject
{
    public PhysicalDeviceClusterCullingShaderFeaturesHUAWEI()
    {
    }

    public PhysicalDeviceClusterCullingShaderFeaturesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ClustercullingShader = _internal.clustercullingShader;
        MultiviewClusterCullingShader = _internal.multiviewClusterCullingShader;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ClustercullingShader { get; set; }
    public VkBool32 MultiviewClusterCullingShader { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ClustercullingShader != (uint)default)
        {
            _internal.clustercullingShader = ClustercullingShader;
        }
        if (MultiviewClusterCullingShader != (uint)default)
        {
            _internal.multiviewClusterCullingShader = MultiviewClusterCullingShader;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceClusterCullingShaderFeaturesHUAWEI(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI p)
    {
        return new PhysicalDeviceClusterCullingShaderFeaturesHUAWEI(p);
    }

}


