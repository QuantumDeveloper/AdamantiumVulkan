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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 8191 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceVideoFormatPropertiesKHR
{
    public PFN_vkGetPhysicalDeviceVideoFormatPropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoFormatInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkVideoFormatPropertiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoFormatInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkVideoFormatPropertiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint* pVideoFormatPropertyCount, AdamantiumVulkan.Core.Interop.VkVideoFormatPropertiesKHR* pVideoFormatProperties)
    {
        return InvokeFunc(physicalDevice, pVideoFormatInfo, ref pVideoFormatPropertyCount, pVideoFormatProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint* pVideoFormatPropertyCount, AdamantiumVulkan.Core.Interop.VkVideoFormatPropertiesKHR* pVideoFormatProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVideoFormatInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkVideoFormatPropertiesKHR*, Result>)ptr)(physicalDevice, pVideoFormatInfo, ref pVideoFormatPropertyCount, pVideoFormatProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceVideoFormatPropertiesKHR(void* ptr) => new(ptr);
}


