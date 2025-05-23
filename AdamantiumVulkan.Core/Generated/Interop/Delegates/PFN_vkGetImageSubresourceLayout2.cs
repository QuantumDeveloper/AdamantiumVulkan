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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 8388 Column: 26
public unsafe struct PFN_vkGetImageSubresourceLayout2
{
    public PFN_vkGetImageSubresourceLayout2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkImageSubresource2*, AdamantiumVulkan.Core.Interop.VkSubresourceLayout2*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkImageSubresource2*, AdamantiumVulkan.Core.Interop.VkSubresourceLayout2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, AdamantiumVulkan.Core.Interop.VkImageSubresource2* pSubresource, AdamantiumVulkan.Core.Interop.VkSubresourceLayout2* pLayout)
    {
         InvokeFunc(device, image, pSubresource, pLayout);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, AdamantiumVulkan.Core.Interop.VkImageSubresource2* pSubresource, AdamantiumVulkan.Core.Interop.VkSubresourceLayout2* pLayout)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkImageSubresource2*, AdamantiumVulkan.Core.Interop.VkSubresourceLayout2*, void>)ptr)(device, image, pSubresource, pLayout);
    }

    public static explicit operator PFN_vkGetImageSubresourceLayout2(void* ptr) => new(ptr);
}


