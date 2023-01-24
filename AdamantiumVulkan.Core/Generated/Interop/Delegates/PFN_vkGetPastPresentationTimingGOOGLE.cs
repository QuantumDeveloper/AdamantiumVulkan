// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

public unsafe struct PFN_vkGetPastPresentationTimingGOOGLE
{
    public PFN_vkGetPastPresentationTimingGOOGLE(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain, ref uint* pPresentationTimingCount, AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE* pPresentationTimings)
    {
        return InvokeFunc(device, swapchain, ref pPresentationTimingCount, pPresentationTimings);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain, ref uint* pPresentationTimingCount, AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE* pPresentationTimings)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE*, Result>)ptr)(device, swapchain, ref pPresentationTimingCount, pPresentationTimings);
    }

    public static explicit operator PFN_vkGetPastPresentationTimingGOOGLE(void* ptr) => new(ptr);
}


