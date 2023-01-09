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

public unsafe partial class LayerProperties
{
    public LayerProperties()
    {
    }

    public LayerProperties(AdamantiumVulkan.Core.Interop.VkLayerProperties _internal)
    {
        LayerName = new string((sbyte*)_internal.layerName);
        SpecVersion = _internal.specVersion;
        ImplementationVersion = _internal.implementationVersion;
        Description = new string((sbyte*)_internal.description);
    }

    public string LayerName { get; set; }
    public uint SpecVersion { get; set; }
    public uint ImplementationVersion { get; set; }
    public string Description { get; set; }

    public AdamantiumVulkan.Core.Interop.VkLayerProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkLayerProperties();
        if(LayerName != null)
        {
            if (LayerName.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(LayerName), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.layerName, 256, LayerName, false);
        }
        _internal.specVersion = SpecVersion;
        _internal.implementationVersion = ImplementationVersion;
        if(Description != null)
        {
            if (Description.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Description), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.description, 256, Description, false);
        }
        return _internal;
    }

    public static implicit operator LayerProperties(AdamantiumVulkan.Core.Interop.VkLayerProperties l)
    {
        return new LayerProperties(l);
    }

}



