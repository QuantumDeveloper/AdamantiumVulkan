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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 10720 Column: 26
public unsafe struct PFN_vkGetImageMemoryRequirements2KHR
{
    public PFN_vkGetImageMemoryRequirements2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageMemoryRequirementsInfo2*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageMemoryRequirementsInfo2*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageMemoryRequirementsInfo2* pInfo, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2* pMemoryRequirements)
    {
         InvokeFunc(device, pInfo, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageMemoryRequirementsInfo2* pInfo, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2* pMemoryRequirements)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageMemoryRequirementsInfo2*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void>)ptr)(device, pInfo, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetImageMemoryRequirements2KHR(void* ptr) => new(ptr);
}


