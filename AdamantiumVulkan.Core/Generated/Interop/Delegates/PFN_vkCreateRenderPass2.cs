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

public unsafe struct PFN_vkCreateRenderPass2
{
    public PFN_vkCreateRenderPass2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, out VkRenderPass_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, out VkRenderPass_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkRenderPass_T pRenderPass)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pRenderPass);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkRenderPass_T pRenderPass)
    {
        return ((delegate* unmanaged<VkDevice_T, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, out VkRenderPass_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pRenderPass);
    }

    public static explicit operator PFN_vkCreateRenderPass2(void* ptr) => new(ptr);
}

