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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 19323 Column: 30
public unsafe struct PFN_vkCopyMemoryToAccelerationStructureKHR
{
    public PFN_vkCopyMemoryToAccelerationStructureKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T deferredOperation, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
        return InvokeFunc(device, deferredOperation, pInfo);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T deferredOperation, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, AdamantiumVulkan.Core.Interop.VkCopyMemoryToAccelerationStructureInfoKHR*, Result>)ptr)(device, deferredOperation, pInfo);
    }

    public static explicit operator PFN_vkCopyMemoryToAccelerationStructureKHR(void* ptr) => new(ptr);
}


