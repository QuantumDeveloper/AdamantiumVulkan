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

public unsafe partial class SwapchainPresentModeInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.PresentModeKHR> _pPresentModes;

    public SwapchainPresentModeInfoEXT()
    {
    }

    public SwapchainPresentModeInfoEXT(AdamantiumVulkan.Core.Interop.VkSwapchainPresentModeInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SwapchainCount = _internal.swapchainCount;
        PresentModes = *_internal.pPresentModes;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint SwapchainCount { get; set; }
    public PresentModeKHR? PresentModes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSwapchainPresentModeInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSwapchainPresentModeInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SwapchainCount != default)
        {
            _internal.swapchainCount = SwapchainCount;
        }
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


    public static implicit operator SwapchainPresentModeInfoEXT(AdamantiumVulkan.Core.Interop.VkSwapchainPresentModeInfoEXT s)
    {
        return new SwapchainPresentModeInfoEXT(s);
    }

}



