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

public unsafe partial class SpecializationMapEntry
{
    public SpecializationMapEntry()
    {
    }

    public SpecializationMapEntry(AdamantiumVulkan.Core.Interop.VkSpecializationMapEntry _internal)
    {
        ConstantID = _internal.constantID;
        Offset = _internal.offset;
        Size = _internal.size;
    }

    public uint ConstantID { get; set; }
    public uint Offset { get; set; }
    public ulong Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSpecializationMapEntry ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSpecializationMapEntry();
        _internal.constantID = ConstantID;
        _internal.offset = Offset;
        _internal.size = Size;
        return _internal;
    }

    public static implicit operator SpecializationMapEntry(AdamantiumVulkan.Core.Interop.VkSpecializationMapEntry s)
    {
        return new SpecializationMapEntry(s);
    }

}



