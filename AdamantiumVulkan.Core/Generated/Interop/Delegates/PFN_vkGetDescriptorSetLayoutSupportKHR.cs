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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 10828 Column: 26
public unsafe struct PFN_vkGetDescriptorSetLayoutSupportKHR
{
    public PFN_vkGetDescriptorSetLayoutSupportKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutCreateInfo*, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutCreateInfo*, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport* pSupport)
    {
         InvokeFunc(device, pCreateInfo, pSupport);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport* pSupport)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutCreateInfo*, AdamantiumVulkan.Core.Interop.VkDescriptorSetLayoutSupport*, void>)ptr)(device, pCreateInfo, pSupport);
    }

    public static explicit operator PFN_vkGetDescriptorSetLayoutSupportKHR(void* ptr) => new(ptr);
}


