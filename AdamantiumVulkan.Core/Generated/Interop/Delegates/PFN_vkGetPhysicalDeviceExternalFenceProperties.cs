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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 5770 Column: 26
public unsafe struct PFN_vkGetPhysicalDeviceExternalFenceProperties
{
    public PFN_vkGetPhysicalDeviceExternalFenceProperties(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalFenceInfo*, AdamantiumVulkan.Core.Interop.VkExternalFenceProperties*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalFenceInfo*, AdamantiumVulkan.Core.Interop.VkExternalFenceProperties*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, AdamantiumVulkan.Core.Interop.VkExternalFenceProperties* pExternalFenceProperties)
    {
         InvokeFunc(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, AdamantiumVulkan.Core.Interop.VkExternalFenceProperties* pExternalFenceProperties)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalFenceInfo*, AdamantiumVulkan.Core.Interop.VkExternalFenceProperties*, void>)ptr)(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceExternalFenceProperties(void* ptr) => new(ptr);
}


