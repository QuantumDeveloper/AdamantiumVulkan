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

public unsafe struct PFN_vkGetDisplayPlaneCapabilitiesKHR
{
    public PFN_vkGetDisplayPlaneCapabilitiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkDisplayModeKHR_T, uint, VkDisplayPlaneCapabilitiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkDisplayModeKHR_T, uint, VkDisplayPlaneCapabilitiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkPhysicalDevice_T physicalDevice, VkDisplayModeKHR_T mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
    {
        return InvokeFunc(physicalDevice, mode, planeIndex, pCapabilities);
    }
    public static Result Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkDisplayModeKHR_T mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
    {
        return ((delegate* unmanaged<VkPhysicalDevice_T, VkDisplayModeKHR_T, uint, VkDisplayPlaneCapabilitiesKHR*, Result>)ptr)(physicalDevice, mode, planeIndex, pCapabilities);
    }

    public static explicit operator PFN_vkGetDisplayPlaneCapabilitiesKHR(void* ptr) => new(ptr);
}

