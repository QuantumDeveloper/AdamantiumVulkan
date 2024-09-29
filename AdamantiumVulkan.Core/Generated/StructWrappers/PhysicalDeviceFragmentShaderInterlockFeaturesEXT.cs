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

public unsafe partial class PhysicalDeviceFragmentShaderInterlockFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceFragmentShaderInterlockFeaturesEXT()
    {
    }

    public PhysicalDeviceFragmentShaderInterlockFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        FragmentShaderSampleInterlock = _internal.fragmentShaderSampleInterlock;
        FragmentShaderPixelInterlock = _internal.fragmentShaderPixelInterlock;
        FragmentShaderShadingRateInterlock = _internal.fragmentShaderShadingRateInterlock;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 FragmentShaderSampleInterlock { get; set; }
    public VkBool32 FragmentShaderPixelInterlock { get; set; }
    public VkBool32 FragmentShaderShadingRateInterlock { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (FragmentShaderSampleInterlock != (uint)default)
        {
            _internal.fragmentShaderSampleInterlock = FragmentShaderSampleInterlock;
        }
        if (FragmentShaderPixelInterlock != (uint)default)
        {
            _internal.fragmentShaderPixelInterlock = FragmentShaderPixelInterlock;
        }
        if (FragmentShaderShadingRateInterlock != (uint)default)
        {
            _internal.fragmentShaderShadingRateInterlock = FragmentShaderShadingRateInterlock;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentShaderInterlockFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT p)
    {
        return new PhysicalDeviceFragmentShaderInterlockFeaturesEXT(p);
    }

}



