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

public unsafe partial class PhysicalDeviceSynchronization2Features : QBDisposableObject
{
    public PhysicalDeviceSynchronization2Features()
    {
    }

    public PhysicalDeviceSynchronization2Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSynchronization2Features _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Synchronization2 = _internal.synchronization2;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 Synchronization2 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSynchronization2Features ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSynchronization2Features();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Synchronization2 != (uint)default)
        {
            _internal.synchronization2 = Synchronization2;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceSynchronization2Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSynchronization2Features p)
    {
        return new PhysicalDeviceSynchronization2Features(p);
    }

}



