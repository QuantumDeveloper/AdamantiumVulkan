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

public unsafe partial class PhysicalDeviceRayQueryFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceRayQueryFeaturesKHR()
    {
    }

    public PhysicalDeviceRayQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayQueryFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        RayQuery = _internal.rayQuery;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 RayQuery { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayQueryFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayQueryFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (RayQuery != (uint)default)
        {
            _internal.rayQuery = RayQuery;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceRayQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRayQueryFeaturesKHR p)
    {
        return new PhysicalDeviceRayQueryFeaturesKHR(p);
    }

}



