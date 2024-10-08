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

public unsafe partial class PerformanceCounterDescriptionKHR : QBDisposableObject
{
    public PerformanceCounterDescriptionKHR()
    {
    }

    public PerformanceCounterDescriptionKHR(AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Name = new string((sbyte*)_internal.name);
        Category = new string((sbyte*)_internal.category);
        Description = new string((sbyte*)_internal.description);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPerformanceCounterDescriptionFlagsKHR Flags { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (Name != default)
        {
            if (Name.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Name), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.name, 256, Name, false);
        }
        if (Category != default)
        {
            if (Category.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Category), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.category, 256, Category, false);
        }
        if (Description != default)
        {
            if (Description.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Description), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.description, 256, Description, false);
        }
        return _internal;
    }

    public static implicit operator PerformanceCounterDescriptionKHR(AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR p)
    {
        return new PerformanceCounterDescriptionKHR(p);
    }

}



