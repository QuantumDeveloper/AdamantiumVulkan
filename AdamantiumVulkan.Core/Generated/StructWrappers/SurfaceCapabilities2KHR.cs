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

public unsafe partial class SurfaceCapabilities2KHR : QBDisposableObject
{
    public SurfaceCapabilities2KHR()
    {
    }

    public SurfaceCapabilities2KHR(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR _internal)
    {
        PNext = _internal.pNext;
        SurfaceCapabilities = new SurfaceCapabilitiesKHR(_internal.surfaceCapabilities);
    }

    public StructureType SType => StructureType.SurfaceCapabilities2Khr;
    public void* PNext { get; set; }
    public SurfaceCapabilitiesKHR SurfaceCapabilities { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SurfaceCapabilities != default)
        {
            _internal.surfaceCapabilities = SurfaceCapabilities.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        SurfaceCapabilities?.Dispose();
    }


    public static implicit operator SurfaceCapabilities2KHR(AdamantiumVulkan.Core.Interop.VkSurfaceCapabilities2KHR s)
    {
        return new SurfaceCapabilities2KHR(s);
    }

}



