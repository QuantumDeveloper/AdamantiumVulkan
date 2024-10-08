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

public unsafe partial class AllocationCallbacks : QBDisposableObject
{
    public AllocationCallbacks()
    {
    }

    public AllocationCallbacks(AdamantiumVulkan.Core.Interop.VkAllocationCallbacks _internal)
    {
        PUserData = _internal.pUserData;
        PfnAllocation = _internal.pfnAllocation;
        PfnReallocation = _internal.pfnReallocation;
        PfnFree = _internal.pfnFree;
        PfnInternalAllocation = _internal.pfnInternalAllocation;
        PfnInternalFree = _internal.pfnInternalFree;
    }

    public void* PUserData { get; set; }
    public delegate* unmanaged<void*, ulong, ulong, SystemAllocationScope, void> PfnAllocation { get; set; }
    public delegate* unmanaged<void*, void*, ulong, ulong, SystemAllocationScope, void> PfnReallocation { get; set; }
    public delegate* unmanaged<void*, void*, void> PfnFree { get; set; }
    public delegate* unmanaged<void*, ulong, InternalAllocationType, SystemAllocationScope, void> PfnInternalAllocation { get; set; }
    public delegate* unmanaged<void*, ulong, InternalAllocationType, SystemAllocationScope, void> PfnInternalFree { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAllocationCallbacks ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAllocationCallbacks();
        _internal.pUserData = PUserData;
        if (PfnAllocation != default)
        {
            _internal.pfnAllocation = PfnAllocation;
        }
        if (PfnReallocation != default)
        {
            _internal.pfnReallocation = PfnReallocation;
        }
        if (PfnFree != default)
        {
            _internal.pfnFree = PfnFree;
        }
        if (PfnInternalAllocation != default)
        {
            _internal.pfnInternalAllocation = PfnInternalAllocation;
        }
        if (PfnInternalFree != default)
        {
            _internal.pfnInternalFree = PfnInternalFree;
        }
        return _internal;
    }

    public static implicit operator AllocationCallbacks(AdamantiumVulkan.Core.Interop.VkAllocationCallbacks a)
    {
        return new AllocationCallbacks(a);
    }

}



