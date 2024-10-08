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

public unsafe partial class DescriptorGetInfoEXT : QBDisposableObject
{
    public DescriptorGetInfoEXT()
    {
    }

    public DescriptorGetInfoEXT(AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        Data = new DescriptorDataEXT(_internal.data);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public DescriptorType Type { get; set; }
    public DescriptorDataEXT Data { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (Data != default)
        {
            _internal.data = Data.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Data?.Dispose();
    }


    public static implicit operator DescriptorGetInfoEXT(AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT d)
    {
        return new DescriptorGetInfoEXT(d);
    }

}



