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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 12129 Column: 30
public unsafe struct PFN_vkGetPipelineBinaryDataKHR
{
    public PFN_vkGetPipelineBinaryDataKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineBinaryDataInfoKHR*, AdamantiumVulkan.Core.Interop.VkPipelineBinaryKeyKHR*, ref ulong*, void*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineBinaryDataInfoKHR*, AdamantiumVulkan.Core.Interop.VkPipelineBinaryKeyKHR*, ref ulong*, void*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineBinaryDataInfoKHR* pInfo, AdamantiumVulkan.Core.Interop.VkPipelineBinaryKeyKHR* pPipelineBinaryKey, ref ulong* pPipelineBinaryDataSize, void* pPipelineBinaryData)
    {
        return InvokeFunc(device, pInfo, pPipelineBinaryKey, ref pPipelineBinaryDataSize, pPipelineBinaryData);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineBinaryDataInfoKHR* pInfo, AdamantiumVulkan.Core.Interop.VkPipelineBinaryKeyKHR* pPipelineBinaryKey, ref ulong* pPipelineBinaryDataSize, void* pPipelineBinaryData)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineBinaryDataInfoKHR*, AdamantiumVulkan.Core.Interop.VkPipelineBinaryKeyKHR*, ref ulong*, void*, Result>)ptr)(device, pInfo, pPipelineBinaryKey, ref pPipelineBinaryDataSize, pPipelineBinaryData);
    }

    public static explicit operator PFN_vkGetPipelineBinaryDataKHR(void* ptr) => new(ptr);
}


