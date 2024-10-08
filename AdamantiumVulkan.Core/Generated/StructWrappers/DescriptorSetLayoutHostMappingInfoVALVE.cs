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

public unsafe partial class DescriptorSetLayoutHostMappingInfoVALVE : QBDisposableObject
{
    public DescriptorSetLayoutHostMappingInfoVALVE()
    {
    }

    public DescriptorSetLayoutHostMappingInfoVALVE(AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutHostMappingInfoVALVE _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DescriptorOffset = _internal.descriptorOffset;
        DescriptorSize = _internal.descriptorSize;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ulong DescriptorOffset { get; set; }
    public uint DescriptorSize { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutHostMappingInfoVALVE ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutHostMappingInfoVALVE();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (DescriptorOffset != default)
        {
            _internal.descriptorOffset = DescriptorOffset;
        }
        if (DescriptorSize != default)
        {
            _internal.descriptorSize = DescriptorSize;
        }
        return _internal;
    }

    public static implicit operator DescriptorSetLayoutHostMappingInfoVALVE(AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutHostMappingInfoVALVE d)
    {
        return new DescriptorSetLayoutHostMappingInfoVALVE(d);
    }

}



