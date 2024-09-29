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

public unsafe partial class PhysicalDeviceVertexAttributeDivisorFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceVertexAttributeDivisorFeaturesKHR()
    {
    }

    public PhysicalDeviceVertexAttributeDivisorFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VertexAttributeInstanceRateDivisor = _internal.vertexAttributeInstanceRateDivisor;
        VertexAttributeInstanceRateZeroDivisor = _internal.vertexAttributeInstanceRateZeroDivisor;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 VertexAttributeInstanceRateDivisor { get; set; }
    public VkBool32 VertexAttributeInstanceRateZeroDivisor { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (VertexAttributeInstanceRateDivisor != (uint)default)
        {
            _internal.vertexAttributeInstanceRateDivisor = VertexAttributeInstanceRateDivisor;
        }
        if (VertexAttributeInstanceRateZeroDivisor != (uint)default)
        {
            _internal.vertexAttributeInstanceRateZeroDivisor = VertexAttributeInstanceRateZeroDivisor;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceVertexAttributeDivisorFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR p)
    {
        return new PhysicalDeviceVertexAttributeDivisorFeaturesKHR(p);
    }

}


