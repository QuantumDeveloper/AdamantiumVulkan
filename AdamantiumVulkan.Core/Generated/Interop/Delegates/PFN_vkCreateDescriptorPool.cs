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

public unsafe struct PFN_vkCreateDescriptorPool
{
    public PFN_vkCreateDescriptorPool(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, out VkDescriptorPool_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, out VkDescriptorPool_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDescriptorPool_T pDescriptorPool)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pDescriptorPool);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDescriptorPool_T pDescriptorPool)
    {
        return ((delegate* unmanaged<VkDevice_T, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, out VkDescriptorPool_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pDescriptorPool);
    }

    public static explicit operator PFN_vkCreateDescriptorPool(void* ptr) => new(ptr);
}

