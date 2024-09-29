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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 12129 Column: 30
public unsafe struct PFN_vkGetImageViewHandleNVX
{
    public PFN_vkGetImageViewHandleNVX(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX*, uint>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX*, uint> InvokeFunc;

    public void* NativePointer { get; }

    public uint Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX* pInfo)
    {
        return InvokeFunc(device, pInfo);
    }
    public static uint Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX* pInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageViewHandleInfoNVX*, uint>)ptr)(device, pInfo);
    }

    public static explicit operator PFN_vkGetImageViewHandleNVX(void* ptr) => new(ptr);
}


