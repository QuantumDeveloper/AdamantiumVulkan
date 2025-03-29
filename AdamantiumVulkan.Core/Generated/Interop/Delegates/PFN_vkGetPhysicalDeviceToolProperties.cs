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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 7549 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceToolProperties
{
    public PFN_vkGetPhysicalDeviceToolProperties(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceToolProperties*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceToolProperties*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pToolCount, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return InvokeFunc(physicalDevice, ref pToolCount, pToolProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pToolCount, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceToolProperties* pToolProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceToolProperties*, Result>)ptr)(physicalDevice, ref pToolCount, pToolProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceToolProperties(void* ptr) => new(ptr);
}


