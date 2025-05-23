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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 10520 Column: 30
public unsafe struct PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR
{
    public PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterKHR*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterKHR*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex, ref uint* pCounterCount, AdamantiumVulkan.Core.Interop.VkPerformanceCounterKHR* pCounters, AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
    {
        return InvokeFunc(physicalDevice, queueFamilyIndex, ref pCounterCount, pCounters, pCounterDescriptions);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex, ref uint* pCounterCount, AdamantiumVulkan.Core.Interop.VkPerformanceCounterKHR* pCounters, AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, ref uint*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterKHR*, AdamantiumVulkan.Core.Interop.VkPerformanceCounterDescriptionKHR*, Result>)ptr)(physicalDevice, queueFamilyIndex, ref pCounterCount, pCounters, pCounterDescriptions);
    }

    public static explicit operator PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(void* ptr) => new(ptr);
}


