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

public unsafe partial class BufferOpaqueCaptureAddressCreateInfo : QBDisposableObject
{
    public BufferOpaqueCaptureAddressCreateInfo()
    {
    }

    public BufferOpaqueCaptureAddressCreateInfo(AdamantiumVulkan.Core.Interop.VkBufferOpaqueCaptureAddressCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        OpaqueCaptureAddress = _internal.opaqueCaptureAddress;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public ulong OpaqueCaptureAddress { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBufferOpaqueCaptureAddressCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBufferOpaqueCaptureAddressCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.opaqueCaptureAddress = OpaqueCaptureAddress;
        return _internal;
    }

    public static implicit operator BufferOpaqueCaptureAddressCreateInfo(AdamantiumVulkan.Core.Interop.VkBufferOpaqueCaptureAddressCreateInfo b)
    {
        return new BufferOpaqueCaptureAddressCreateInfo(b);
    }

}


