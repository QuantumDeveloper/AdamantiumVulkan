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

public unsafe partial class PhysicalDeviceMemoryBudgetPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceMemoryBudgetPropertiesEXT()
    {
    }

    public PhysicalDeviceMemoryBudgetPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryBudgetPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        HeapBudget = NativeUtils.PointerToManagedArray(_internal.heapBudget, 16);
        HeapUsage = NativeUtils.PointerToManagedArray(_internal.heapUsage, 16);
    }

    public StructureType SType => StructureType.PhysicalDeviceMemoryBudgetPropertiesExt;
    public void* PNext { get; set; }
    public ulong[] HeapBudget { get; set; }
    public ulong[] HeapUsage { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryBudgetPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryBudgetPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if(HeapBudget != null)
        {
            if (HeapBudget.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(HeapBudget), "Array is out of bounds. Size should not be more than 16");

            NativeUtils.PrimitiveToFixedArray(_internal.heapBudget, 16, HeapBudget);
        }
        if(HeapUsage != null)
        {
            if (HeapUsage.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(HeapUsage), "Array is out of bounds. Size should not be more than 16");

            NativeUtils.PrimitiveToFixedArray(_internal.heapUsage, 16, HeapUsage);
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMemoryBudgetPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMemoryBudgetPropertiesEXT p)
    {
        return new PhysicalDeviceMemoryBudgetPropertiesEXT(p);
    }

}


