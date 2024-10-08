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

public unsafe partial class DepthBiasRepresentationInfoEXT : QBDisposableObject
{
    public DepthBiasRepresentationInfoEXT()
    {
    }

    public DepthBiasRepresentationInfoEXT(AdamantiumVulkan.Core.Interop.VkDepthBiasRepresentationInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DepthBiasRepresentation = _internal.depthBiasRepresentation;
        DepthBiasExact = _internal.depthBiasExact;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public DepthBiasRepresentationEXT DepthBiasRepresentation { get; set; }
    public VkBool32 DepthBiasExact { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDepthBiasRepresentationInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDepthBiasRepresentationInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DepthBiasRepresentation != default)
        {
            _internal.depthBiasRepresentation = DepthBiasRepresentation;
        }
        if (DepthBiasExact != (uint)default)
        {
            _internal.depthBiasExact = DepthBiasExact;
        }
        return _internal;
    }

    public static implicit operator DepthBiasRepresentationInfoEXT(AdamantiumVulkan.Core.Interop.VkDepthBiasRepresentationInfoEXT d)
    {
        return new DepthBiasRepresentationInfoEXT(d);
    }

}



