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

public unsafe partial class DedicatedAllocationBufferCreateInfoNV : QBDisposableObject
{
    public DedicatedAllocationBufferCreateInfoNV()
    {
    }

    public DedicatedAllocationBufferCreateInfoNV(AdamantiumVulkan.Core.Interop.VkDedicatedAllocationBufferCreateInfoNV _internal)
    {
        PNext = _internal.pNext;
        DedicatedAllocation = _internal.dedicatedAllocation;
    }

    public StructureType SType => StructureType.DedicatedAllocationBufferCreateInfoNv;
    public void* PNext { get; set; }
    public VkBool32 DedicatedAllocation { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDedicatedAllocationBufferCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDedicatedAllocationBufferCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DedicatedAllocation != (uint)default)
        {
            _internal.dedicatedAllocation = DedicatedAllocation;
        }
        return _internal;
    }

    public static implicit operator DedicatedAllocationBufferCreateInfoNV(AdamantiumVulkan.Core.Interop.VkDedicatedAllocationBufferCreateInfoNV d)
    {
        return new DedicatedAllocationBufferCreateInfoNV(d);
    }

}



