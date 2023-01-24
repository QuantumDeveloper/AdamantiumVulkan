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

public unsafe struct PFN_vkCreateOpticalFlowSessionNV
{
    public PFN_vkCreateOpticalFlowSessionNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreateInfoNV* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T pSession)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pSession);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreateInfoNV* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T pSession)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionCreateInfoNV*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pSession);
    }

    public static explicit operator PFN_vkCreateOpticalFlowSessionNV(void* ptr) => new(ptr);
}


