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

public unsafe partial class PhysicalDeviceCubicClampFeaturesQCOM : QBDisposableObject
{
    public PhysicalDeviceCubicClampFeaturesQCOM()
    {
    }

    public PhysicalDeviceCubicClampFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicClampFeaturesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CubicRangeClamp = _internal.cubicRangeClamp;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 CubicRangeClamp { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicClampFeaturesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicClampFeaturesQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (CubicRangeClamp != (uint)default)
        {
            _internal.cubicRangeClamp = CubicRangeClamp;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceCubicClampFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicClampFeaturesQCOM p)
    {
        return new PhysicalDeviceCubicClampFeaturesQCOM(p);
    }

}



