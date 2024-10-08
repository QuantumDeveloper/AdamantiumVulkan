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

public unsafe partial class PhysicalDeviceCooperativeMatrixFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceCooperativeMatrixFeaturesKHR()
    {
    }

    public PhysicalDeviceCooperativeMatrixFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCooperativeMatrixFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        CooperativeMatrix = _internal.cooperativeMatrix;
        CooperativeMatrixRobustBufferAccess = _internal.cooperativeMatrixRobustBufferAccess;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 CooperativeMatrix { get; set; }
    public VkBool32 CooperativeMatrixRobustBufferAccess { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCooperativeMatrixFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCooperativeMatrixFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (CooperativeMatrix != (uint)default)
        {
            _internal.cooperativeMatrix = CooperativeMatrix;
        }
        if (CooperativeMatrixRobustBufferAccess != (uint)default)
        {
            _internal.cooperativeMatrixRobustBufferAccess = CooperativeMatrixRobustBufferAccess;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceCooperativeMatrixFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceCooperativeMatrixFeaturesKHR p)
    {
        return new PhysicalDeviceCooperativeMatrixFeaturesKHR(p);
    }

}



