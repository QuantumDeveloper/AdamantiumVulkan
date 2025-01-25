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

public unsafe partial class PhysicalDeviceVideoEncodeAV1FeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceVideoEncodeAV1FeaturesKHR()
    {
    }

    public PhysicalDeviceVideoEncodeAV1FeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoEncodeAV1FeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VideoEncodeAV1 = _internal.videoEncodeAV1;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 VideoEncodeAV1 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoEncodeAV1FeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoEncodeAV1FeaturesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (VideoEncodeAV1 != (uint)default)
        {
            _internal.videoEncodeAV1 = VideoEncodeAV1;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceVideoEncodeAV1FeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoEncodeAV1FeaturesKHR p)
    {
        return new PhysicalDeviceVideoEncodeAV1FeaturesKHR(p);
    }

}



