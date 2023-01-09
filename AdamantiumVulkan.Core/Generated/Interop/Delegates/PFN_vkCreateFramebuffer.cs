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

public unsafe struct PFN_vkCreateFramebuffer
{
    public PFN_vkCreateFramebuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkFramebufferCreateInfo*, VkAllocationCallbacks*, out VkFramebuffer_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkFramebufferCreateInfo*, VkAllocationCallbacks*, out VkFramebuffer_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkFramebuffer_T pFramebuffer)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pFramebuffer);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkFramebuffer_T pFramebuffer)
    {
        return ((delegate* unmanaged<VkDevice_T, VkFramebufferCreateInfo*, VkAllocationCallbacks*, out VkFramebuffer_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pFramebuffer);
    }

    public static explicit operator PFN_vkCreateFramebuffer(void* ptr) => new(ptr);
}


