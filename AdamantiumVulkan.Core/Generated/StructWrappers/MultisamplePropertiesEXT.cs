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

public unsafe partial class MultisamplePropertiesEXT : QBDisposableObject
{
    public MultisamplePropertiesEXT()
    {
    }

    public MultisamplePropertiesEXT(AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        MaxSampleLocationGridSize = new Extent2D(_internal.maxSampleLocationGridSize);
    }

    public StructureType SType => StructureType.MultisamplePropertiesExt;
    public void* PNext { get; set; }
    public Extent2D MaxSampleLocationGridSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxSampleLocationGridSize != default)
        {
            _internal.maxSampleLocationGridSize = MaxSampleLocationGridSize.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        MaxSampleLocationGridSize?.Dispose();
    }


    public static implicit operator MultisamplePropertiesEXT(AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT m)
    {
        return new MultisamplePropertiesEXT(m);
    }

}



