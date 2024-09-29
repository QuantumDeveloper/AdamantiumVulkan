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

public unsafe partial class SubpassBeginInfo : QBDisposableObject
{
    public SubpassBeginInfo()
    {
    }

    public SubpassBeginInfo(AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Contents = _internal.contents;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public SubpassContents Contents { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Contents != default)
        {
            _internal.contents = Contents;
        }
        return _internal;
    }

    public static implicit operator SubpassBeginInfo(AdamantiumVulkan.Core.Interop.VkSubpassBeginInfo s)
    {
        return new SubpassBeginInfo(s);
    }

}



