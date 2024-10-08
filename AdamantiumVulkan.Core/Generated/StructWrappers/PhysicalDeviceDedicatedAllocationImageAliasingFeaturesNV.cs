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

public unsafe partial class PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV()
    {
    }

    public PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV _internal)
    {
        PNext = _internal.pNext;
        DedicatedAllocationImageAliasing = _internal.dedicatedAllocationImageAliasing;
    }

    public StructureType SType => StructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv;
    public void* PNext { get; set; }
    public VkBool32 DedicatedAllocationImageAliasing { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DedicatedAllocationImageAliasing != (uint)default)
        {
            _internal.dedicatedAllocationImageAliasing = DedicatedAllocationImageAliasing;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV p)
    {
        return new PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV(p);
    }

}



