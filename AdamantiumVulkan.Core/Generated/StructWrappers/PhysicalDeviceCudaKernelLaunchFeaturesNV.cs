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

public unsafe partial class PhysicalDeviceCudaKernelLaunchFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceCudaKernelLaunchFeaturesNV()
    {
    }

    public PhysicalDeviceCudaKernelLaunchFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCudaKernelLaunchFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CudaKernelLaunchFeatures = _internal.cudaKernelLaunchFeatures;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 CudaKernelLaunchFeatures { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCudaKernelLaunchFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCudaKernelLaunchFeaturesNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (CudaKernelLaunchFeatures != (uint)default)
        {
            _internal.cudaKernelLaunchFeatures = CudaKernelLaunchFeatures;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceCudaKernelLaunchFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCudaKernelLaunchFeaturesNV p)
    {
        return new PhysicalDeviceCudaKernelLaunchFeaturesNV(p);
    }

}



