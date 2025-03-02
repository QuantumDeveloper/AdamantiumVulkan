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

public unsafe partial class PhysicalDevicePipelineBinaryFeaturesKHR : QBDisposableObject
{
    public PhysicalDevicePipelineBinaryFeaturesKHR()
    {
    }

    public PhysicalDevicePipelineBinaryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineBinaryFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineBinaries = _internal.pipelineBinaries;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PipelineBinaries { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineBinaryFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineBinaryFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PipelineBinaries != (uint)default)
        {
            _internal.pipelineBinaries = PipelineBinaries;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePipelineBinaryFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineBinaryFeaturesKHR p)
    {
        return new PhysicalDevicePipelineBinaryFeaturesKHR(p);
    }

}



