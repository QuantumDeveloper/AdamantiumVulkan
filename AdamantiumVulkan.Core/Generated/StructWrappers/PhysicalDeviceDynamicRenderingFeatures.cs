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

public unsafe partial class PhysicalDeviceDynamicRenderingFeatures : QBDisposableObject
{
    public PhysicalDeviceDynamicRenderingFeatures()
    {
    }

    public PhysicalDeviceDynamicRenderingFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDynamicRenderingFeatures _internal)
    {
        PNext = _internal.pNext;
        DynamicRendering = _internal.dynamicRendering;
    }

    public StructureType SType => StructureType.PhysicalDeviceDynamicRenderingFeatures;
    public void* PNext { get; set; }
    public VkBool32 DynamicRendering { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDynamicRenderingFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDynamicRenderingFeatures();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.dynamicRendering = DynamicRendering;
        return _internal;
    }

    public static implicit operator PhysicalDeviceDynamicRenderingFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDynamicRenderingFeatures p)
    {
        return new PhysicalDeviceDynamicRenderingFeatures(p);
    }

}



