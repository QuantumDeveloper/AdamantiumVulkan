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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 14369 Column: 26
public unsafe struct PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT
{
    public PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, SampleCountFlagBits, AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, SampleCountFlagBits, AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, SampleCountFlagBits samples, AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT* pMultisampleProperties)
    {
         InvokeFunc(physicalDevice, samples, pMultisampleProperties);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, SampleCountFlagBits samples, AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT* pMultisampleProperties)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, SampleCountFlagBits, AdamantiumVulkan.Core.Interop.VkMultisamplePropertiesEXT*, void>)ptr)(physicalDevice, samples, pMultisampleProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT(void* ptr) => new(ptr);
}


