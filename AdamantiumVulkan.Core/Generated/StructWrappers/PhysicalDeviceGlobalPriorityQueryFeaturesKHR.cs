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

public unsafe partial class PhysicalDeviceGlobalPriorityQueryFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceGlobalPriorityQueryFeaturesKHR()
    {
    }

    public PhysicalDeviceGlobalPriorityQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        GlobalPriorityQuery = _internal.globalPriorityQuery;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 GlobalPriorityQuery { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (GlobalPriorityQuery != (uint)default)
        {
            _internal.globalPriorityQuery = GlobalPriorityQuery;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceGlobalPriorityQueryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR p)
    {
        return new PhysicalDeviceGlobalPriorityQueryFeaturesKHR(p);
    }

}



