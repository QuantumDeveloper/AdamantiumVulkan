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

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 16851 Column: 26
public unsafe struct PFN_vkDeviceMemoryReportCallbackEXT
{
    public PFN_vkDeviceMemoryReportCallbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDeviceMemoryReportCallbackDataEXT*, void*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDeviceMemoryReportCallbackDataEXT*, void*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDeviceMemoryReportCallbackDataEXT* pCallbackData, void* pUserData)
    {
         InvokeFunc(pCallbackData, pUserData);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDeviceMemoryReportCallbackDataEXT* pCallbackData, void* pUserData)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDeviceMemoryReportCallbackDataEXT*, void*, void>)ptr)(pCallbackData, pUserData);
    }

    public static explicit operator PFN_vkDeviceMemoryReportCallbackEXT(void* ptr) => new(ptr);
}


