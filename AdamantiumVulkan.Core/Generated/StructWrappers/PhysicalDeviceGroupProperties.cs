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

public unsafe partial class PhysicalDeviceGroupProperties : QBDisposableObject
{
    public PhysicalDeviceGroupProperties()
    {
    }

    public PhysicalDeviceGroupProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGroupProperties _internal)
    {
        PNext = _internal.pNext;
        PhysicalDeviceCount = _internal.physicalDeviceCount;
        PhysicalDevices = new PhysicalDevice[32];
        for (int i = 0; i < 32; ++i)
        {
            PhysicalDevices[i] = new PhysicalDevice(_internal.physicalDevices[i]);
        }
        SubsetAllocation = _internal.subsetAllocation;
    }

    public StructureType SType => StructureType.PhysicalDeviceGroupProperties;
    public void* PNext { get; set; }
    public uint PhysicalDeviceCount { get; set; }
    public PhysicalDevice[] PhysicalDevices { get; set; }
    public VkBool32 SubsetAllocation { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGroupProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGroupProperties();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PhysicalDeviceCount != default)
        {
            _internal.physicalDeviceCount = PhysicalDeviceCount;
        }
        if (PhysicalDevices != default)
        {
            if (PhysicalDevices.Length > 32)
                throw new System.ArgumentOutOfRangeException(nameof(PhysicalDevices), "Array is out of bounds. Size should not be more than 32");

            for (int i = 0; i < PhysicalDevices.Length; ++i)
            {
                _internal.physicalDevices[i] = (AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T)PhysicalDevices[i];
            }
        }
        if (SubsetAllocation != (uint)default)
        {
            _internal.subsetAllocation = SubsetAllocation;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceGroupProperties(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGroupProperties p)
    {
        return new PhysicalDeviceGroupProperties(p);
    }

}



