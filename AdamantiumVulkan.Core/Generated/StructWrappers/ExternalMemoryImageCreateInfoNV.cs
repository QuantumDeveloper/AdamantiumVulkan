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

public unsafe partial class ExternalMemoryImageCreateInfoNV : QBDisposableObject
{
    public ExternalMemoryImageCreateInfoNV()
    {
    }

    public ExternalMemoryImageCreateInfoNV(AdamantiumVulkan.Core.Interop.VkExternalMemoryImageCreateInfoNV _internal)
    {
        PNext = _internal.pNext;
        HandleTypes = _internal.handleTypes;
    }

    public StructureType SType => StructureType.ExternalMemoryImageCreateInfoNv;
    public void* PNext { get; set; }
    public VkExternalMemoryHandleTypeFlagsNV HandleTypes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkExternalMemoryImageCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkExternalMemoryImageCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (HandleTypes != (uint)default)
        {
            _internal.handleTypes = HandleTypes;
        }
        return _internal;
    }

    public static implicit operator ExternalMemoryImageCreateInfoNV(AdamantiumVulkan.Core.Interop.VkExternalMemoryImageCreateInfoNV e)
    {
        return new ExternalMemoryImageCreateInfoNV(e);
    }

}



