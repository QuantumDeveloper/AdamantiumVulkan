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

public unsafe partial class PhysicalDeviceExternalMemoryHostPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceExternalMemoryHostPropertiesEXT()
    {
    }

    public PhysicalDeviceExternalMemoryHostPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalMemoryHostPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        MinImportedHostPointerAlignment = _internal.minImportedHostPointerAlignment;
    }

    public StructureType SType => StructureType.PhysicalDeviceExternalMemoryHostPropertiesExt;
    public void* PNext { get; set; }
    public VkDeviceSize MinImportedHostPointerAlignment { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalMemoryHostPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalMemoryHostPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.minImportedHostPointerAlignment = MinImportedHostPointerAlignment;
        return _internal;
    }

    public static implicit operator PhysicalDeviceExternalMemoryHostPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalMemoryHostPropertiesEXT p)
    {
        return new PhysicalDeviceExternalMemoryHostPropertiesEXT(p);
    }

}



