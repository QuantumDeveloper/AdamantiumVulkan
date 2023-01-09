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

public unsafe partial class PhysicalDeviceProvokingVertexPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceProvokingVertexPropertiesEXT()
    {
    }

    public PhysicalDeviceProvokingVertexPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceProvokingVertexPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ProvokingVertexModePerPipeline = _internal.provokingVertexModePerPipeline;
        TransformFeedbackPreservesTriangleFanProvokingVertex = _internal.transformFeedbackPreservesTriangleFanProvokingVertex;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 ProvokingVertexModePerPipeline { get; set; }
    public VkBool32 TransformFeedbackPreservesTriangleFanProvokingVertex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceProvokingVertexPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceProvokingVertexPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.provokingVertexModePerPipeline = ProvokingVertexModePerPipeline;
        _internal.transformFeedbackPreservesTriangleFanProvokingVertex = TransformFeedbackPreservesTriangleFanProvokingVertex;
        return _internal;
    }

    public static implicit operator PhysicalDeviceProvokingVertexPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceProvokingVertexPropertiesEXT p)
    {
        return new PhysicalDeviceProvokingVertexPropertiesEXT(p);
    }

}


