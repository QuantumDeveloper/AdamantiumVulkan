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

public unsafe partial class PhysicalDeviceCopyMemoryIndirectPropertiesNV : QBDisposableObject
{
    public PhysicalDeviceCopyMemoryIndirectPropertiesNV()
    {
    }

    public PhysicalDeviceCopyMemoryIndirectPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCopyMemoryIndirectPropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SupportedQueues = _internal.supportedQueues;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkQueueFlags SupportedQueues { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCopyMemoryIndirectPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCopyMemoryIndirectPropertiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.supportedQueues = SupportedQueues;
        return _internal;
    }

    public static implicit operator PhysicalDeviceCopyMemoryIndirectPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCopyMemoryIndirectPropertiesNV p)
    {
        return new PhysicalDeviceCopyMemoryIndirectPropertiesNV(p);
    }

}



