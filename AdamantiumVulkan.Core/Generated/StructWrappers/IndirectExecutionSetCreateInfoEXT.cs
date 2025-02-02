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

public unsafe partial class IndirectExecutionSetCreateInfoEXT : QBDisposableObject
{
    public IndirectExecutionSetCreateInfoEXT()
    {
    }

    public IndirectExecutionSetCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        Info = new IndirectExecutionSetInfoEXT(_internal.info);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public IndirectExecutionSetInfoTypeEXT Type { get; set; }
    public IndirectExecutionSetInfoEXT Info { get; set; }

    public AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (Info != default)
        {
            _internal.info = Info.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        Info?.Dispose();
    }


    public static implicit operator IndirectExecutionSetCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetCreateInfoEXT i)
    {
        return new IndirectExecutionSetCreateInfoEXT(i);
    }

}



