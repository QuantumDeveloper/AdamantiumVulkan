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

public unsafe partial class PhysicalDeviceTimelineSemaphoreFeatures : QBDisposableObject
{
    public PhysicalDeviceTimelineSemaphoreFeatures()
    {
    }

    public PhysicalDeviceTimelineSemaphoreFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTimelineSemaphoreFeatures _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        TimelineSemaphore = _internal.timelineSemaphore;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 TimelineSemaphore { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTimelineSemaphoreFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTimelineSemaphoreFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (TimelineSemaphore != (uint)default)
        {
            _internal.timelineSemaphore = TimelineSemaphore;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceTimelineSemaphoreFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTimelineSemaphoreFeatures p)
    {
        return new PhysicalDeviceTimelineSemaphoreFeatures(p);
    }

}



