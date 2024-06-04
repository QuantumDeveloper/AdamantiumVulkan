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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15872 Column: 26
public unsafe struct PFN_vkGetDescriptorEXT
{
    public PFN_vkGetDescriptorEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT*, ulong, void*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT*, ulong, void*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT* pDescriptorInfo, ulong dataSize, void* pDescriptor)
    {
         InvokeFunc(device, pDescriptorInfo, dataSize, pDescriptor);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT* pDescriptorInfo, ulong dataSize, void* pDescriptor)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorGetInfoEXT*, ulong, void*, void>)ptr)(device, pDescriptorInfo, dataSize, pDescriptor);
    }

    public static explicit operator PFN_vkGetDescriptorEXT(void* ptr) => new(ptr);
}


