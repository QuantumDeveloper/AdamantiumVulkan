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

public unsafe partial class FormatProperties2 : QBDisposableObject
{
    public FormatProperties2()
    {
    }

    public FormatProperties2(AdamantiumVulkan.Core.Interop.VkFormatProperties2 _internal)
    {
        PNext = _internal.pNext;
        FormatProperties = new FormatProperties(_internal.formatProperties);
    }

    public StructureType SType => StructureType.FormatProperties2;
    public void* PNext { get; set; }
    public FormatProperties FormatProperties { get; set; }

    public AdamantiumVulkan.Core.Interop.VkFormatProperties2 ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkFormatProperties2();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (FormatProperties != null)
        {
            _internal.formatProperties = FormatProperties.ToNative();
        }
        return _internal;
    }

    public static implicit operator FormatProperties2(AdamantiumVulkan.Core.Interop.VkFormatProperties2 f)
    {
        return new FormatProperties2(f);
    }

}



