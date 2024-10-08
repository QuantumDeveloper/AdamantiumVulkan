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

public unsafe partial class PhysicalDeviceCubicWeightsFeaturesQCOM : QBDisposableObject
{
    public PhysicalDeviceCubicWeightsFeaturesQCOM()
    {
    }

    public PhysicalDeviceCubicWeightsFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicWeightsFeaturesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SelectableCubicWeights = _internal.selectableCubicWeights;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 SelectableCubicWeights { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicWeightsFeaturesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicWeightsFeaturesQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SelectableCubicWeights != (uint)default)
        {
            _internal.selectableCubicWeights = SelectableCubicWeights;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceCubicWeightsFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCubicWeightsFeaturesQCOM p)
    {
        return new PhysicalDeviceCubicWeightsFeaturesQCOM(p);
    }

}



