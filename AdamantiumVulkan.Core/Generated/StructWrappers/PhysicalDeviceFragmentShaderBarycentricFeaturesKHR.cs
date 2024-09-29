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

public unsafe partial class PhysicalDeviceFragmentShaderBarycentricFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceFragmentShaderBarycentricFeaturesKHR()
    {
    }

    public PhysicalDeviceFragmentShaderBarycentricFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FragmentShaderBarycentric = _internal.fragmentShaderBarycentric;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 FragmentShaderBarycentric { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FragmentShaderBarycentric != (uint)default)
        {
            _internal.fragmentShaderBarycentric = FragmentShaderBarycentric;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentShaderBarycentricFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR p)
    {
        return new PhysicalDeviceFragmentShaderBarycentricFeaturesKHR(p);
    }

}



