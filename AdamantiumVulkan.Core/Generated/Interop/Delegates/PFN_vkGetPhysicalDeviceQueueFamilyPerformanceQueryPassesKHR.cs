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

public unsafe struct PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR
{
    public PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkQueryPoolPerformanceCreateInfoKHR*, ref uint*, void>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkQueryPoolPerformanceCreateInfoKHR*, ref uint*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkPhysicalDevice_T physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, ref uint* pNumPasses)
    {
         InvokeFunc(physicalDevice, pPerformanceQueryCreateInfo, ref pNumPasses);
    }
    public static void Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, ref uint* pNumPasses)
    {
         ((delegate* unmanaged<VkPhysicalDevice_T, VkQueryPoolPerformanceCreateInfoKHR*, ref uint*, void>)ptr)(physicalDevice, pPerformanceQueryCreateInfo, ref pNumPasses);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(void* ptr) => new(ptr);
}


