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

public unsafe partial class SwapchainLatencyCreateInfoNV : QBDisposableObject
{
    public SwapchainLatencyCreateInfoNV()
    {
    }

    public SwapchainLatencyCreateInfoNV(AdamantiumVulkan.Core.Interop.VkSwapchainLatencyCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        LatencyModeEnable = _internal.latencyModeEnable;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 LatencyModeEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSwapchainLatencyCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSwapchainLatencyCreateInfoNV();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (LatencyModeEnable != (uint)default)
        {
            _internal.latencyModeEnable = LatencyModeEnable;
        }
        return _internal;
    }

    public static implicit operator SwapchainLatencyCreateInfoNV(AdamantiumVulkan.Core.Interop.VkSwapchainLatencyCreateInfoNV s)
    {
        return new SwapchainLatencyCreateInfoNV(s);
    }

}


