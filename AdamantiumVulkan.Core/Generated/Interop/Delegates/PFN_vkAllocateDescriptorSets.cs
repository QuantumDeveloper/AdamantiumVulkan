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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4230 Column: 30
public unsafe struct PFN_vkAllocateDescriptorSets
{
    public PFN_vkAllocateDescriptorSets(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo*, out AdamantiumVulkan.Core.Interop.VkDescriptorSet_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo*, out AdamantiumVulkan.Core.Interop.VkDescriptorSet_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo* pAllocateInfo, out AdamantiumVulkan.Core.Interop.VkDescriptorSet_T pDescriptorSets)
    {
        return InvokeFunc(device, pAllocateInfo, out pDescriptorSets);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo* pAllocateInfo, out AdamantiumVulkan.Core.Interop.VkDescriptorSet_T pDescriptorSets)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDescriptorSetAllocateInfo*, out AdamantiumVulkan.Core.Interop.VkDescriptorSet_T, Result>)ptr)(device, pAllocateInfo, out pDescriptorSets);
    }

    public static explicit operator PFN_vkAllocateDescriptorSets(void* ptr) => new(ptr);
}


