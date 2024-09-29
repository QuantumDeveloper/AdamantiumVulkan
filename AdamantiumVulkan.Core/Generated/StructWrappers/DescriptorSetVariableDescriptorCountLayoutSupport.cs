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

public unsafe partial class DescriptorSetVariableDescriptorCountLayoutSupport : QBDisposableObject
{
    public DescriptorSetVariableDescriptorCountLayoutSupport()
    {
    }

    public DescriptorSetVariableDescriptorCountLayoutSupport(AdamantiumVulkan.Core.Interop.VkDescriptorSetVariableDescriptorCountLayoutSupport _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxVariableDescriptorCount = _internal.maxVariableDescriptorCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxVariableDescriptorCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorSetVariableDescriptorCountLayoutSupport ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorSetVariableDescriptorCountLayoutSupport();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxVariableDescriptorCount != default)
        {
            _internal.maxVariableDescriptorCount = MaxVariableDescriptorCount;
        }
        return _internal;
    }

    public static implicit operator DescriptorSetVariableDescriptorCountLayoutSupport(AdamantiumVulkan.Core.Interop.VkDescriptorSetVariableDescriptorCountLayoutSupport d)
    {
        return new DescriptorSetVariableDescriptorCountLayoutSupport(d);
    }

}



