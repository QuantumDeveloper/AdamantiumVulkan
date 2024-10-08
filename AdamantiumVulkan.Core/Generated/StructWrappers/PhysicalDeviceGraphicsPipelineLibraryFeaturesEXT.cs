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

public unsafe partial class PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT()
    {
    }

    public PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        GraphicsPipelineLibrary = _internal.graphicsPipelineLibrary;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 GraphicsPipelineLibrary { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (GraphicsPipelineLibrary != (uint)default)
        {
            _internal.graphicsPipelineLibrary = GraphicsPipelineLibrary;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT p)
    {
        return new PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT(p);
    }

}



