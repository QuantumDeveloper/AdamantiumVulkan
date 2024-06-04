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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 12614 Column: 26
public unsafe struct PFN_vkSetHdrMetadataEXT
{
    public PFN_vkSetHdrMetadataEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T*, AdamantiumVulkan.Core.Interop.VkHdrMetadataEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T*, AdamantiumVulkan.Core.Interop.VkHdrMetadataEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint swapchainCount, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T* pSwapchains, AdamantiumVulkan.Core.Interop.VkHdrMetadataEXT* pMetadata)
    {
         InvokeFunc(device, swapchainCount, pSwapchains, pMetadata);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint swapchainCount, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T* pSwapchains, AdamantiumVulkan.Core.Interop.VkHdrMetadataEXT* pMetadata)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T*, AdamantiumVulkan.Core.Interop.VkHdrMetadataEXT*, void>)ptr)(device, swapchainCount, pSwapchains, pMetadata);
    }

    public static explicit operator PFN_vkSetHdrMetadataEXT(void* ptr) => new(ptr);
}


