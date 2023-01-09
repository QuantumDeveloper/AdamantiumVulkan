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

public unsafe struct PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR
{
    public PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkPhysicalDevice_T physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
    {
         InvokeFunc(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
    }
    public static void Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
    {
         ((delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)ptr)(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR(void* ptr) => new(ptr);
}


