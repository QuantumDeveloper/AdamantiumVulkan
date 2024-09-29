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

public unsafe partial class AcquireNextImageInfoKHR : QBDisposableObject
{
    public AcquireNextImageInfoKHR()
    {
    }

    public AcquireNextImageInfoKHR(AdamantiumVulkan.Core.Interop.VkAcquireNextImageInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Swapchain = new SwapchainKHR(_internal.swapchain);
        Timeout = _internal.timeout;
        Semaphore = new Semaphore(_internal.semaphore);
        Fence = new Fence(_internal.fence);
        DeviceMask = _internal.deviceMask;
    }

    public StructureType SType => StructureType.AcquireNextImageInfoKhr;
    public void* PNext { get; set; }
    public SwapchainKHR Swapchain { get; set; }
    public ulong Timeout { get; set; }
    public Semaphore Semaphore { get; set; }
    public Fence Fence { get; set; }
    public uint DeviceMask { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAcquireNextImageInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAcquireNextImageInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Swapchain != default)
        {
            _internal.swapchain = Swapchain;
        }
        if (Timeout != default)
        {
            _internal.timeout = Timeout;
        }
        if (Semaphore != default)
        {
            _internal.semaphore = Semaphore;
        }
        if (Fence != default)
        {
            _internal.fence = Fence;
        }
        if (DeviceMask != default)
        {
            _internal.deviceMask = DeviceMask;
        }
        return _internal;
    }

    public static implicit operator AcquireNextImageInfoKHR(AdamantiumVulkan.Core.Interop.VkAcquireNextImageInfoKHR a)
    {
        return new AcquireNextImageInfoKHR(a);
    }

}



