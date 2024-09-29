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

public unsafe partial class VideoSessionParametersUpdateInfoKHR : QBDisposableObject
{
    public VideoSessionParametersUpdateInfoKHR()
    {
    }

    public VideoSessionParametersUpdateInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionParametersUpdateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        UpdateSequenceCount = _internal.updateSequenceCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint UpdateSequenceCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoSessionParametersUpdateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoSessionParametersUpdateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (UpdateSequenceCount != default)
        {
            _internal.updateSequenceCount = UpdateSequenceCount;
        }
        return _internal;
    }

    public static implicit operator VideoSessionParametersUpdateInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoSessionParametersUpdateInfoKHR v)
    {
        return new VideoSessionParametersUpdateInfoKHR(v);
    }

}


