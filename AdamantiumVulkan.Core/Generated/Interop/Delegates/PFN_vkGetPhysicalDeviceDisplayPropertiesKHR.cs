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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7897 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceDisplayPropertiesKHR
{
    public PFN_vkGetPhysicalDeviceDisplayPropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR* pProperties)
    {
        return InvokeFunc(physicalDevice, ref pPropertyCount, pProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR* pProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR*, Result>)ptr)(physicalDevice, ref pPropertyCount, pProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceDisplayPropertiesKHR(void* ptr) => new(ptr);
}


