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

public unsafe partial class SubpassEndInfo : QBDisposableObject
{
    public SubpassEndInfo()
    {
    }

    public SubpassEndInfo(AdamantiumVulkan.Core.Interop.VkSubpassEndInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSubpassEndInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSubpassEndInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        return _internal;
    }

    public static implicit operator SubpassEndInfo(AdamantiumVulkan.Core.Interop.VkSubpassEndInfo s)
    {
        return new SubpassEndInfo(s);
    }

}


