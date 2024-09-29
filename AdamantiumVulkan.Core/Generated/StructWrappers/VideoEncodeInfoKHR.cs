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

public unsafe partial class VideoEncodeInfoKHR : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkVideoReferenceSlotInfoKHR> _pSetupReferenceSlot;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkVideoReferenceSlotInfoKHR> _pReferenceSlots;

    public VideoEncodeInfoKHR()
    {
    }

    public VideoEncodeInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        DstBuffer = new Buffer(_internal.dstBuffer);
        DstBufferOffset = _internal.dstBufferOffset;
        DstBufferRange = _internal.dstBufferRange;
        SrcPictureResource = new VideoPictureResourceInfoKHR(_internal.srcPictureResource);
        PSetupReferenceSlot = new VideoReferenceSlotInfoKHR(*_internal.pSetupReferenceSlot);
        NativeUtils.Free(_internal.pSetupReferenceSlot);
        ReferenceSlotCount = _internal.referenceSlotCount;
        PReferenceSlots = new VideoReferenceSlotInfoKHR(*_internal.pReferenceSlots);
        NativeUtils.Free(_internal.pReferenceSlots);
        PrecedingExternallyEncodedBytes = _internal.precedingExternallyEncodedBytes;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEncodeFlagsKHR Flags { get; set; }
    public Buffer DstBuffer { get; set; }
    public VkDeviceSize DstBufferOffset { get; set; }
    public VkDeviceSize DstBufferRange { get; set; }
    public VideoPictureResourceInfoKHR SrcPictureResource { get; set; }
    public VideoReferenceSlotInfoKHR PSetupReferenceSlot { get; set; }
    public uint ReferenceSlotCount { get; set; }
    public VideoReferenceSlotInfoKHR PReferenceSlots { get; set; }
    public uint PrecedingExternallyEncodedBytes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (DstBuffer != default)
        {
            _internal.dstBuffer = DstBuffer;
        }
        if (DstBufferOffset != (ulong)default)
        {
            _internal.dstBufferOffset = DstBufferOffset;
        }
        if (DstBufferRange != (ulong)default)
        {
            _internal.dstBufferRange = DstBufferRange;
        }
        if (SrcPictureResource != default)
        {
            _internal.srcPictureResource = SrcPictureResource.ToNative();
        }
        _pSetupReferenceSlot.Dispose();
        if (PSetupReferenceSlot != default)
        {
            var struct0 = PSetupReferenceSlot.ToNative();
            _pSetupReferenceSlot = new NativeStruct<AdamantiumVulkan.Core.Interop.VkVideoReferenceSlotInfoKHR>(struct0);
            _internal.pSetupReferenceSlot = _pSetupReferenceSlot.Handle;
        }
        if (ReferenceSlotCount != default)
        {
            _internal.referenceSlotCount = ReferenceSlotCount;
        }
        _pReferenceSlots.Dispose();
        if (PReferenceSlots != default)
        {
            var struct1 = PReferenceSlots.ToNative();
            _pReferenceSlots = new NativeStruct<AdamantiumVulkan.Core.Interop.VkVideoReferenceSlotInfoKHR>(struct1);
            _internal.pReferenceSlots = _pReferenceSlots.Handle;
        }
        if (PrecedingExternallyEncodedBytes != default)
        {
            _internal.precedingExternallyEncodedBytes = PrecedingExternallyEncodedBytes;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pSetupReferenceSlot.Dispose();
        _pReferenceSlots.Dispose();
        SrcPictureResource?.Dispose();
    }


    public static implicit operator VideoEncodeInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeInfoKHR v)
    {
        return new VideoEncodeInfoKHR(v);
    }

}



