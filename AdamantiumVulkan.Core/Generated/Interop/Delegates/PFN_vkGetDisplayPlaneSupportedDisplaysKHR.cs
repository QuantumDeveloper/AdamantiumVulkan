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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 7863 Column: 30
public unsafe struct PFN_vkGetDisplayPlaneSupportedDisplaysKHR
{
    public PFN_vkGetDisplayPlaneSupportedDisplaysKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint planeIndex, ref uint* pDisplayCount, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplays)
    {
        return InvokeFunc(physicalDevice, planeIndex, ref pDisplayCount, out pDisplays);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint planeIndex, ref uint* pDisplayCount, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplays)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result>)ptr)(physicalDevice, planeIndex, ref pDisplayCount, out pDisplays);
    }

    public static explicit operator PFN_vkGetDisplayPlaneSupportedDisplaysKHR(void* ptr) => new(ptr);
}


