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

public unsafe partial class PhysicalDevicePipelineProtectedAccessFeatures : QBDisposableObject
{
    public PhysicalDevicePipelineProtectedAccessFeatures()
    {
    }

    public PhysicalDevicePipelineProtectedAccessFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineProtectedAccessFeatures _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineProtectedAccess = _internal.pipelineProtectedAccess;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PipelineProtectedAccess { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineProtectedAccessFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineProtectedAccessFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PipelineProtectedAccess != (uint)default)
        {
            _internal.pipelineProtectedAccess = PipelineProtectedAccess;
        }
        return _internal;
    }

    public static implicit operator PhysicalDevicePipelineProtectedAccessFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDevicePipelineProtectedAccessFeatures p)
    {
        return new PhysicalDevicePipelineProtectedAccessFeatures(p);
    }

}



