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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 9154 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR
{
    public PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkVideoProfileInfoKHR*, AdamantiumVulkan.Core.Interop.VkVideoCapabilitiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkVideoProfileInfoKHR*, AdamantiumVulkan.Core.Interop.VkVideoCapabilitiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkVideoProfileInfoKHR* pVideoProfile, AdamantiumVulkan.Core.Interop.VkVideoCapabilitiesKHR* pCapabilities)
    {
        return InvokeFunc(physicalDevice, pVideoProfile, pCapabilities);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkVideoProfileInfoKHR* pVideoProfile, AdamantiumVulkan.Core.Interop.VkVideoCapabilitiesKHR* pCapabilities)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkVideoProfileInfoKHR*, AdamantiumVulkan.Core.Interop.VkVideoCapabilitiesKHR*, Result>)ptr)(physicalDevice, pVideoProfile, pCapabilities);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(void* ptr) => new(ptr);
}


