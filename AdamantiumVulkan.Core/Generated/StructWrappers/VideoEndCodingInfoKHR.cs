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

public unsafe partial class VideoEndCodingInfoKHR : QBDisposableObject
{
    public VideoEndCodingInfoKHR()
    {
    }

    public VideoEndCodingInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEndCodingInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoEndCodingFlagsKHR Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEndCodingInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEndCodingInfoKHR();
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

    public static implicit operator VideoEndCodingInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoEndCodingInfoKHR v)
    {
        return new VideoEndCodingInfoKHR(v);
    }

}



