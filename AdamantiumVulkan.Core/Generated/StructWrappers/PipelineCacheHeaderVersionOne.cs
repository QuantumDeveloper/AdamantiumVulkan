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

public unsafe partial class PipelineCacheHeaderVersionOne
{
    public PipelineCacheHeaderVersionOne()
    {
    }

    public PipelineCacheHeaderVersionOne(AdamantiumVulkan.Core.Interop.VkPipelineCacheHeaderVersionOne _internal)
    {
        HeaderSize = _internal.headerSize;
        HeaderVersion = _internal.headerVersion;
        VendorID = _internal.vendorID;
        DeviceID = _internal.deviceID;
        PipelineCacheUUID = NativeUtils.PointerToManagedArray(_internal.pipelineCacheUUID, 16);
    }

    public uint HeaderSize { get; set; }
    public PipelineCacheHeaderVersion HeaderVersion { get; set; }
    public uint VendorID { get; set; }
    public uint DeviceID { get; set; }
    public byte[] PipelineCacheUUID { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineCacheHeaderVersionOne ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineCacheHeaderVersionOne();
        _internal.headerSize = HeaderSize;
        _internal.headerVersion = HeaderVersion;
        _internal.vendorID = VendorID;
        _internal.deviceID = DeviceID;
        if(PipelineCacheUUID != null)
        {
            if (PipelineCacheUUID.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(PipelineCacheUUID), "Array is out of bounds. Size should not be more than 16");

            NativeUtils.PrimitiveToFixedArray(_internal.pipelineCacheUUID, 16, PipelineCacheUUID);
        }
        return _internal;
    }

    public static implicit operator PipelineCacheHeaderVersionOne(AdamantiumVulkan.Core.Interop.VkPipelineCacheHeaderVersionOne p)
    {
        return new PipelineCacheHeaderVersionOne(p);
    }

}


