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

public unsafe partial class SwapchainPresentBarrierCreateInfoNV : QBDisposableObject
{
    public SwapchainPresentBarrierCreateInfoNV()
    {
    }

    public SwapchainPresentBarrierCreateInfoNV(AdamantiumVulkan.Core.Interop.VkSwapchainPresentBarrierCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PresentBarrierEnable = _internal.presentBarrierEnable;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 PresentBarrierEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSwapchainPresentBarrierCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSwapchainPresentBarrierCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (PresentBarrierEnable != (uint)default)
        {
            _internal.presentBarrierEnable = PresentBarrierEnable;
        }
        return _internal;
    }

    public static implicit operator SwapchainPresentBarrierCreateInfoNV(AdamantiumVulkan.Core.Interop.VkSwapchainPresentBarrierCreateInfoNV s)
    {
        return new SwapchainPresentBarrierCreateInfoNV(s);
    }

}



