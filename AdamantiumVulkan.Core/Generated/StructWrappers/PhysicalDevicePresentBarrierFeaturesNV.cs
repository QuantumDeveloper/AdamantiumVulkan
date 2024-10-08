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

public unsafe partial class PhysicalDevicePresentBarrierFeaturesNV : QBDisposableObject
{
    public PhysicalDevicePresentBarrierFeaturesNV()
    {
    }

    public PhysicalDevicePresentBarrierFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePresentBarrierFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PresentBarrier = _internal.presentBarrier;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PresentBarrier { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePresentBarrierFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePresentBarrierFeaturesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PresentBarrier != (uint)default)
        {
            _internal.presentBarrier = PresentBarrier;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePresentBarrierFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePresentBarrierFeaturesNV p)
    {
        return new PhysicalDevicePresentBarrierFeaturesNV(p);
    }

}



