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

public unsafe struct PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR
{
    public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, VkSparseImageFormatProperties2*, void>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, VkSparseImageFormatProperties2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkPhysicalDevice_T physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, ref uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
    {
         InvokeFunc(physicalDevice, pFormatInfo, ref pPropertyCount, pProperties);
    }
    public static void Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, ref uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
    {
         ((delegate* unmanaged<VkPhysicalDevice_T, VkPhysicalDeviceSparseImageFormatInfo2*, ref uint*, VkSparseImageFormatProperties2*, void>)ptr)(physicalDevice, pFormatInfo, ref pPropertyCount, pProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* ptr) => new(ptr);
}

