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

public unsafe partial class EventCreateInfo : QBDisposableObject
{
    public EventCreateInfo()
    {
    }

    public EventCreateInfo(AdamantiumVulkan.Core.Interop.VkEventCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType => StructureType.EventCreateInfo;
    public void* PNext { get; set; }
    public VkEventCreateFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkEventCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkEventCreateInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        return _internal;
    }

    public static implicit operator EventCreateInfo(AdamantiumVulkan.Core.Interop.VkEventCreateInfo e)
    {
        return new EventCreateInfo(e);
    }

}



