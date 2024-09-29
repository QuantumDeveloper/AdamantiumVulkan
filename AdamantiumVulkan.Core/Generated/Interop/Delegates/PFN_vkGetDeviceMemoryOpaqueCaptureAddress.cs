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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6437 Column: 30
public unsafe struct PFN_vkGetDeviceMemoryOpaqueCaptureAddress
{
    public PFN_vkGetDeviceMemoryOpaqueCaptureAddress(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> InvokeFunc;

    public void* NativePointer { get; }

    public ulong Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
    {
        return InvokeFunc(device, pInfo);
    }
    public static ulong Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)ptr)(device, pInfo);
    }

    public static explicit operator PFN_vkGetDeviceMemoryOpaqueCaptureAddress(void* ptr) => new(ptr);
}


