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

public unsafe partial class PhysicalDeviceFragmentShadingRateFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceFragmentShadingRateFeaturesKHR()
    {
    }

    public PhysicalDeviceFragmentShadingRateFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PipelineFragmentShadingRate = _internal.pipelineFragmentShadingRate;
        PrimitiveFragmentShadingRate = _internal.primitiveFragmentShadingRate;
        AttachmentFragmentShadingRate = _internal.attachmentFragmentShadingRate;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PipelineFragmentShadingRate { get; set; }
    public VkBool32 PrimitiveFragmentShadingRate { get; set; }
    public VkBool32 AttachmentFragmentShadingRate { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateFeaturesKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.pipelineFragmentShadingRate = PipelineFragmentShadingRate;
        _internal.primitiveFragmentShadingRate = PrimitiveFragmentShadingRate;
        _internal.attachmentFragmentShadingRate = AttachmentFragmentShadingRate;
        return _internal;
    }

    public static implicit operator PhysicalDeviceFragmentShadingRateFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFragmentShadingRateFeaturesKHR p)
    {
        return new PhysicalDeviceFragmentShadingRateFeaturesKHR(p);
    }

}



