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

public unsafe partial class IndirectCommandsStreamNV
{
    public IndirectCommandsStreamNV()
    {
    }

    public IndirectCommandsStreamNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV _internal)
    {
        Buffer = new Buffer(_internal.buffer);
        Offset = _internal.offset;
    }

    public Buffer Buffer { get; set; }
    public VkDeviceSize Offset { get; set; }

    public AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV();
        _internal.buffer = Buffer;
        _internal.offset = Offset;
        return _internal;
    }

    public static implicit operator IndirectCommandsStreamNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsStreamNV i)
    {
        return new IndirectCommandsStreamNV(i);
    }

}


