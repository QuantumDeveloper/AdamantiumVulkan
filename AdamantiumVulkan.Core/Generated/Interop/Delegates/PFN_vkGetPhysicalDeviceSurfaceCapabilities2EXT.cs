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

public unsafe struct PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT
{
    public PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkSurfaceKHR_T, VkSurfaceCapabilities2EXT*, Result>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkSurfaceKHR_T, VkSurfaceCapabilities2EXT*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkPhysicalDevice_T physicalDevice, VkSurfaceKHR_T surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
    {
        return InvokeFunc(physicalDevice, surface, pSurfaceCapabilities);
    }
    public static Result Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkSurfaceKHR_T surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
    {
        return ((delegate* unmanaged<VkPhysicalDevice_T, VkSurfaceKHR_T, VkSurfaceCapabilities2EXT*, Result>)ptr)(physicalDevice, surface, pSurfaceCapabilities);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(void* ptr) => new(ptr);
}


