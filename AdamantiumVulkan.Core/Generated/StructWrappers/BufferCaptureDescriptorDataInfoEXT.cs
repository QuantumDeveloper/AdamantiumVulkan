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

public unsafe partial class BufferCaptureDescriptorDataInfoEXT : QBDisposableObject
{
    public BufferCaptureDescriptorDataInfoEXT()
    {
    }

    public BufferCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkBufferCaptureDescriptorDataInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Buffer = new Buffer(_internal.buffer);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Buffer Buffer { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBufferCaptureDescriptorDataInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBufferCaptureDescriptorDataInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.buffer = Buffer;
        return _internal;
    }

    public static implicit operator BufferCaptureDescriptorDataInfoEXT(AdamantiumVulkan.Core.Interop.VkBufferCaptureDescriptorDataInfoEXT b)
    {
        return new BufferCaptureDescriptorDataInfoEXT(b);
    }

}


