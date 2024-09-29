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

public unsafe partial class OpticalFlowSessionCreatePrivateDataInfoNV : QBDisposableObject
{
    public OpticalFlowSessionCreatePrivateDataInfoNV()
    {
    }

    public OpticalFlowSessionCreatePrivateDataInfoNV(AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreatePrivateDataInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Id = _internal.id;
        Size = _internal.size;
        PrivateData = _internal.pPrivateData;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint Id { get; set; }
    public uint Size { get; set; }
    public void* PrivateData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreatePrivateDataInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreatePrivateDataInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Id != default)
        {
            _internal.id = Id;
        }
        if (Size != default)
        {
            _internal.size = Size;
        }
        _internal.pPrivateData = PrivateData;
        return _internal;
    }

    public static implicit operator OpticalFlowSessionCreatePrivateDataInfoNV(AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreatePrivateDataInfoNV o)
    {
        return new OpticalFlowSessionCreatePrivateDataInfoNV(o);
    }

}



