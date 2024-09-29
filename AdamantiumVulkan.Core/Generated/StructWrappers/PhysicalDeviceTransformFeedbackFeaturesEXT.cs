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

public unsafe partial class PhysicalDeviceTransformFeedbackFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceTransformFeedbackFeaturesEXT()
    {
    }

    public PhysicalDeviceTransformFeedbackFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackFeaturesEXT _internal)
    {
        PNext = _internal.pNext;
        TransformFeedback = _internal.transformFeedback;
        GeometryStreams = _internal.geometryStreams;
    }

    public StructureType SType => StructureType.PhysicalDeviceTransformFeedbackFeaturesExt;
    public void* PNext { get; set; }
    public VkBool32 TransformFeedback { get; set; }
    public VkBool32 GeometryStreams { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (TransformFeedback != (uint)default)
        {
            _internal.transformFeedback = TransformFeedback;
        }
        if (GeometryStreams != (uint)default)
        {
            _internal.geometryStreams = GeometryStreams;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceTransformFeedbackFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackFeaturesEXT p)
    {
        return new PhysicalDeviceTransformFeedbackFeaturesEXT(p);
    }

}



