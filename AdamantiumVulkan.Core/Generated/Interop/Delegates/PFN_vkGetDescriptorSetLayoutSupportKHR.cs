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

public unsafe struct PFN_vkGetDescriptorSetLayoutSupportKHR
{
    public PFN_vkGetDescriptorSetLayoutSupportKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
    {
         InvokeFunc(device, pCreateInfo, pSupport);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
    {
         ((delegate* unmanaged<VkDevice_T, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)ptr)(device, pCreateInfo, pSupport);
    }

    public static explicit operator PFN_vkGetDescriptorSetLayoutSupportKHR(void* ptr) => new(ptr);
}


