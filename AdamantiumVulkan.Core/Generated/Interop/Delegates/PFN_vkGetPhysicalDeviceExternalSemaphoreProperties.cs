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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 5567 Column: 26
public unsafe struct PFN_vkGetPhysicalDeviceExternalSemaphoreProperties
{
    public PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalSemaphoreInfo*, AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalSemaphoreInfo*, AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
    {
         InvokeFunc(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalSemaphoreInfo*, AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties*, void>)ptr)(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(void* ptr) => new(ptr);
}


