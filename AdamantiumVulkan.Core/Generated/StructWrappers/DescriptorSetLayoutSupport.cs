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

public unsafe partial class DescriptorSetLayoutSupport : QBDisposableObject
{
    public DescriptorSetLayoutSupport()
    {
    }

    public DescriptorSetLayoutSupport(AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport _internal)
    {
        PNext = _internal.pNext;
        Supported = _internal.supported;
    }

    public StructureType SType => StructureType.DescriptorSetLayoutSupport;
    public void* PNext { get; set; }
    public VkBool32 Supported { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Supported != (uint)default)
        {
            _internal.supported = Supported;
        }
        return _internal;
    }

    public static implicit operator DescriptorSetLayoutSupport(AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport d)
    {
        return new DescriptorSetLayoutSupport(d);
    }

}



