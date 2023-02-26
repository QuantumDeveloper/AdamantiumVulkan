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

public unsafe partial class DescriptorSetAllocateInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorSetLayout_T> _pSetLayouts;

    public DescriptorSetAllocateInfo()
    {
    }

    public DescriptorSetAllocateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo _internal)
    {
        PNext = _internal.pNext;
        DescriptorPool = new DescriptorPool(_internal.descriptorPool);
        DescriptorSetCount = _internal.descriptorSetCount;
        PSetLayouts = new DescriptorSetLayout[_internal.descriptorSetCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pSetLayouts, _internal.descriptorSetCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PSetLayouts[i] = new DescriptorSetLayout(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pSetLayouts);
    }

    public StructureType SType => StructureType.DescriptorSetAllocateInfo;
    public void* PNext { get; set; }
    public DescriptorPool DescriptorPool { get; set; }
    public uint DescriptorSetCount { get; set; }
    public DescriptorSetLayout[] PSetLayouts { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.descriptorPool = DescriptorPool;
        _internal.descriptorSetCount = DescriptorSetCount;
        _pSetLayouts.Dispose();
        if (PSetLayouts != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkDescriptorSetLayout_T[PSetLayouts.Length];
            for (int i = 0; i < PSetLayouts.Length; ++i)
            {
                tmpArray0[i] = PSetLayouts[i];
            }
            _pSetLayouts = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorSetLayout_T>(tmpArray0);
            _internal.pSetLayouts = _pSetLayouts.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pSetLayouts.Dispose();
    }


    public static implicit operator DescriptorSetAllocateInfo(AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo d)
    {
        return new DescriptorSetAllocateInfo(d);
    }

}



