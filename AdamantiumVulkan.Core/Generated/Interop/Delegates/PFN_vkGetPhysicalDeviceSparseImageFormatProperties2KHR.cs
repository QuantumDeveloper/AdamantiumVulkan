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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 9844 Column: 26
public unsafe struct PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR
{
    public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties2*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties2* pProperties)
    {
         InvokeFunc(physicalDevice, pFormatInfo, ref pPropertyCount, pProperties);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties2* pProperties)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageFormatProperties2*, void>)ptr)(physicalDevice, pFormatInfo, ref pPropertyCount, pProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* ptr) => new(ptr);
}


