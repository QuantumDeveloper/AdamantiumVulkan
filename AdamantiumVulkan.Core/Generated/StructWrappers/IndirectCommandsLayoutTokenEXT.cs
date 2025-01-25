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

public unsafe partial class IndirectCommandsLayoutTokenEXT : QBDisposableObject
{
    public IndirectCommandsLayoutTokenEXT()
    {
    }

    public IndirectCommandsLayoutTokenEXT(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutTokenEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        Data = new IndirectCommandsTokenDataEXT(_internal.data);
        Offset = _internal.offset;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public IndirectCommandsTokenTypeEXT Type { get; set; }
    public IndirectCommandsTokenDataEXT Data { get; set; }
    public uint Offset { get; set; }

    public AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutTokenEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutTokenEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (Data != default)
        {
            _internal.data = Data.ToNative();
        }
        if (Offset != default)
        {
            _internal.offset = Offset;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Data?.Dispose();
    }


    public static implicit operator IndirectCommandsLayoutTokenEXT(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutTokenEXT i)
    {
        return new IndirectCommandsLayoutTokenEXT(i);
    }

}



