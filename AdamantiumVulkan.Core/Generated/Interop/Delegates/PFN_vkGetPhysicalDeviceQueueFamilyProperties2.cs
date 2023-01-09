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

public unsafe struct PFN_vkGetPhysicalDeviceQueueFamilyProperties2
{
    public PFN_vkGetPhysicalDeviceQueueFamilyProperties2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkQueueFamilyProperties2*, void>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkQueueFamilyProperties2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkPhysicalDevice_T physicalDevice, ref uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
    {
         InvokeFunc(physicalDevice, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }
    public static void Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, ref uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
    {
         ((delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkQueueFamilyProperties2*, void>)ptr)(physicalDevice, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceQueueFamilyProperties2(void* ptr) => new(ptr);
}


