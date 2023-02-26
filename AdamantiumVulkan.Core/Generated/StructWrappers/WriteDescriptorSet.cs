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

public unsafe partial class WriteDescriptorSet : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo> _pImageInfo;

    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo> _pBufferInfo;

    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkBufferView_T> _pTexelBufferView;

    public WriteDescriptorSet()
    {
    }

    public WriteDescriptorSet(AdamantiumVulkan.Core.Interop.VkWriteDescriptorSet _internal)
    {
        PNext = _internal.pNext;
        DstSet = new DescriptorSet(_internal.dstSet);
        DstBinding = _internal.dstBinding;
        DstArrayElement = _internal.dstArrayElement;
        DescriptorCount = _internal.descriptorCount;
        DescriptorType = _internal.descriptorType;
        PImageInfo = new DescriptorImageInfo[_internal.descriptorCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pImageInfo, _internal.descriptorCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PImageInfo[i] = new DescriptorImageInfo(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pImageInfo);
        PBufferInfo = new DescriptorBufferInfo[_internal.descriptorCount];
        var nativeTmpArray1 = NativeUtils.PointerToManagedArray(_internal.pBufferInfo, _internal.descriptorCount);
        for (int i = 0; i < nativeTmpArray1.Length; ++i)
        {
            PBufferInfo[i] = new DescriptorBufferInfo(nativeTmpArray1[i]);
        }
        NativeUtils.Free(_internal.pBufferInfo);
        PTexelBufferView = new BufferView[_internal.descriptorCount];
        var nativeTmpArray2 = NativeUtils.PointerToManagedArray(_internal.pTexelBufferView, _internal.descriptorCount);
        for (int i = 0; i < nativeTmpArray2.Length; ++i)
        {
            PTexelBufferView[i] = new BufferView(nativeTmpArray2[i]);
        }
        NativeUtils.Free(_internal.pTexelBufferView);
    }

    public StructureType SType => StructureType.WriteDescriptorSet;
    public void* PNext { get; set; }
    public DescriptorSet DstSet { get; set; }
    public uint DstBinding { get; set; }
    public uint DstArrayElement { get; set; }
    public uint DescriptorCount { get; set; }
    public DescriptorType DescriptorType { get; set; }
    public DescriptorImageInfo[] PImageInfo { get; set; }
    public DescriptorBufferInfo[] PBufferInfo { get; set; }
    public BufferView[] PTexelBufferView { get; set; }

    public AdamantiumVulkan.Core.Interop.VkWriteDescriptorSet ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkWriteDescriptorSet();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.dstSet = DstSet;
        _internal.dstBinding = DstBinding;
        _internal.dstArrayElement = DstArrayElement;
        _internal.descriptorCount = DescriptorCount;
        _internal.descriptorType = DescriptorType;
        _pImageInfo.Dispose();
        if (PImageInfo != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo[PImageInfo.Length];
            for (int i = 0; i < PImageInfo.Length; ++i)
            {
                tmpArray0[i] = PImageInfo[i].ToNative();
            }
            _pImageInfo = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo>(tmpArray0);
            _internal.pImageInfo = _pImageInfo.Handle;
        }
        _pBufferInfo.Dispose();
        if (PBufferInfo != null)
        {
            var tmpArray1 = new AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo[PBufferInfo.Length];
            for (int i = 0; i < PBufferInfo.Length; ++i)
            {
                tmpArray1[i] = PBufferInfo[i].ToNative();
            }
            _pBufferInfo = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo>(tmpArray1);
            _internal.pBufferInfo = _pBufferInfo.Handle;
        }
        _pTexelBufferView.Dispose();
        if (PTexelBufferView != null)
        {
            var tmpArray2 = new AdamantiumVulkan.Core.Interop.VkBufferView_T[PTexelBufferView.Length];
            for (int i = 0; i < PTexelBufferView.Length; ++i)
            {
                tmpArray2[i] = PTexelBufferView[i];
            }
            _pTexelBufferView = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkBufferView_T>(tmpArray2);
            _internal.pTexelBufferView = _pTexelBufferView.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pImageInfo.Dispose();
        _pBufferInfo.Dispose();
        _pTexelBufferView.Dispose();
    }


    public static implicit operator WriteDescriptorSet(AdamantiumVulkan.Core.Interop.VkWriteDescriptorSet w)
    {
        return new WriteDescriptorSet(w);
    }

}



