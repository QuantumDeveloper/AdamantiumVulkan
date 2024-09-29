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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 14046 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT
{
    public PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, ref TimeDomainKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, ref TimeDomainKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pTimeDomainCount, ref TimeDomainKHR* pTimeDomains)
    {
        return InvokeFunc(physicalDevice, ref pTimeDomainCount, ref pTimeDomains);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pTimeDomainCount, ref TimeDomainKHR* pTimeDomains)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, ref TimeDomainKHR*, Result>)ptr)(physicalDevice, ref pTimeDomainCount, ref pTimeDomains);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(void* ptr) => new(ptr);
}


