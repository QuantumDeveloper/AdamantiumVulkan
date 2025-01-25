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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 4119 Column: 26
public unsafe struct PFN_vkGetPhysicalDeviceQueueFamilyProperties
{
    public PFN_vkGetPhysicalDeviceQueueFamilyProperties(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pQueueFamilyPropertyCount, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties* pQueueFamilyProperties)
    {
         InvokeFunc(physicalDevice, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pQueueFamilyPropertyCount, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties* pQueueFamilyProperties)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties*, void>)ptr)(physicalDevice, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceQueueFamilyProperties(void* ptr) => new(ptr);
}


