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

public unsafe struct PFN_vkDestroyDescriptorUpdateTemplateKHR
{
    public PFN_vkDestroyDescriptorUpdateTemplateKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkDescriptorUpdateTemplate_T, VkAllocationCallbacks*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkDescriptorUpdateTemplate_T, VkAllocationCallbacks*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkDescriptorUpdateTemplate_T descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
    {
         InvokeFunc(device, descriptorUpdateTemplate, pAllocator);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkDescriptorUpdateTemplate_T descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
    {
         ((delegate* unmanaged<VkDevice_T, VkDescriptorUpdateTemplate_T, VkAllocationCallbacks*, void>)ptr)(device, descriptorUpdateTemplate, pAllocator);
    }

    public static explicit operator PFN_vkDestroyDescriptorUpdateTemplateKHR(void* ptr) => new(ptr);
}


