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

public unsafe partial class ReleaseSwapchainImagesInfoEXT : QBDisposableObject
{
    private NativeStruct<uint> _pImageIndices;

    public ReleaseSwapchainImagesInfoEXT()
    {
    }

    public ReleaseSwapchainImagesInfoEXT(AdamantiumVulkan.Core.Interop.VkReleaseSwapchainImagesInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Swapchain = new SwapchainKHR(_internal.swapchain);
        ImageIndexCount = _internal.imageIndexCount;
        if (_internal.pImageIndices != null)
        {
            PImageIndices = *_internal.pImageIndices;
            NativeUtils.Free(_internal.pImageIndices);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public SwapchainKHR Swapchain { get; set; }
    public uint ImageIndexCount { get; set; }
    public uint? PImageIndices { get; set; }

    public AdamantiumVulkan.Core.Interop.VkReleaseSwapchainImagesInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkReleaseSwapchainImagesInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Swapchain != default)
        {
            _internal.swapchain = Swapchain;
        }
        if (ImageIndexCount != default)
        {
            _internal.imageIndexCount = ImageIndexCount;
        }
        _pImageIndices.Dispose();
        if (PImageIndices.HasValue)
        {
            _pImageIndices = new NativeStruct<uint>(PImageIndices.Value);
            _internal.pImageIndices = _pImageIndices.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pImageIndices.Dispose();
    }


    public static implicit operator ReleaseSwapchainImagesInfoEXT(AdamantiumVulkan.Core.Interop.VkReleaseSwapchainImagesInfoEXT r)
    {
        return new ReleaseSwapchainImagesInfoEXT(r);
    }

}


