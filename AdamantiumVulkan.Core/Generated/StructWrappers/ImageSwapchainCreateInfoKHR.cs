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

public unsafe partial class ImageSwapchainCreateInfoKHR : QBDisposableObject
{
    public ImageSwapchainCreateInfoKHR()
    {
    }

    public ImageSwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkImageSwapchainCreateInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Swapchain = new SwapchainKHR(_internal.swapchain);
    }

    public StructureType SType => StructureType.ImageSwapchainCreateInfoKhr;
    public void* PNext { get; set; }
    public SwapchainKHR Swapchain { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImageSwapchainCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImageSwapchainCreateInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.swapchain = Swapchain;
        return _internal;
    }

    public static implicit operator ImageSwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkImageSwapchainCreateInfoKHR i)
    {
        return new ImageSwapchainCreateInfoKHR(i);
    }

}



