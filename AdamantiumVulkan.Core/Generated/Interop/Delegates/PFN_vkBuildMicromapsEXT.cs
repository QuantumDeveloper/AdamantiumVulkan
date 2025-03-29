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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18525 Column: 30
public unsafe struct PFN_vkBuildMicromapsEXT
{
    public PFN_vkBuildMicromapsEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T deferredOperation, uint infoCount, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pInfos)
    {
        return InvokeFunc(device, deferredOperation, infoCount, pInfos);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T deferredOperation, uint infoCount, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pInfos)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeferredOperationKHR_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, Result>)ptr)(device, deferredOperation, infoCount, pInfos);
    }

    public static explicit operator PFN_vkBuildMicromapsEXT(void* ptr) => new(ptr);
}


