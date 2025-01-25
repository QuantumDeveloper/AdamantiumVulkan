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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 18402 Column: 30
public unsafe struct PFN_vkWriteMicromapsPropertiesEXT
{
    public PFN_vkWriteMicromapsPropertiesEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapEXT_T*, QueryType, ulong, void*, ulong, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapEXT_T*, QueryType, ulong, void*, ulong, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint micromapCount, AdamantiumVulkan.Core.Interop.VkMicromapEXT_T* pMicromaps, QueryType queryType, ulong dataSize, void* pData, ulong stride)
    {
        return InvokeFunc(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint micromapCount, AdamantiumVulkan.Core.Interop.VkMicromapEXT_T* pMicromaps, QueryType queryType, ulong dataSize, void* pData, ulong stride)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapEXT_T*, QueryType, ulong, void*, ulong, Result>)ptr)(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
    }

    public static explicit operator PFN_vkWriteMicromapsPropertiesEXT(void* ptr) => new(ptr);
}


