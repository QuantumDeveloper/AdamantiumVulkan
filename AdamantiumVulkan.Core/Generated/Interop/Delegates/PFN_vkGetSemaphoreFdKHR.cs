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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 9192 Column: 30
public unsafe struct PFN_vkGetSemaphoreFdKHR
{
    public PFN_vkGetSemaphoreFdKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSemaphoreGetFdInfoKHR*, ref int*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSemaphoreGetFdInfoKHR*, ref int*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSemaphoreGetFdInfoKHR* pGetFdInfo, ref int* pFd)
    {
        return InvokeFunc(device, pGetFdInfo, ref pFd);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSemaphoreGetFdInfoKHR* pGetFdInfo, ref int* pFd)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkSemaphoreGetFdInfoKHR*, ref int*, Result>)ptr)(device, pGetFdInfo, ref pFd);
    }

    public static explicit operator PFN_vkGetSemaphoreFdKHR(void* ptr) => new(ptr);
}


