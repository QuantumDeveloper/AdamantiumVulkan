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

public unsafe partial class AntiLagPresentationInfoAMD : QBDisposableObject
{
    public AntiLagPresentationInfoAMD()
    {
    }

    public AntiLagPresentationInfoAMD(AdamantiumVulkan.Core.Interop.VkAntiLagPresentationInfoAMD _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Stage = _internal.stage;
        FrameIndex = _internal.frameIndex;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public AntiLagStageAMD Stage { get; set; }
    public ulong FrameIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAntiLagPresentationInfoAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAntiLagPresentationInfoAMD();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Stage != default)
        {
            _internal.stage = Stage;
        }
        if (FrameIndex != default)
        {
            _internal.frameIndex = FrameIndex;
        }
        return _internal;
    }

    public static implicit operator AntiLagPresentationInfoAMD(AdamantiumVulkan.Core.Interop.VkAntiLagPresentationInfoAMD a)
    {
        return new AntiLagPresentationInfoAMD(a);
    }

}



