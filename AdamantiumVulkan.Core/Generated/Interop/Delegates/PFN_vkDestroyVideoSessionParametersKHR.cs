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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 8198 Column: 26
public unsafe struct PFN_vkDestroyVideoSessionParametersKHR
{
    public PFN_vkDestroyVideoSessionParametersKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T videoSessionParameters, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, videoSessionParameters, pAllocator);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T videoSessionParameters, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkVideoSessionParametersKHR_T, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, void>)ptr)(device, videoSessionParameters, pAllocator);
    }

    public static explicit operator PFN_vkDestroyVideoSessionParametersKHR(void* ptr) => new(ptr);
}

