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

public unsafe partial class PrivateDataSlotCreateInfo : QBDisposableObject
{
    public PrivateDataSlotCreateInfo()
    {
    }

    public PrivateDataSlotCreateInfo(AdamantiumVulkan.Core.Interop.VkPrivateDataSlotCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPrivateDataSlotCreateFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPrivateDataSlotCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPrivateDataSlotCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        return _internal;
    }

    public static implicit operator PrivateDataSlotCreateInfo(AdamantiumVulkan.Core.Interop.VkPrivateDataSlotCreateInfo p)
    {
        return new PrivateDataSlotCreateInfo(p);
    }

}


