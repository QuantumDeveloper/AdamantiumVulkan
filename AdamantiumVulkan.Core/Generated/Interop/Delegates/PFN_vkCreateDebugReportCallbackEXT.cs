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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 11527 Column: 30
public unsafe struct PFN_vkCreateDebugReportCallbackEXT
{
    public PFN_vkCreateDebugReportCallbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDebugReportCallbackEXT_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDebugReportCallbackEXT_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkDebugReportCallbackEXT_T pCallback)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pCallback);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkDebugReportCallbackEXT_T pCallback)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkDebugReportCallbackEXT_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pCallback);
    }

    public static explicit operator PFN_vkCreateDebugReportCallbackEXT(void* ptr) => new(ptr);
}


