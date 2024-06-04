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

public unsafe partial class LatencySurfaceCapabilitiesNV : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.PresentModeKHR> _pPresentModes;

    public LatencySurfaceCapabilitiesNV()
    {
    }

    public LatencySurfaceCapabilitiesNV(AdamantiumVulkan.Core.Interop.VkLatencySurfaceCapabilitiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PresentModeCount = _internal.presentModeCount;
        PresentModes = *_internal.pPresentModes;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint PresentModeCount { get; set; }
    public PresentModeKHR? PresentModes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkLatencySurfaceCapabilitiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkLatencySurfaceCapabilitiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.presentModeCount = PresentModeCount;
        _pPresentModes.Dispose();
        if (PresentModes.HasValue)
        {
            _pPresentModes = new NativeStruct<AdamantiumVulkan.Core.PresentModeKHR>(PresentModes.Value);
            _internal.pPresentModes = _pPresentModes.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pPresentModes.Dispose();
    }


    public static implicit operator LatencySurfaceCapabilitiesNV(AdamantiumVulkan.Core.Interop.VkLatencySurfaceCapabilitiesNV l)
    {
        return new LatencySurfaceCapabilitiesNV(l);
    }

}



